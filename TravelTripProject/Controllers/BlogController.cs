using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Lifetime;
using System.Web;
using System.Web.Mvc;
using System.Web.UI.WebControls;
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
            bc.value2 = c.Blogs.Take(5).ToList();
            return View(bc);
        }

        public ActionResult BlogDetail(int id)
        {
            bc.value1 = c.Blogs.Where(x => x.Id == id).ToList();
            bc.value2 = c.Blogs.Take(5).ToList();
            bc.value3 = c.Comments.Where(x => x.BlogId == id).ToList();
            return View(bc);
        }

        [HttpGet]
        public PartialViewResult AddComment(int id)
        {
            ViewBag.Id = id;
            return PartialView();
        }

        [HttpPost]
        public PartialViewResult AddComment(Comment comment)
        {
            c.Comments.Add(comment);
            c.SaveChanges();
            return PartialView();
        }

    }
}