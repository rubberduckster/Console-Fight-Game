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
        }
    }
}