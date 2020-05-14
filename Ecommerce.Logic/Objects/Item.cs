using System;
using System.Collections.Generic;
using System.Text;

namespace Ecommerce.Logic.Objects
{
    public class Item
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string PhotoName { get; set; }
        public decimal Price { get; set; }
    }
}
