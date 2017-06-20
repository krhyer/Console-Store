using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Console_Store
{
    public class Item
    {
        public string Name;
        public string Description;
        public decimal Price;
        public string Type;
        public Item(string name, string description, decimal price, string type)
        {
            Name = name;
            Description = description;
            Price = price;
            Type = type;
        }
    }
}
