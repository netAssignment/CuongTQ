using Prepool_k21_BookStore.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Prepool_k21_BookStore.Controllers
{
    public class HomePageController : Controller
    {
        // 
        // GET: /HelloWorld/ 
        private BookDb db = new BookDb();
        public ActionResult Index()
        {
            return View(db.Books.ToList());
        }

        // 
        // GET: /HelloWorld/Welcome/ 

        public string Welcome()
        {
            return "This is the Welcome action method...";
        }

        public ActionResult Detail()
        {
            return View();
        }
    }
}
