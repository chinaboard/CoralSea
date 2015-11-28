using CoralSea.Model.User;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace CoralSea.Web.Controllers
{
    public abstract class BaseController : Controller
    {
        internal protected UserInfoModel CurrentUserInfo
        {
            get
            {

            }
        }
    }
}