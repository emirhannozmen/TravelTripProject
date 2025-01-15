using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using TravelTripProject.Models.Entities;

namespace TravelTripProject.Controllers
{
    public class BlogController : Controller
    {
        Context c = new Context();
        BlogComment bc = new BlogComment();
        public ActionResult Index()
        {
            bc.value1 = c.Blogs.ToList();
            bc.value2 = c.Blogs.Take(3).ToList();
            return View(bc);
        }
        public ActionResult BlogDetail(int id)
        {
            bc.value1 = c.Blogs.Where(x => x.Id == id).ToList();
            bc.value3 = c.Comments.Where(x => x.Id == id).ToList();
            return View(bc);
        }
    }
}