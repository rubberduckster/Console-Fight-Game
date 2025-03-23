using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Console_Game
{
    public class Monster
    {
        public int Id;
        public string Name;
        public string Intro;
        public string AttackLine;
        public string DamageTakenLine;
        public int Health;
        public bool Resistance;
        public int Damage;

        public Monster(int id, string name, string intro, string attackLine, string damageTakenLine, int health, bool resistance, int damage)
        {
            Id = id;
            Name = name;
            Intro = intro;
            AttackLine = attackLine;
            DamageTakenLine = damageTakenLine;
            Health = health;
            Resistance = resistance;
            Damage = damage;
        }
        //Take 0 dmg if resistance true
        public void TakeDamage(int damage)
        {
            Health -= damage;
        }
    }
}
