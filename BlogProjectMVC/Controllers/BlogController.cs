using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace BlogProjectMVC.Controllers
{
    public class BlogController : Controller
    {

        masterEntities nd = new masterEntities();
        // GET: Blog
        public ActionResult Index()
        {
            var blogDetails = nd.BLOG.ToList();

            return View(blogDetails);    
        }

        public ActionResult UploadBlog ()
        {
            return View();
        }
        [HttpPost]
        public ActionResult UploadBlog(BLOG bg)
        {         
            nd.BLOG.Add(bg);
            nd.SaveChanges();
            ViewBag.message = "Blog basari ile eklendi.";
            return View();
        }

        public ActionResult Food()
        {
            var foodArticle = nd.BLOG.Where(x => x.BCategory == "Food");
            return View(foodArticle);
        }

        public ActionResult Sports()
        {
            var sportsArticle = nd.BLOG.Where(x => x.BCategory == "Sports");
            return View(sportsArticle);
        }

        public ActionResult Movies()
        {
            var movieArticle = nd.BLOG.Where(x => x.BCategory == "Movies");
            return View(movieArticle);
        }

        public ActionResult Recepies()
        {
            
            return View();
        }
    }

}