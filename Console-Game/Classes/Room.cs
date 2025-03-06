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
        public string Description;
        public Room North, South, East, West;
        public string[] items;
        public Room(string roomDescription)
        { 
            Description = roomDescription;
        }
    }
}
