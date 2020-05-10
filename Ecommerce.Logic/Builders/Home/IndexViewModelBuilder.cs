using ECommerce.Logic.Models.Home;
using System;
using System.Collections.Generic;
using System.Text;

namespace Ecommerce.Logic.Builders.Home
{
    public class IndexViewModelBuilder
    {
        public IndexViewModel GetIndexViewModel()
        {
            return new IndexViewModel()
            {
                Items = new List<ItemViewModel>() { new ItemViewModel() { Name = "Awokado" }, new ItemViewModel() { Name = "Bolero" }, new ItemViewModel() { Name = "Cymbałki" } }
            };
        }
    }
}
