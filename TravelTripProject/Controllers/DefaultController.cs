using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using TravelTripProject.Models.Entities;

namespace TravelTripProject.Controllers
{
    public class DefaultController : Controller
    {
        Context c = new Context();
        public ActionResult Index()
        {
            var values = c.Blogs.Take(5).ToList();
            return View(values);
        }
        public PartialViewResult PartialReadMoreLeft()
        {
            var values = c.Blogs.OrderByDescending(x => x.Id).Take(2).ToList();
            return PartialView(values);
        }
        public PartialViewResult PartialReadMoreRight()
        {
            var values = c.Blogs.Where(x => x.Id == 1).Take(2).ToList();
            return PartialView(values);
        }
        public PartialViewResult PartialTopBlog()
        {
            var values = c.Blogs.Take(10).ToList();
            return PartialView(values);
        }
        public PartialViewResult PartialOurPlacesLeft()
        {
            var values = c.Blogs.Take(3).ToList();
            return PartialView(values);
        }
        public PartialViewResult PartialOurPlacesRight()
        {
            var values = c.Blogs.Take(3).ToList();
            return PartialView(values);
        }

    }
}