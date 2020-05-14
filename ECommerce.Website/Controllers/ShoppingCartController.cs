using ECommerce.Logic.Objects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ECommerce.Website.Controllers
{
    public class ShoppingCartController : Controller
    {
        [HttpGet]
        public ActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public ActionResult AddToCart(int id)
        {
            ShoppingCart.AddToCart(id);
            return null;
        }
        [HttpPost]
        public ActionResult RemoveFromCart(int id)
        {
            ShoppingCart.DeleteFromCart(id);
            return null;
        }
    }
}