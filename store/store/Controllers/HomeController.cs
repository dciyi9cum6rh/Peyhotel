﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace store.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            加了這裡
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";
            987654321
            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}