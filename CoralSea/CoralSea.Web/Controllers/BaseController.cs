using CoralSea.Model.User;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using CoralSea.Web.Models;

namespace CoralSea.Web.Controllers
{
    public abstract class BaseController : Controller
    {
        internal protected UserInfoModel CurrentUserInfo
        {
            get
            {
                return (UserInfoModel)Session["UserInfo"];
            }
        }
    }
}