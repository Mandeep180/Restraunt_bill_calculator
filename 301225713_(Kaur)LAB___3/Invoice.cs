using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _301225713__Kaur_LAB___3
{
    internal class Invoice
    {
        private List<Item> Items;

        public Invoice()
        {
            Items = new List<Item>();
        }

        public double Total()
        {
            double total = 0;
            foreach (Item item in Items)
            {
                total += item.Price;
            }

            return Math.Round(total, 2);
        }

        public double Tax()
        {
            return Math.Round(this.Total() * 0.05, 2);
        }

        public void AddItem(Item item)
        {
            Items.Add(item);
        }

        public List<Item> getData()
        {
            return this.Items;
        }

        public void Clear()
        {
            this.Items = new List<Item>();
        }
    }
}
