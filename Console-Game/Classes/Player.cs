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
        public static List<Item> Inventory = new List<Item>();
        public static Weapon? EquippedWeapon = null;
    }
}
