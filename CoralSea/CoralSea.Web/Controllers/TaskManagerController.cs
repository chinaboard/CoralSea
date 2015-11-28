using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace CoralSea.Web.Controllers
{
    public class TaskManagerController : Controller
    {
        // GET: TaskManager
        public ActionResult TaskList()
        {
            return View();
        }
    }
}