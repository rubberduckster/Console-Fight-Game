using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Console_Game
{
    public class PlayerServices
    {
        public string TakeItem(Item item)
        {
            Player.Inventory.Add(item);
            return item.Name + " is now in your inventory";
        }

        public string EquipWeapon(Weapon weapon)
        {
            if (Player.EquippedWeapon != null)
            {
                Player.Inventory.Add(Player.EquippedWeapon);
            }

            Player.EquippedWeapon = weapon;

            return weapon.Name + " is now in your hands";
        }
    }
    //Picks up item and adds to inventory / View Inventory / Equip weapon / Use weapon / Use potion
}
