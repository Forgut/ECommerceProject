using ECommerce.Logic.DataSource;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ECommerce.Website.Controllers
{
    public class ItemController : Controller
    {
        public ActionResult Index(int id)
        {
            var item = DataParser.GetItemByID(id);
            if (item == null)
                throw new KeyNotFoundException();
            return View(item);
        }
    }
}