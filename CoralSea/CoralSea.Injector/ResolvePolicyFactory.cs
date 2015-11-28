using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CoralSea.Injector
{
    /// <summary>
    /// 依赖注入实例类查找策略构造工厂
    /// </summary>
    public static class ResolvePolicyFactory
    {
        private static IResolvePolicy _policy = new DefaultResolvePolicy();

        /// <summary>
        /// 注册依赖注入实例类查找策略
        /// </summary>
        /// <param name="policy">待注册的策略</param>
        public static void RegisterPolicy(IResolvePolicy policy)
        {
            _policy = policy;
        }

        /// <summary>
        /// 获取依赖注入实例类查找策略
        /// </summary>
        /// <returns></returns>
        public static IResolvePolicy GetPolicy()
        {
            return _policy;
        }
    }
}
