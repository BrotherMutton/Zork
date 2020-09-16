﻿using System;
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
            //set
            //{
            //    for (int row = 0; row < Rooms.GetLength(0); row++)
            //    {
            //        for (int column = 0; column < Rooms.GetLength(1); column++)
            //        {
            //            if (Rooms[row, column] == value)
            //            {
            //                Location = (row, column);
            //                return;
            //            }
            //        }
            //    }

            //    throw new Exception("Invalid room");
            //}
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
                case Commands.SOUTH when Location.Row > 0:
                    Location.Row--;
                    break;

                case Commands.NORTH when Location.Row < Rooms.GetLength(0) - 1:
                    Location.Row++;
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
