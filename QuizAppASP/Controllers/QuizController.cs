﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace QuizAppASP.Controllers
{
    public class QuizController : Controller
    {
        // GET: Quiz
        public ActionResult Join()
        {
            return View();
        }

        public ActionResult QuizPage()
        {
            return View();
        }
    }
}