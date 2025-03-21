﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Console_Game
{
    public class RoomServices
    {
        //List of rooms
        public List <Room> Rooms { get; set; }
        public  PlayerServices PlayerServices { get; set; }

        int currentRoom = 1;

        public RoomServices()
        {
            PlayerServices = new PlayerServices();

            Rooms = new List<Room>
            {
                new Room(1, "Beach", "You walk up on the beach, standing at the edge of the water. You feel the waves wash over you feet.",
                new List<Item>
                {
                    new Weapon(1, "Wooden stick", "", 5, false, 5)
                }, null,
                2, -1, -1, -1),
                
                new Room(2, "Low waters", "You're knee deep in the water now. You're blankly staring into your own reflection in the ocean waters.",
                new List<Item>
                {
                    
                }, new Monster(1, "Jellyfish", "You see a jellyfish being carried by the waves, floating uselessly. End it's miserable existence.", "It continues to sway to the rhythm of the waves", "There was no reaction but you got a hit on it.", 10, false, 0),
                3, 1, -1, -1),

                new Room(3, "Coral reef", "You enter and meet a world of colors. There's corals as far as you can see.\nYou feel yourself soothed by the sight.",
                new List<Item>
                {
                    new Potion(1, "1.5x ATK potion", "A potion that will boost your next [5] attacks by 1.5!"),
                    new Weapon(2, "Knife", "", 20, false, 5)
                }, null,
                6, 2, 4, 5),

                new Room(4, "Glowing algae cave", "You dove towards a small creek of light. You were met with a big cave full of glowing algae.\nYou felt a sense of comfort in this place.",
                new List<Item>
                {
                    new Potion(2, "50+ HP potion", "")
                }, null,
                7, -1, -1, 3),

                new Room(5, "Seaweed forest", "You've entered a forest of seaweed.\nYou feel it all closing in on you and the restrains of slowly getting entackled in it's ropes.\nYou don't wanna stay too long.",
                new List<Item>
                {

                }, new Monster(2, "Eel", "Yikes! you see an eerie eel slithering towards you!", "It sends an electrical impuls into the surrounding water and hurts you", "ouch", 50, false, 10),
                8, -1, 3, -1),

                new Room(6, "Starfish mountains", "You're towered by tall rocks all around you.\nThe rocks are spotted with starfish, covering it all over",
                new List<Item>
                {

                }, null,
                9, 3, 7, 8),

                new Room(7, "Red shark seas", "You swam forward and suddenly found yourself in a swarm of blood thirsty sharks! You gotta get a break through them.",
                new List<Item>
                {
                    new Weapon(3, "Harpoon", "", 80, true, 10)
                }, new Monster(3, "Shark", "", "", "", 200, true, 125),
                -1, 4, -1, 6),

                new Room(8, "Sunken ship", "A sunken ship lies before you. There's a gabbing hole where it was hit. It seems risky to cram yourself through but you must explore the depths.",
                new List<Item>
                {
                    new Weapon(4, "Cannon balls", "", 50, true, 3)
                }, null,
                -1, 5, 6, -1),

                new Room(9, "Deep dark ocean", "You swim deeper, as the light is fading you feel a sense of dread and emptiness. Is it a good idea to go on?",
                new List<Item>
                {

                }, null,
                10, 6, -1, -1),

                new Room(10, "King crab gates", "",
                new List<Item>
                {

                }, new Monster(4, "Guardian crab", "", "", "", 50, false, 50),
                11, 9, -1, -1),

                new Room(11, "King crab lair", "",
                new List<Item>
                {

                }, new Monster(5, "King crab", "", "", "", 200, false, 20),
                -1, 10, -1, -1),
            };
        }

        //Gets room by it's id
        public Room GetRoomById(int roomId)
        {
            return Rooms.Find(room => room.Id == roomId);
        }

        //Prints room and it's items
        public void GoToRoom(int roomId)
        {
            currentRoom = roomId;
            Room room = GetRoomById(roomId);

            Console.WriteLine("[{0}]\n", room.Name);
            Console.WriteLine(room.Description);

            int itemCount = 1;

            if (room.Items.Count > 0)
            {
                Console.Write("\nYou spot some things in the area:\n");
            }

            for (int i = 0; i < room.Items.Count; i++) 
            {
                Console.Write("{0}. {1}\n", itemCount++, room.Items[i].Name);
            }
        }

        //Gets items by id
        public List<Item>? GetItemsByRoomId(int roomId)
        {
            for (int i = 0; i < Rooms.Count; i++)
            {
                if (Rooms[i].Id == roomId)
                {
                    return Rooms[i].Items;

                }
            }

            return null;
        }

        //Find item by name
        public Item? FindItemByName(string itemName, int roomId)
        {
            Room? room = GetRoomById(roomId);

            foreach (Item item in room.Items)
            {
                if (item.Name == itemName)
                {
                    return item;
                }
            }
            return null;
        }

        //Remove item from room
        public void RemoveItemFromRoom(int roomId, Item item)
        {
            GetRoomById(roomId)?.Items.Remove(item);
        }

        //Pick up item //Add to player
        public void PickUpItem(string itemName, int roomId)
        {
            Item? itemToPickUp = FindItemByName(itemName, roomId);

            if (itemToPickUp != null)
            {
                PlayerServices.TakeItem(itemToPickUp);
                RemoveItemFromRoom(roomId, itemToPickUp);
            }
        }

        /*
        public Monster? GetMonsterByRoomId(string roomId)
        {

        }
        */
    }
}
