using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using slnMacApp.Models;
namespace slnMacApp.Controllers
{
    public class ProductsController : Controller
    {
        // GET: Products
        [HttpGet]
        public ActionResult Index(string Search="")
        {
            devuserEntities DevUserObj = new devuserEntities();
            ViewBag.Search = Search;
            List<Product> product = DevUserObj.Products.Where(temp => temp.ProductName.Contains(Search)).ToList();
            return View(product);
        }

        [HttpGet]
        public ActionResult Details(long id)
        {
            devuserEntities DevUserObj = new devuserEntities();
            Product product = DevUserObj.Products.Where(temp => temp.ProductID == id).FirstOrDefault();
            return View(product);
        }

        [HttpGet]
        public ActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Create(Product products)
        {
            devuserEntities DevUserObj = new devuserEntities();
            DevUserObj.Products.Add(products);
            DevUserObj.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}