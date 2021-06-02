using QuizAppASP.Models;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace QuizAppASP.Controllers
{
    public class AccountController : Controller
    {
       
        [HttpGet]
        public ActionResult Login()
        {
            return View();
        }
        [HttpGet]
        public ActionResult Register()
        {
            return View();
        }
        void ConnectionString()
        {
        }
        [HttpPost]
        public ActionResult Verify(Account account)
        {
            if (dr.Read())
            {
              
            }
            else
            {
              
            }
        }
        [HttpPost]
        public ActionResult RegisterUser(Account account)
        {
            string query = "Insert Into Login (LoginFirstName             ,LoginLastName             ,LoginEmail            ,LoginPassword              ,LoginActive  )" +
                                      " values('" + account.FirstName + "','" + account.LastName + "','" + account.Email + "','" + account.Password + "',1 )";
            SQL.NonScalarQuery(query);
            return View("Login");
        }
    }
}