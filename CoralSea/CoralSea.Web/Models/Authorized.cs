using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;
using CoralSea.Model.User;

namespace CoralSea.Web.Models
{
    public class Authorized : AuthorizeAttribute
    {
        public override void OnAuthorization(AuthorizationContext filterContext)
        {
            if (filterContext == null)
            {
                throw new ArgumentNullException("filterContext");
            }
            base.OnAuthorization(filterContext);
            UserInfoModel userInfo = filterContext.HttpContext.Session["UserInfo"] as UserInfoModel;
            if (userInfo == null)
            {
                filterContext.Result = new RedirectToRouteResult(
                    new RouteValueDictionary
                    {
                         {"controller", "Account"},
                         {"action", "Login"},                         {"returnUrl", filterContext.HttpContext.Request.RawUrl}
                  });
                return;
            }
          string[] raws=  filterContext.HttpContext.Request.RawUrl.Split(new[] {","}, StringSplitOptions.RemoveEmptyEntries);
            string controller = raws.Length > 0 ? raws[0] : "Home";
            string action = raws.Length > 1 ? raws[1] : "Index";
            filterContext.Result = new RedirectToRouteResult(
                    new RouteValueDictionary
                    {
                         {"controller", controller},
                         {"action", action},                         {"returnUrl", filterContext.HttpContext.Request.RawUrl}
                  });
        }
    }
}