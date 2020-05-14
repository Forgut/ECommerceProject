using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ECommerce.Logic.Objects
{
    public class ShoppingCart
    {
        public ShoppingCart(IEnumerable<Item> items = null)
        {
            Items = items;
        }
        public IEnumerable<Item> Items { get; set; }
        public decimal Price { 
            get
            {
                return Items.Sum(x => x.Price);
            }
        }
    }
}
