﻿using QuizAppASP.Models;
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
        SqlConnection con = new SqlConnection();
        SqlCommand cmd = new SqlCommand();
        SqlDataReader dr;

        [HttpGet]
        public ActionResult Login()
        {
            return View();
        }
        void ConnectionString()
        {
            con.ConnectionString = @"Data Source=ABDUL-MOIZ\SQLEXPRESS;Initial Catalog=TestDatabae;Integrated Security=True;Pooling=False";
        }
        [HttpPost]
        public ActionResult Verify(Account account)
        {
            ConnectionString();
            con.Open();
            cmd.Connection = con;
            cmd.CommandText = "select * from login where Name = '" + account.email + "' and Password = '" + account.Password + "'";
            dr = cmd.ExecuteReader();
            if (dr.Read())
            {
                con.Close();
                return View("Create");
            }
            else
            {
                con.Close();
                return View("LoginError");
            }
        }
    }
}