using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Versioning;
using Console_Game;

namespace Program
{
    static class Program
    {
        public static void Main()
        {
            //Stores and sets console window size
            int consoleWidth, width;
            int consoleHeight, heigth;

            consoleWidth = Console.WindowWidth;
            consoleHeight = Console.WindowHeight;

            width = consoleWidth / 2;
            heigth = consoleHeight / 2;

            Console.SetWindowSize(consoleWidth, consoleHeight);

            //Game intro
            string welcomeTitle = "Welcome to -Ocean Slayer -\n";

            Console.SetCursorPosition(width - welcomeTitle.Length / 2, 0);
            Console.WriteLine(welcomeTitle);


            //Sets up rooms based on room id
            RoomServices roomService = new RoomServices();

            int currentRoomId = 1;

            //Prints starting room
            roomService.GoToRoom(currentRoomId);

            while (true) {
                Room? currentRoom = roomService.GetRoomById(currentRoomId);

                //Attack before option to walk on or pickup items comes on
                List<Item> currentRoomItems = roomService.GetItemsByRoomId(currentRoom.Id);

                Console.Write("\nWhere do you want to go next? You can go:\n");

                //Printing room direction options
                if (currentRoom.North != -1) 
                {
                    Console.WriteLine("North [N]");
                }
                if (currentRoom.South != -1)
                {
                    Console.WriteLine("South [S]");
                }
                if (currentRoom.East != -1)
                {
                    Console.WriteLine("East [E]");
                }
                if (currentRoom.West != -1)
                {
                    Console.WriteLine("West [W]");
                }

                //Taking user input and allowing to move between rooms
                Console.WriteLine("");
                string playerInput = Console.ReadLine();

                if (playerInput == "N" && currentRoom.North != -1)
                {
                    Console.Clear();
                    currentRoomId = currentRoom.North;
                    roomService.GoToRoom(currentRoomId);
                }

                else if (playerInput == "S" && currentRoom.South != -1)
                {
                    Console.Clear();
                    currentRoomId = currentRoom.South;
                    roomService.GoToRoom(currentRoomId);
                }

                else if (playerInput == "E" && currentRoom.East != -1)
                {
                    Console.Clear();
                    currentRoomId = currentRoom.East;
                    roomService.GoToRoom(currentRoomId);
                }

                else if (playerInput == "W" && currentRoom.West != -1)
                {
                    Console.Clear();
                    currentRoomId = currentRoom.West;
                    roomService.GoToRoom(currentRoomId);
                }
            }
        }
    }
}