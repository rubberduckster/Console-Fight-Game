using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Console_Game
{
    //Sea cave //Coral reef
    public class Room
    {
        public string description;
        public string north, south, east, west;
        public string[] items;
        public Room(string roomDescription)
        { 
            description = roomDescription;
        }
    }
}
