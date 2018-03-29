using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Blog_do_Raul.Models;


namespace Blog_do_Raul.Controllers
{
    public class PostsController : Controller
    {
        private Blogcontext _context = new Blogcontext();
        // GET: Posts
        public ActionResult Index()
        {
            var posts = _context.Post.ToList();
            return View();
        }
        public ActionResult Edit(int Id)
        {
            return View();
        }
        public ActionResult Delete(int Id)
        {
            return View();
        }
        [HttpPost]
        public ActionResult DeleteComplete(int Id)
        {
            return View();
        }
        [HttpPost]
        public ActionResult Save(Post post)
        {
            return View();
        }
        public ActionResult Details(int Id)
        {
            var post = _context.Post.SingleOrDefault(p => p.Id == Id);
            if (post == null)
            {
                return HttpNotFound();
            }
            return View();
        }
    }
}