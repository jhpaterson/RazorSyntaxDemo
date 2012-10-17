using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using RazorSyntaxDemo.Models;

namespace RazorSyntaxDemo.Controllers
{
    public class HomeController : Controller
    {
        //
        // GET: /Home/

        public ActionResult Index()
        {
            Product product = new Product { ProductID = 1, ProductName = "Banana", Description = "Yellow", Price = 9.99M };
            return View(product);
        }

        public ActionResult LayoutDemo()
        {
            return View();
        }

    }
}
