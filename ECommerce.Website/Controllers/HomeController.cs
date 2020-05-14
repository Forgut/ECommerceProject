using ECommerce.Logic.Builders.Home;
using ECommerce.Logic.Objects;
using ECommerce.Logic.Models.Home;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ECommerce.Website.Controllers
{
    public class HomeController : Controller
    {
        private ShoppingCart _shoppingCart;
        public ActionResult Index()
        {
            var builder = new IndexViewModelBuilder();
            var model = builder.GetIndexViewModel();
            _shoppingCart = new ShoppingCart(); //todo read from cache
            return View(model);
        }
    }
}
