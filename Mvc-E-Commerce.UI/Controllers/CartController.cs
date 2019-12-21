using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Mvc_E_Commerce.UI.Controllers
{
    public class CartController : Controller
    {
        // GET: Cart
        public ActionResult Cart()
        {
            return View();
        }
    }
}