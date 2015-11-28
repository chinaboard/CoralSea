using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CoralSea.Injector
{
    /// <summary>
    /// 依赖注入实例类查找策略接口
    /// </summary>
    public interface IResolvePolicy
    {
        /// <summary>
        /// 比较目标对象是否是泛型对象的实现
        /// </summary>
        /// <typeparam name="T">泛型类型</typeparam>
        /// <param name="type">目标对象</param>
        /// <returns>若目标对象是泛型对象实现则返回true，否则返回false</returns>
        bool IsInstanceOf<T>(Type type);
    }
}
