using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MVC_DemoPractice.ViewModels
{
    public class LoginViewModel
    {
        public string Account { get; set; }
        public string Password { get; set; }
        public string Message { get; set; }
    }
}