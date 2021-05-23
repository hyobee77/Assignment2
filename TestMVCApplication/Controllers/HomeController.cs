﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Assignment_1.Controllers
{
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
        public ActionResult Assignment_one()
        {
            ViewBag.Message = "Your team member page.";

            return View();
        }
        public ActionResult DisplayData()
        {
            ViewBag.Message = "Individual Demographics";

            //Get the Demographics Data from Business Layer
            var IndivDemo = Demographics.GetIndividulDemographicData();
            //var IndivDemos = Demographics.GetDemoForIndiv();
            return View(IndivDemo);

        }
    }
}