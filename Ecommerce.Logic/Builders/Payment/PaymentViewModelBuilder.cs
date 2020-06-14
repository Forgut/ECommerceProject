using ECommerce.Logic.Models.Payment;
using System;
using System.Collections.Generic;
using System.Text;

namespace ECommerce.Logic.Builders.Payment
{
    public class PaymentViewModelBuilder
    {
        private decimal _price;
        public PaymentViewModelBuilder(decimal price)
        {
            _price = price;
        }
        public PaymentViewModel GetPaymentViewModel()
        {
            Guid guid = Guid.NewGuid();
            return new PaymentViewModel()
            {
                Price = _price,
                TransactionName = string.Concat("Transaction-" + guid.ToString())
            };
        }
    }
}
