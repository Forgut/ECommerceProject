using ECommerce.Logic.Builders.Payment;
using ECommerce.Logic.Models.Payment;
using ECommerce.Logic.Objects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ECommerce.Website.Controllers
{
    public class PaymentController : Controller
    {
        public ActionResult Index(decimal price)
        {
            var builder = new PaymentViewModelBuilder(price);
            var model = builder.GetPaymentViewModel();
            return View(model);
        }
        public ActionResult Pay(PaymentViewModel model)
        {
            ShoppingCart.ClearCart();
            return RedirectToAction(nameof(this.ThankYouPage));
        }
        public ActionResult ThankYouPage()
        {
            return View();
        }
    }
}