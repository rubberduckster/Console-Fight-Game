using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Console_Game
{
    public class Weapon : Item
    {
        public string AttackDescription;
        public int Damage;
        public bool IsRanged;
        public int UsesLeft;

        public Weapon(int id, string name, string description, int damage, bool isRanged, int usesLeft) : base(id, name, description)
        {
            Name = name;
            IsRanged = isRanged;
            Damage = damage;
            UsesLeft = usesLeft;
        }
    }
}
