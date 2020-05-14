using System;
using System.Collections.Generic;
using System.Text;

namespace ECommerce.Logic.Objects
{
    public class ShoppingCartItem
    {
        public ShoppingCartItem(Item item)
        {
            ID = item.ID;
            Name = item.Name;
            Price = item.Price;
            Amount = 0;
        }
        public int ID { get; set; }
        public string Name { get; set; }
        public decimal Price { get; set; }
        public int Amount { get; set; }
    }
}
