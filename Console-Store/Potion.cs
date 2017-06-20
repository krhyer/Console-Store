using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Console_Store
{
    class Potion : Item
    {
        public int Health { get; set; }
        public Potion(string name, string description, decimal price, int health) : base(name, description, price)
        {
            Health = health;
        }
        public void Heal()
        {
            Console.WriteLine("Drink " + Name + " heal " + Health + " HP.");
        }
    }
}
