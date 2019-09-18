using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using PartialViewDemo.Models;


namespace PartialViewDemo.Controllers
{
    public class ProductsController : Controller
    {

        List<Product> products = new List<Product>()
        {
            new Product {ProductID=1, Name ="charger", Price=500.00, Photo = "~/images/1.jpg" },
            new Product {ProductID=2, Name ="hub", Price=150.00, Photo = "~/images/2.jpg" },
            new Product {ProductID=3, Name ="hdmi", Price=50.00, Photo = "~/images/3.jpg" },
            new Product {ProductID=4, Name ="sd", Price=2500.00, Photo = "~/images/4.jpg" }


        };
        // GET: Products
        public ActionResult Index()
        {
            return View();
        }
    }
}