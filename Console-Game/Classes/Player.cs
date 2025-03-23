using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Console_Game
{
    public static class Player
    {
        public static string Name = "Fisherman Joe";
        public static int Health = 300;
        public static int BaseDamage = 1;
        public static List<Item> Inventory = new List<Item>();
        public static Weapon? EquippedWeapon = null;

        public static void AddItem(Item item)
        {
            Inventory.Add(item);
        }

        public static void TakeDamage(int damage)
        {
            Health -= damage;
        }

        public static Item? FindItemByName(string itemName)
        {
            itemName = itemName.ToLower();
            foreach (Item item in Inventory)
            {
                if(item.Name.ToLower() == itemName)
                {
                    return item;
                }
            }
            return null;
        }
    }
}
