using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Console_Game
{
    public class Room
    {
        public int Id;
        public string Name;
        public string Description;
        public int North, South, East, West;
        public List<Item> Items;
        public Monster Monster { get; set; }
        public Room(int roomId, string roomName, string roomDescription, List<Item>? roomItems, Monster? roomMonster, int roomNorth, int roomSouth, int roomEast, int roomWest)
        {
            Id = roomId;
            Name = roomName;
            Description = roomDescription;
            Items = roomItems;
            North = roomNorth;
            South = roomSouth;
            East = roomEast;
            West = roomWest;
        }
    }
}
