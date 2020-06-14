using ECommerce.Logic.DataSource;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ECommerce.Logic.Objects
{
    public static class ShoppingCart
    {
        private static List<ShoppingCartItem> _items;
        public static List<ShoppingCartItem> Items
        {
            get
            {
                if (_items == null)
                    _items = new List<ShoppingCartItem>();
                return _items;
            }
        }
        public static void ClearCart()
        {
            _items = null;
        }
        public static void AddToCart(int id)
        {
            var itemInCart = Items.FirstOrDefault(x => x.ID == id);
            if (itemInCart != null)
            {
                itemInCart.Amount++;
            }
            else
            {
                var item = DataParser.GetItemByID(id);
                Items.Add(new ShoppingCartItem(item));
            }
        }
        public static void DeleteFromCart(int id)
        {
            var itemInCart = Items.FirstOrDefault(x => x.ID == id);
            if (itemInCart != null)
            {
                itemInCart.Amount--;
                if (itemInCart.Amount <= 0)
                    Items.Remove(itemInCart);
            }
        }
        public static bool HasItemInCart(int id)
        {
            return Items.Any(x => x.ID == id);
        }
        public static int HowManyInCart(int id)
        {
            int? amonut = Items.FirstOrDefault(x => x.ID == id)?.Amount;
            return amonut ?? 0;
        }
        public static decimal Price
        {
            get
            {
                return Items.Sum(x => x.Price * x.Amount);
            }
        }
    }
}
