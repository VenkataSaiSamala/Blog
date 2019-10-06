using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using DataAccess;

namespace Blog.Controllers
{
    public class HomeController : Controller
    {
        BlogContext blogContext = new BlogContext(); 
        [HttpGet]
        public ActionResult Index()
        {
            var blog = blogContext.Blog.ToList();
            return View(blog);
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