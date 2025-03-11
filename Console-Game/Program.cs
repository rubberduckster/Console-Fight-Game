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
            //Game intro
            Console.WriteLine("Welcome to - Ocean Slayer -");

            //Game player
            Player player = new Player();
            player.Name = "Fisherman Joe";

            //Beach room
            Weapon startWeapon = new Weapon("Wooden stick", 5, false);

            Room startingRoom = new Room("Beach", "You walk up on the beach, standing at the edge of the water, it washing over you feet.",);

            //Low waters room
            Monster Jellyfish = new Monster("Jellyfish", "You see a jellyfish being carried by the waves, floating uselessly. End it's miserable existence.");

            startingRoom.North = new Room("Low waters", "You're knee deep in the water now. You're blankly staring into your own reflection in the ocean waters.",);

            //Coral reef room
            Potion attackPotion = new Potion();

            Weapon Knife = new Weapon("Knife", 20, false);

            startingRoom.North.North = new Room("Coral reef", "You enter and meet a world of colors. There's corals as far as you can see.\nYou feel yourself soothed by the sight.",);

            //Seaweed forest room
            Monster Eel = new Monster("Eel", "Yikes! you see an eerie eel slithering towards you!");

            startingRoom.North.North.West = new Room("Seaweed forest", "You've entered a forest of seaweed.\n You feel it all closing in on you and the restrains of slowly getting entackled in it's ropes.\n You don't wanna stay too long.",);

            //Glowing algae cave room
            Potion healingPotion = new Potion();

            startingRoom.North.North.East = new Room("Glowing algae cave", "You dove towards a small creek of light. You were met with a big cave full of glowing algae. \nYou felt a sense of comfort in this place.",);

            //Starfish mountains
            startingRoom.North.North.North = new Room("Starfish mountains", "",);

            //Sunken ship room
            Weapon cannonBalls = new Weapon("Cannon balls", 50, true);

            startingRoom.North.North.North.West = new Room("Sunken ship", "",);

            //Red shark seas room
            Monster shark = new Monster("Shark", "");

            Weapon harpoon = new Weapon("Harpoon", 80, true);

            startingRoom.North.North.North.East = new Room("Red shark seas", "",);

            //Deep dark ocean room
            startingRoom.North.North.North.North = new Room("Deep dark ocean", "You swim deeper, as the light is fading you feel a sense of dread and emptiness. Is it a good idea to go on?",);

            //King crab lair entrance
            Monster guardianCrab = new Monster("Guardian crab", "");

            startingRoom.North.North.North.North.North = new Room("King crab gates", "",);

            //King crab lair
            startingRoom.North.North.North.North.North = new Room("King crab lair", "",);
        }
    }
}