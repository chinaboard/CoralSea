using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel;

namespace CoralSea.Model
{
    public class UserLoginModel
    {
        public LoginType LoginType { get; set; }

        public string Username { get; set; }

        public string Password { get; set; }

        public string JobNumber { get; set; }

        public string IdNumber { get; set; }
    }

    public enum LoginType : int
    {
        Unknow = 0,

        /// <summary>
        /// 新手登录
        /// </summary>
        [Description("新手登录")]
        Novice = 0x01,

        /// <summary>
        /// 老手登录
        /// </summary>
        [Description("老手登录")]
        Veteran = 0x01 << 1
    }
}
