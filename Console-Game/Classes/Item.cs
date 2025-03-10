using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Console_Game
{
    public class Item
    {
        public string name;

        public void Use()
        {

        }

    }

    public class Weapon : Item
    {
        public string type;
        public int damage;
        public bool isRanged;
        public int usesLeft;

        public void Hit()
        {
            
        }

    }
}
