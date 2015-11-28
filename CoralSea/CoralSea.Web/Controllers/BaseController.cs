using CoralSea.Model.User;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace CoralSea.Web.Controllers
{
    public class BaseController : Controller
    {
        public UserInfoModel CurrentUserInfo { get; set; }
    }
}