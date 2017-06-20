using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Console_Store
{
    public class Sword : Item
    {
        public int Damage { get; set; }
        public Sword(string name, string description, decimal price, string type, int damage) : base(name, description, price, type)
        {
            Damage = damage;
        }
        public void Attack()
        {
            Console.WriteLine("Swing " + Name + " deal " + Damage + " damages.");
        }
    }
}
