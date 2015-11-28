using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CoralSea.Injector
{
    /// <summary>
    /// 默认依赖注入实例类查找策略
    /// </summary>
    public class DefaultResolvePolicy : IResolvePolicy
    {
        #region IResovlePolicy 成员

        /// <summary>
        /// 比较目标对象是否是泛型对象的实现
        /// </summary>
        /// <typeparam name="T">泛型类型</typeparam>
        /// <param name="type">目标对象</param>
        /// <returns>若目标对象是泛型对象实现则返回true，否则返回false</returns>
        public bool IsInstanceOf<T>(Type type)
        {
            bool ret = false;
            if (type.FullName.StartsWith("System", StringComparison.OrdinalIgnoreCase)
                || type.IsInterface
                || type.IsAbstract)
            {
                return false;
            }

            Type ancestor = typeof(T);
            ret = ancestor.IsInterface ? InterfaceCompare(type, ancestor) : ClassCompare(type, ancestor);

            return ret;
        }

        private static bool ClassCompare(Type type, Type ancestor)
        {
            bool ret = false;

            if (ancestor == type)
            {
                ret = true;
            }
            else
            {
                throw new NotSupportedException("当前依赖注入只支持接口实例创建！");
            }

            return ret;
        }

        private static bool InterfaceCompare(Type type, Type ancestor)
        {
            bool ret = false;

            if (type.BaseType != null && type.BaseType == ancestor)
            {
                ret = true;
            }
            else
            {
                // convention than config (约定大于配置)
                string ancestorName = ancestor.Name;
                if (ancestorName.StartsWith("I", StringComparison.OrdinalIgnoreCase))
                {
                    ancestorName = ancestorName.Substring(1);
                }

                ret = type.FullName.EndsWith(ancestorName);
            }

            return ret;
        }

        #endregion
    }
}
