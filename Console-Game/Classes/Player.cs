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
        public static List<Item> StatusEffects = new List<Item>();
        public static Potion? PotionEffects = null;
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

        //Unequip weapon and remove from inventory - Weapon durability
        public static void RemoveWeaponFromPlayer(Weapon weapon)
        {
            if (weapon.UsesLeft <= 0)
            {
                Inventory.Remove(weapon);
                EquippedWeapon = null;
                Console.WriteLine("Your weapon broke");
            }
        }

        //Move potion from inventory to status list when there's 0 uses left
        public static void InventoryToEffectsList(Potion potion)
        {
                StatusEffects.Add(potion);
                Inventory.Remove(potion);
        }

        //Remove potion from status list when effect runs out
        public static void RemovePotionFromEffectsList(Potion potion)
        {
            if (potion.StatusEffect <= 0)
            {
                StatusEffects.Remove(potion);
            }
        }

        public static void RemovePotionFromInventory(Potion potion)
        {
            Inventory.Remove(potion);
        }
    }
}
