using MVC_DemoPractice.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVC_DemoPractice.Controllers
{
    public class UserController : Controller
    {
        // GET: User
        public ActionResult Login()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Login(LoginViewModel pageData)
        {
            if (pageData.Account == "skill"
                && pageData.Password == "tree")
            {
                pageData.Message = $"User: {pageData.Account} Login Success";
            }

            return View(pageData);
        }
    }
}