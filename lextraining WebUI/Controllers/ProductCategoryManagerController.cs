using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using lextraining_dataMemory;
using lextraining_core.Models;

namespace lextraining_WebUI.Controllers
{
    public class ProductCategoryManagerController : Controller
    {
        ProductCategoryRepository context;
        public ProductCategoryManagerController()
        {
            context = new ProductCategoryRepository();
        }
        public ActionResult Index()
        {
            List<ProductCategory> productCategories = context.Collection().ToList();
            return View(productCategories);
        }
        public ActionResult Create()
        {
            Product product = new Product();
            return View(product);
        }


    }
}