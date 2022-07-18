﻿using SV18T1021002.BusinessLayer;
using SV18T1021002.WEB.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace SV18T1021002.WEB.Controllers
{/// <summary>
 /// 
 /// </summary>
    [Log]
    public class HomeController : Controller
    {
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

        public ActionResult Categories()
        {
            var model = BusinessLayer.CommonDataService.ListOfCategories();
            return View(model);
        }
    }
}