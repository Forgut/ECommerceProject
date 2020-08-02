using ECommerce.Logic.Objects;
using NLog;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace ECommerce.Logic.DataSource
{
    public static class DataParser
    {
        private static IEnumerable<Item> _items;
        private static Logger _logger = LogManager.GetCurrentClassLogger();
       
        public static Item GetItemByID(int id)
        {
            var item = Items.FirstOrDefault(x => x.ID == id);
            return item;
        }

        public static IEnumerable<Item> Items
        {
            get
            {
                if (_items == null)
                    _items = GetItemsFromCSV();
                return _items;
            }
        }

        private static IEnumerable<Item> GetItemsFromCSV()
        {
            string textFile = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, @"..\ECommerce.Logic\DataSource\", "Items.txt"); //todo cleanup
            var items = new List<Item>();
            if (!File.Exists(textFile))
                throw new FileNotFoundException();
            else
                foreach (var line in File.ReadAllLines(textFile))
                {
                    var item = ParseLine(line);
                    if (item != null)
                        items.Add(item);
                }
            return items;
        }

        private static Item ParseLine(string line)
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
                _logger.Info("test");
                return null;
            }
        }
    }
}
