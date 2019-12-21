using Mvc_E_Commerce.BLL.Controller;
using Mvc_E_Commerce.Entity.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Mvc_E_Commerce.UI.Controllers
{
    public class HomeController : Controller
    {
        private readonly CategoryController _CategoryController;
        public HomeController()
        {
            _CategoryController = new CategoryController();
        }
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult CategoryPage()
        {
            List<Category> categoryList = _CategoryController.GetCategorys();
            return View(categoryList);
        }
        public ActionResult SingleProduct()
        {
            return View();
        }
    }
}