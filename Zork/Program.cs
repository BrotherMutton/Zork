using System;
using System.Collections.Generic;

namespace Zork
{
    class Program
    {
        private static Room CurrentRoom
        {
            get
            {
                return Rooms[Location.Row, Location.Column];
            }
        }

        static void Main(string[] args)
        {
            InitalizeRoomDescriptions();
            Console.WriteLine("Welcome to Zork!");

            Commands command = Commands.UNKNOWN;
            while (command != Commands.QUIT)
            {
                Console.Write($"{CurrentRoom}\n> ");
                command = ToCommand(Console.ReadLine().Trim());

                string outputString;
                switch (command)
                {
                    case Commands.QUIT:
                        outputString = "Thank you for playing!";
                        break;

                    case Commands.LOOK:
                        outputString = CurrentRoom.Description;
                        break;

                    case Commands.NORTH:
                    case Commands.SOUTH:
                    case Commands.EAST:
                    case Commands.WEST:
                        outputString = Move(command) ? $"You moved {command}" : $"The way is shut!";
                        break;

                    default:
                        outputString = "Unknown command.";
                        break;
                }

                Console.WriteLine(outputString);
            }
        }

        private static Commands ToCommand(string commandString)
        {
            if (Enum.TryParse<Commands>(commandString, ignoreCase: true, out Commands result))
            {
                return result;
            }
            else
            {
                return Commands.UNKNOWN;
            }
        }

        private static bool Move(Commands command)
        {
            Assert.IsTrue(IsDirection(command), "Invalid direction.");

            bool isValidMove = true;
            switch (command)
            {
                case Commands.NORTH when Location.Row < Rooms.GetLength(0) - 1:
                    Location.Row++;
                    break;

                case Commands.SOUTH when Location.Row > 0:
                    Location.Row--;
                    break;

                case Commands.EAST when Location.Column < Rooms.GetLength(1) - 1:
                    Location.Column++;
                    break;

                case Commands.WEST when Location.Column > 0:
                    Location.Column--;
                    break;

                default:
                    isValidMove = false;
                    break;
            }

            return isValidMove;
        }

        private static bool IsDirection(Commands command) => Directions.Contains(command);

        private static void InitalizeRoomDescriptions()
        {
            foreach (Room room in Rooms)
            {
                RoomsByName.Add(room.Name, room);
            }

            RoomsByName["Rocky Trail"].Description = "You are on a rock-strewn trail.";
            RoomsByName["South of House"].Description = "You are facing the side of a white house. This is no door here, and the windows are barred.";
            RoomsByName["Canyon View"].Description = "You are at the top of the Great Canyon on its' south wall.";
            RoomsByName["Forest"].Description = "This is a forest, with trees in all directions around you.";
            RoomsByName["West of House"].Description = "This is an open field west of a white house, with a boarded front door.";
            RoomsByName["Behind House"].Description = "You are behind the white house. In one corner of the house there is a small window which is slightly ajar.";
            RoomsByName["Dense Woods"].Description = "This is dimly lit forest with trees all around. To the east, there appears to be sunlight.";
            RoomsByName["North of House"].Description = "You are facing the north side of a white house. There is no door here, and all the windows are barred.";
            RoomsByName["Clearing"].Description = "You are in a clearing, with a forest surrounding you on the west and south.";
        }


        private static readonly Room[,] Rooms =
        {
            {new Room("Rocky Trail"),   new Room("South of House"),   new Room("Canyon View") },
            {new Room("Forest"),        new Room("West of House"),    new Room("Behind House") },
            {new Room("Dense Woods"),   new Room("North of House"),   new Room("Clearing") },
        };

        private static readonly List<Commands> Directions = new List<Commands>
        {
            Commands.NORTH,
            Commands.SOUTH,
            Commands.EAST,
            Commands.WEST
        };

        private static (int Row, int Column) Location = (1, 1);

        private static Dictionary<string, Room> RoomsByName = new Dictionary<string, Room>();
    }
}
