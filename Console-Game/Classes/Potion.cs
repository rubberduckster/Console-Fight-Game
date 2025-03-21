using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Console_Game
{
    public class Potion : Item
    {
        public int damageBoost;
        public int healingBoost;
        public int UsesLeft;

        public Potion(int id, string name, string description) :base(id, name, description)
        {

        }
    }
}
