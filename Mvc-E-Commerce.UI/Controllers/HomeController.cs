using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Mvc_E_Commerce.UI.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult CategoryPage()
        {
            return View();
        }
        public ActionResult SingleProduct()
        {
            return View();
        }
    }
}