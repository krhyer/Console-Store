using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Console_Store
{
    public class Shield : Item
    {
        public float DamageModifier { get; set; }
        public Shield(string name, string description, decimal price, string type, float damageModifier) : base(name, description, price, type)
        {
            DamageModifier = damageModifier;
        }


        public float Block(float baseDamage)
        {
            var blockedDamage = baseDamage*DamageModifier;

            Console.WriteLine("Used " + Name + " To block " + blockedDamage + " damage.");
            return baseDamage - blockedDamage;
        }
    }

}
