using NewsPressWebForm.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web;

namespace NewsPressWebForm.Controllers
{
    public class AccountController : ApiController
    {
        public static bool SignIn(string username, string password)
        {
            
            using (var context = new PressNewsContext())
            {
                HttpContext.Current.Session["user"] = "admin";
                return context.Users.Any(u => u.UserName.Equals(username) && u.Password == password);
            }
        }
    }
}
