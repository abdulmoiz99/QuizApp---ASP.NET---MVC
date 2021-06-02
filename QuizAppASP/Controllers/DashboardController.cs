using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace QuizAppASP.Controllers
{
    public class DashboardController : Controller
    {
        // GET: Dashboard
        [HttpPost]
        public ActionResult Dashboard()
        {
            return View();
        }
    }
}