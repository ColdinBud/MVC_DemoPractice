using MVC_DemoPractice.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVC_DemoPractice.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            var model = new MyClass
            {
                Title = "My Title",
                Body = "My Body"
            };

            return View(model);

        }

        public ActionResult ChildAction()
        {
            var model = new MyClass
            {
                Title = "Child Title",
                Body = "Child Body"
            };

            return View(model);
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