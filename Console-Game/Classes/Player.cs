using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Console_Game
{
    public class Player
    {
        public string Name = "Fisherman Joe";
        public int Health = 300;
        public List<Item> Inventory = new List<Item>();
        public Weapon? EquippedWeapon = null;
    }
}
