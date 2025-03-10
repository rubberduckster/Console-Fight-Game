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

            Room startingRoom = new Room("Beach","You walk up on the beach, standing at the edge of the water, it washing over you feet.\n Ready to take a step forward?");

            startingRoom.North = new Room("Coral Reef", "You enter and meet a world of colors. There's corals as far as you can see.\nYou feel yourself soothed by the sight.");
        }
    }
}