using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;

namespace CoralSea.Injector
{
    /// <summary>
    /// 类查找器
    /// </summary>
    internal class Finder
    {
        private static readonly InjectorConfig config = InjectorConfig.GetInstance();
        private static readonly Object objLock = new Object();
        private static Finder instance = null;

        private ConcurrentDictionary<String, Object> _cache = null;

        private Finder()
        {
            _cache = new ConcurrentDictionary<string, object>();

            Initialize();
        }

        public static Finder GetInstance()
        {
            if (instance == null)
            {
                lock (objLock)
                {
                    if (instance == null)
                    {
                        instance = new Finder();
                    }
                }
            }

            return instance;
        }

        public Object this[string key]
        {
            get
            {
                Object ret = null;
                _cache.TryGetValue(key, out ret);

                return ret;
            }
            set
            {
                _cache.AddOrUpdate(key, value, (k, v) => { v = value; return value; });
            }
        }

        /// <summary>
        /// 初始化查询器
        /// </summary>
        private void Initialize()
        {
            if (String.IsNullOrWhiteSpace(config.AssemblyPath))
            {
                throw new ArgumentNullException("AssemblyPath");
            }

            string[] dlls = Directory.GetFiles(config.AssemblyPath, "*.dll", SearchOption.AllDirectories);
            foreach (string item in dlls)
            {
                Assembly.LoadFrom(item);
            }
        }

        /// <summary>
        /// 获取类实例
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <returns></returns>
        public T GetClassInstance<T>()
        {
            Object obj = this[typeof(T).FullName];
            if (obj == null)
            {
                T ret = CreateInstance<T>();
                this[typeof(T).FullName] = ret;
                return ret;
            }

            return (T)obj;
        }

        private T CreateInstance<T>()
        {
            T ret = default(T);
            IResolvePolicy policy = ResolvePolicyFactory.GetPolicy();
            bool isFound = false;

            Assembly[] assemblies = AppDomain.CurrentDomain.GetAssemblies();
            foreach (var item in assemblies)
            {
                Type[] types = item.GetTypes();
                foreach (var type in types)
                {
                    if (policy.IsInstanceOf<T>(type))
                    {
                        ret = (T)Activator.CreateInstance(type);
                        isFound = true;
                        break;
                    }
                }

                if (isFound) break;
            }

            return ret;
        }
    }
}
