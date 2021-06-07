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
        [HttpPost]
        public ActionResult Verify(Account account)
        {
            if (Main.verifyUser(account.Email, account.Password))
            {
                return View("~/Views/Home/Homepage.cshtml");
            }
            else
            {
                return View("Register");
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
        public ActionResult Users(Account account)
        {
            string con = @"Data Source=ABDUL-MOIZ\SQLEXPRESS;Initial Catalog=QuizAppAsp;Integrated Security=True;Pooling=False";
            String sql = "SELECT * FROM Login";
            SqlCommand cmd = new SqlCommand(sql, SQL.Con);

            var model = new List<Account>();
            if (SQL.Con.State == System.Data.ConnectionState.Open)
            {
                SQL.Con.Close();
            }
            SQL.Con.Open();
            SqlDataReader rdr = cmd.ExecuteReader();
            while (rdr.Read())
            {
                var users = new Account();
                users.FirstName = rdr["LoginFirstName"].ToString();
                users.LastName = rdr["LoginLastName"].ToString();
                users.Email = rdr["LoginEmail"].ToString();

                model.Add(users);
            }
            return View(model);
        }
    }
}