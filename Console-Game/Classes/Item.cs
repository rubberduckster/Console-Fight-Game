using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Console_Game
{
    public class Item
    {
        public string Name;

        public void Use()
        {

        }

    }

    public class Weapon : Item
    {
        public string AttackDescription;
        public int Damage;
        public bool IsRanged;
        public int UsesLeft;

        public Weapon(string weaponName, int weaponDamage, bool weaponIsRanged)
        {
            Name = weaponName;
            IsRanged = weaponIsRanged;
            Damage = weaponDamage;
        }

        public void Hit()
        {
            UsesLeft--;


            if (IsRanged = false)
            {
                Damage = Damage * 2;
            }
        }

    }

    public class Potion : Item
    {
        public string type;
        public int damageBoost;
        public int healingBoost;
        public int UsesLeft;
    }
}
