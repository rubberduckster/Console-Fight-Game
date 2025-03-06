using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Console_Game;

namespace Program
{
    static class Program
    {
        public static void Main()
        {
            Console.WriteLine("Welcome to - Ocean Slayer -");

            Player player = new Player();
            player.Name = "Fisherman Joe";

            Room coralReef = new Room("You enter and meet a world of colors.\nThere's corals as far as you can see.\nYou feel yourself soothed by the sight.");
        }
    }
}