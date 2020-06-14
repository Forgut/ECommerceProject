using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace ECommerce.Logic.Models.Payment
{
    public class PaymentViewModel
    {
        public string SellerID { get; set; }
        public string TransactionName { get; set; }
        public string TransactionKey { get; set; }
        public decimal Price { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        [StringLength(16, MinimumLength = 16)]
        public string AccountNumber { get; set; }
        [StringLength(3, MinimumLength = 3)]
        public string CCV { get; set; }
    }
}
