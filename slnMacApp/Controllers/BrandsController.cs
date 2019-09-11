using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using slnMacApp.Models;
namespace slnMacApp.Controllers
{
    public class BrandsController : Controller
    {
        // GET: Brands
        public ActionResult Index()
        {
            devuserEntities DevUserObj = new devuserEntities();
            List<Brand> brands = DevUserObj.Brands.ToList();
            return View(brands);
        }
    }
}