using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _301225713__Kaur_LAB___3
{
    internal class Item
    {
        public string Name { get; private set; }
        public string Category { get; private set; }
        public double Price { get; private set; }

        public Item(string name, string category, double price)
        {
            Name = name;
            Category = category;
            Price = price;
        }

    }
}
