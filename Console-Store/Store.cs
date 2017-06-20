using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Console_Store
{
    class Store
    {
        public List<Item> CartItems = new List<Item>();
        public List<Item> Items = new List<Item>();
        public string Name;
        public Store(string name)
        {
            Name = name;
        }
        public void AddItemToStore(Item item)
        {
            Items.Add(item);
        }
        public void RemoveItemFromStore(Item item)
        {
            Items.Remove(item);
        }
        public void AddItemToCart(Item item)
        {
            CartItems.Add(item);
        }
        public void RemoveItemFromCart(Item item)
        {
            CartItems.Remove(item);
        }
        public decimal CalculateCartTotal()
        {
            decimal total = 0;
            foreach (var item in CartItems)
            {
                total += item.Price;
            }
            return total;
        }
        public void ViewItems()
        {
            foreach (var item in Items)
            {
                Console.WriteLine(item.Name);
            }
        }
        public void ViewCart()
        {
            foreach (var item in CartItems)
            {
                Console.WriteLine(item.Name);
            }
        }
        public Item GetItemByName(List<Item> items, string name)
        {

            //return Items.Find(i => i.Name == name);

            foreach (var item in Items)
            {
                if(item.Name == name)
                {
                    return item;
                }
            }
            return null;
        }
    }
}
