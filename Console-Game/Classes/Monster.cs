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
        public int Damage;

        public Monster(string monsterName, string monsterIntro)
        {
            Name = monsterName;
            Intro = monsterIntro;
        }
    }
}
