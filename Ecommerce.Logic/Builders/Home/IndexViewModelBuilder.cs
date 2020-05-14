using ECommerce.Logic.Models.Home;
using System;
using System.Collections.Generic;
using System.Text;

namespace ECommerce.Logic.Builders.Home
{
    public class IndexViewModelBuilder
    {
        public IndexViewModel GetIndexViewModel()
        {
            return new IndexViewModel()
            {
                Items = DataSource.DataParser.Items
            };
        }
    }
}
