using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using TravelTripProject.Models.Entities;

namespace TravelTripProject.Controllers
{
    [Authorize]
    public class AdminController : Controller
    {
        
        Context c = new Context();
        public ActionResult Index()
        {
            var values = c.Blogs.ToList();
            return View(values);
        }

        public ActionResult AboutList()
        {
            var values = c.Abouts.ToList();
            return View(values);
        }

        [HttpGet]
        public ActionResult CreateAbout()
        {
            return View();
        }

        [HttpPost]
        public ActionResult CreateAbout(About about)
        {
            c.Abouts.Add(about);
            c.SaveChanges();
            return RedirectToAction("AboutList");
        }

        public ActionResult DeleteAbout(int id)
        {
            var about = c.Abouts.Find(id);
            c.Abouts.Remove(about);
            c.SaveChanges();
            return RedirectToAction("AboutList");
        }

        public ActionResult GetAbout(int id)
        {
            var about = c.Abouts.Find(id);
            return View("GetAbout", about);
        }

        public ActionResult UpdateAbout(About about)
        {
            var abt = c.Abouts.Find(about.Id);
            abt.ImageUrl = about.ImageUrl;
            abt.Description = about.Description;
            c.SaveChanges();
            return RedirectToAction("AboutList");
        }
        public ActionResult AddressList()
        {
            var values = c.Addresses.ToList();
            return View(values);
        }

        [HttpGet]
        public ActionResult CreateAddress()
        {
            return View();
        }

        [HttpPost]
        public ActionResult CreateAddress(Address address)
        {
            c.Addresses.Add(address);
            c.SaveChanges();
            return RedirectToAction("AdressList");
        }

        public ActionResult DeleteAddress(int id)
        {
            var address = c.Addresses.Find(id);
            c.Addresses.Remove(address);
            c.SaveChanges();
            return RedirectToAction("AddressList");
        }

        public ActionResult GetAddress(int id)
        {
            var address = c.Addresses.Find(id);
            return View("GetAddress", address);
        }

        public ActionResult UpdateAddress(Address address)
        {
            var adrs = c.Addresses.Find(address.Id);
            adrs.Title = address.Title;
            adrs.Description = address.Description;
            adrs.FullAddress = address.FullAddress;
            adrs.Email = address.Email;
            adrs.Phone = address.Phone;
            adrs.Location = address.Location;
            c.SaveChanges();
            return RedirectToAction("AddressList");
        }

        [HttpGet]
        public ActionResult CreateBlog()
        {
            return View();
        }

        [HttpPost]
        public ActionResult CreateBlog(Blog blog) 
        {
            c.Blogs.Add(blog);
            c.SaveChanges();
            return RedirectToAction("Index");
        }

        public ActionResult DeleteBlog(int id)
        {
            var blog = c.Blogs.Find(id);
            c.Blogs.Remove(blog);
            c.SaveChanges();
            return RedirectToAction("Index");
        }

        public ActionResult GetBlog(int id)
        {
            var blog = c.Blogs.Find(id);
            return View("GetBlog", blog);
        }

        public ActionResult UpdateBlog(Blog blog)
        {
            var blg = c.Blogs.Find(blog.Id);
            blg.Title = blog.Title;
            blg.Description = blog.Description;
            blg.ImageUrl = blog.ImageUrl;
            blg.Date = blog.Date;
            c.SaveChanges();
            return RedirectToAction("Index");
        }

        public ActionResult CommentList()
        {
            var values = c.Comments.ToList();
            return View(values);
        }

        public ActionResult DeleteComment(int id)
        {
            var comment = c.Comments.Find(id);
            c.Comments.Remove(comment);
            c.SaveChanges();
            return RedirectToAction("CommentList");
        }

        public ActionResult GetComment(int id)
        {
            var comment = c.Comments.Find(id);
            return View("GetComment", comment);
        }

        public ActionResult UpdateComment(Comment comment)
        {
            var blg = c.Comments.Find(comment.Id);
            blg.SenderName = comment.SenderName;
            blg.Email = comment.Email;
            blg.Content = comment.Content;
            c.SaveChanges();
            return RedirectToAction("CommentList");
        }

    }   
}