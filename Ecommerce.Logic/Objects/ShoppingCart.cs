using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Ecommerce.Logic.Objects
{
    public class ShoppingCart
    {
        public ShoppingCart(IEnumerable<Item> items)
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
