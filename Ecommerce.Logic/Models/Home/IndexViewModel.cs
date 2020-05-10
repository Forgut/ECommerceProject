using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ECommerce.Logic.Models.Home
{
    public class IndexViewModel
    {
        public IndexViewModel()
        {
            Items = new List<ItemViewModel>();
        }
        public IEnumerable<ItemViewModel> Items { get; set; }
    }
}