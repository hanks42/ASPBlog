﻿using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using BlogSiteTest.Models;

namespace BlogSiteTest.Controllers
{
    public class BlogController : Controller
    {
        private BlogDBContext db = new BlogDBContext();

        //
        // GET: /Blog/

        public ActionResult Index()
        {
            // Disable this view as it repeats the home view
            return RedirectToAction("Index", "Home");
        }

        //
        // GET: /Blog/Details/5

        public ActionResult Details(int id = 0)
        {
            BlogPost blogpost = db.BlogPosts.Find(id);
            if (blogpost == null)
            {
                return HttpNotFound();
            }
            return View(blogpost);
        }

        //
        // GET: /Blog/Create

        public ActionResult Create()
        {
            return View();
        }

        //
        // POST: /Blog/Create

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(BlogPost blogpost)
        {
            // Don't let non logged in users make posts
            if (!User.Identity.IsAuthenticated)
            {
                ModelState.AddModelError(string.Empty,
                    "You must login to create a post!");
            }
            else if (ModelState.IsValid)
            {
                // Set Creation date
                blogpost.DateCreated = DateTime.Now;

                // Set current user as the author
                blogpost.Author = User.Identity.Name;

                db.BlogPosts.Add(blogpost);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(blogpost);
        }

        //
        // GET: /Blog/Edit/5

        public ActionResult Edit(int id = 0)
        {
            BlogPost blogpost = db.BlogPosts.Find(id);
            if (blogpost == null)
            {
                return HttpNotFound();
            }
            return View(blogpost);
        }

        //
        // POST: /Blog/Edit/5

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(BlogPost editedpost)
        {

            // Retrieve actual post from DB that holds more data
            BlogPost post = db.BlogPosts.Find(editedpost.ID);
            // validate user
            if (User.Identity.Name != post.Author)
            {
                ModelState.AddModelError(string.Empty,
                    "unable to edit blog post as you are not the author!");
            }
            else if (ModelState.IsValid)
            {
                // Fill edited data into the post from the DB
                post.Title = editedpost.Title;
                post.Post = editedpost.Post;
                db.Entry(post).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(post);
        }

        //
        // GET: /Blog/Delete/5

        public ActionResult Delete(int id = 0)
        {
            BlogPost blogpost = db.BlogPosts.Find(id);
            if (blogpost == null)
            {
                return HttpNotFound();
            }
            return View(blogpost);
        }

        //
        // POST: /Blog/Delete/5

        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {

            BlogPost blogpost = db.BlogPosts.Find(id);
            // validate user
            if (User.Identity.Name != blogpost.Author)
            {
                ModelState.AddModelError(string.Empty,
                    "Unable to delete blog post as you are not the author!");
                return View(blogpost);
            }
            else
            {
                db.BlogPosts.Remove(blogpost);
                db.SaveChanges();
                return RedirectToAction("Index");
            }
        }

        protected override void Dispose(bool disposing)
        {
            db.Dispose();
            base.Dispose(disposing);
        }

        public PartialViewResult GetBlogposts(string author)
        {
            var posts = from p in db.BlogPosts select p;

            if (!String.IsNullOrEmpty(author))
            {
                posts = posts.Where(p => p.Author.Equals(author));
            }

            // Sort posts by newest first
            posts = posts.OrderByDescending(D => D.DateCreated);

            return PartialView("_BlogPosts", posts.ToList());
        }
    }
}