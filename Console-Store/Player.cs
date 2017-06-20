using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Console_Store
{
    class Player
    {
        string Name;
        int Health;
        Inventory Inventory; // You will need to add the inventory onto the player.
        Sword EquipedSword; // The sword that the player has equiped.
        Shield EquipedShield; // The Shield that the player has equiped.

        public void Attack()
        {
            if (EquipedSword != null)
            {
                EquipedSword.Attack();
            }
            else
            {
                Console.WriteLine("Player Has no Sword... Throws punch instead. Deal: 1 damage.");
            }
        }
        
        public int OnAttacked()
        {
            int Attack = 10;
            int blockedDamage = 0;
            if (EquipedShield != null)
            {
                blockedDamage = (int)EquipedShield.Block(10);
            }
            else
            {
                Console.WriteLine("Buy a shield");
            }
            return Attack - blockedDamage;
        }
        public void EquipSword()
        {
           var s = Inventory.Items.Find(i => i.Type == "sword");
            if(s is Sword)
            {
                EquipedSword = (Sword)s;
            }
        }   
        public void EquipShield()
        {
            var s = Inventory.Items.Find(i => i.Type == "shield");
            if(s is Shield)
            {
                EquipedShield = (Shield)s;
            }
        }

    }
}
