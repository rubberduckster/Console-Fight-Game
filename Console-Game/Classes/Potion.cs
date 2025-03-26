using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Console_Game
{
    public class Potion : Item
    {
        public string Type;
        public int DamageBoost;
        public int HealingBoost;
        public int StatusEffect;

        public Potion(int id, string name, string description, string type, int damageBoost, int healingBoost, int statusEffect) :base(id, name, description)
        {
            Name = name;
            Description = description;
            Type = type;
            DamageBoost = damageBoost;
            HealingBoost = healingBoost;
            StatusEffect = statusEffect;
        }
    }
}
