using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Console_Store
{
    class Inventory
    {
        public List<Item> Items = new List<Item>();
        public void AddItemToInventory(Item item)
        {
            Items.Add(item);
        }
        public void RemoveItemFromInventory(Item item)
        {
            Items.Remove(item);
        }
    }
}
