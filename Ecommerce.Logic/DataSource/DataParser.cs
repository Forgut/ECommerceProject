using Ecommerce.Logic.Objects;
using NLog;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace Ecommerce.Logic.DataSource
{
    public class DataParser
    {
        private IEnumerable<Item> _items;
        private Logger _logger = LogManager.GetCurrentClassLogger();

        public IEnumerable<Item> Items
        {
            get
            {
                if (_items == null)
                    _items = GetItemsFromCSV();
                return _items;
            }
        }

        private IEnumerable<Item> GetItemsFromCSV()
        {
            string textFile = "Items.csv";
            var items = new List<Item>();
            if (File.Exists(textFile))
                foreach (var line in File.ReadAllLines(textFile))
                {
                    var item = ParseLine(line);
                    if (item != null)
                        items.Add(item);
                }
            return items;
        }

        private Item ParseLine(string line)
        {
            try
            {

                var values = line.Split(';');
                int.TryParse(values[0], out int id);
                string name = values[1];
                string description = values[2];
                decimal.TryParse(values[3], out decimal price);
                string photoPath = values[4];

                return new Item()
                {
                    ID = id,
                    Name = name,
                    Description = description,
                    PhotoName = photoPath,
                    Price = price
                };

            }
            catch (Exception e)
            {
                _logger.Error(e);
                return null;
            }
        }
    }
}
