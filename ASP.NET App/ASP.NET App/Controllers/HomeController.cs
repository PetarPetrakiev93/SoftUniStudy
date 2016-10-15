﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ASP.NET_App.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Calculate(decimal num1, decimal num2)
        {
            this.ViewBag.num1 = num1;
            this.ViewBag.num2 = num2;
            this.ViewBag.sum = num1 + num2;
            return View("Index");
        }

        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}