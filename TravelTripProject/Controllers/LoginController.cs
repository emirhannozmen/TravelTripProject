using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Security;
using TravelTripProject.Models.Entities;

namespace TravelTripProject.Controllers
{
    public class LoginController : Controller
    {
        Context c = new Context();
        public ActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Index(Admin admin)
        {
            var infos = c.Admins.FirstOrDefault(x => x.Username == admin.Username && x.Password == admin.Password);
            if (infos != null)
            {
                FormsAuthentication.SetAuthCookie(infos.Username, false);
                Session["Username"] = infos.Username.ToString();
                return RedirectToAction("Index", "Admin");
            }
            else
            {
                return View();
            }
        }

        public ActionResult Logout()
        {
            FormsAuthentication.SignOut();
            return RedirectToAction("Index", "Login");
        }
    }
}