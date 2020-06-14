using ECommerce.Logic.Models.Payment;
using System;
using System.Collections.Generic;
using System.Text;

namespace ECommerce.Logic.Commanders
{
    public class PaymentCommander
    {
        private PaymentViewModel _paymentViewModel;
        public PaymentCommander(PaymentViewModel paymentViewModel)
        {
            _paymentViewModel = paymentViewModel;
        }
        public string GetPaymentUrl()
        {
            return string.Empty;
        }
    }
}
