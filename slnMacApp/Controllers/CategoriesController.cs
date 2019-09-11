using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using slnMacApp.Models;

namespace slnMacApp.Controllers
{
    public class CategoriesController : Controller
    {
        // GET: Categories
        public ActionResult Index()
        {
            devuserEntities DevUserObj = new devuserEntities();
            List<Category> category = DevUserObj.Categories.ToList();
            return View(category);
        }
    }
}