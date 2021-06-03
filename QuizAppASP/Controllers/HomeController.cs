using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace QuizAppASP.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Homepage()
        {
            return View();
        }
        public ActionResult ShowDashboard()
        {
            return View("Register");
        }
        public ActionResult About()
        {
            return View("About");
        }
    }
}