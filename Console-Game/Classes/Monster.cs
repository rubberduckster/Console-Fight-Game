using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Console_Game
{
    public class Monster
    {
        public string Name;
        public string Intro;
        public string attackLine;
        public string damageTakenLine;
        public int Health;
        public bool Resistance;
        public int Damage;

        public Monster(string monsterName, string monsterIntro, string monsterAttackLine, string monsterDamageTakenLine, int monsterHealth, bool monsterResistance, int monsterDamage)
        {
            Name = monsterName;
            Intro = monsterIntro;
            attackLine = monsterAttackLine;
            damageTakenLine = monsterDamageTakenLine;
            Health = monsterHealth;
            Resistance = monsterResistance;
            Damage = monsterDamage;
        }
        //Take 0 dmg if resistance true
    }
}
