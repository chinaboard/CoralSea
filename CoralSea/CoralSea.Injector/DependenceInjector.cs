using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CoralSea.Injector
{
    /// <summary>
    /// 依赖注入器
    /// </summary>
    public class DependenceInjector
    {
        private static readonly Finder finder = Finder.GetInstance();

        /// <summary>
        /// 以默认方式获取对象实例
        /// </summary>
        /// <typeparam name="T">待获取对象的类型</typeparam>
        /// <returns></returns>
        public static T GetInstance<T>()
        {
            return finder.GetClassInstance<T>();
        }
    }
}
