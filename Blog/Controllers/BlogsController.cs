using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using DataAccess;

namespace Blog.Controllers
{
    public class BlogsController : Controller
    {
        private BlogContext db = new BlogContext();

        private DataAccess.Blog blog = new DataAccess.Blog();

        // GET: Blogs
        public ActionResult Index()
        {
            return View(db.Blog.ToList());
        }

        //GET: Blogs/Details/5
        public ActionResult Details(int id)
        {
            blog = db.Blog.Where(b => b.BlogId == id).FirstOrDefault();
            return View(blog);
        }

        // GET: Blogs/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Blogs/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(DataAccess.Blog blog)
        {

            blog.BlogDate = DateTime.Now;

            if (ModelState.IsValid)
            {
                db.Blog.Add(blog);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(blog);
        }

        // GET: Blogs/Edit/5




        // GET: Blogs/Delete/5


        // POST: Blogs/Delete/5


    }
}
