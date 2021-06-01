using NewDataAccess;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using NewBusiness;

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

        public ActionResult Assignment_two()
        {
            ViewBag.Message = "Display data for assignment two";

            return View();
        }

        public ActionResult DisplayData()
        {
            ViewBag.Message = "Employees";

            //Get the Demographics Data from Business Layer
            var IndivDemo=NewBusinessClass.EmployeeInformation();

            return View(IndivDemo);

        }
    }
}