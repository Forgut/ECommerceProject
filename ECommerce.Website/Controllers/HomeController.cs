using Ecommerce.Logic.Builders.Home;
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
        // GET: Home
        public ActionResult Index()
        {
            var builder = new IndexViewModelBuilder();
            var model = builder.GetIndexViewModel();
            return View(model);
        }
    }
}
