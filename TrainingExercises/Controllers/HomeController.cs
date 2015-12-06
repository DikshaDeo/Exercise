using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace TrainingExercises.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult exercise1()
        {
            return View();
        }

        public ActionResult exercise2()
        {
            ViewBag.Message = "Employee description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}