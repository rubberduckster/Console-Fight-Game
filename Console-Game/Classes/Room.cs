using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Console_Game
{
    public class Room
    {
        public string Name;
        public string Description;
        public Room North, South, East, West;
        public List<Item> Items;
        public Room(string roomName, string roomDescription, List<Item> roomItems)
        {
            Name = roomName;
            Description = roomDescription;
        }
    }
}
