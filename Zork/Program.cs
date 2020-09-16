using System;

namespace Zork
{
    class Program
    {
        private static string CurrentRoom
        {
            get
            {
                return Rooms[Location.Row, Location.Column];
            }
            set
            {
                for (int row = 0; row < Rooms.GetLength(0); row++)
                {
                    for (int column = 0; column < Rooms.GetLength(1); column++)
                    {
                        if (Rooms[row, column] == value)
                        {
                            Location = (row, column);
                            return;
                        }
                    }
                }

                throw new Exception("Invalid room");
            }
        }

        static void Main(string[] args)
        {
            CurrentRoom = "West of House";
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
                        outputString = "This is an open field west of a white house, with a boarded front door.\nA rubber mat saying 'Welcome to Zork!' lies by the door.";
                        break;

                    case Commands.NORTH:
                    case Commands.SOUTH:
                    case Commands.EAST:
                    case Commands.WEST:
                        Directions direction = (Directions)command;
                        outputString = Move(direction) ? $"You moved {direction}" : $"The way is shut!";
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

        private static bool Move(Directions direction)
        {
            bool didMove;

            switch (direction)
            {
                case Directions.SOUTH when Location.Row > 0:
                    Location.Row--;
                    didMove = true;
                    break;
                case Directions.NORTH when Location.Row < Rooms.GetLength(0) - 1:
                    Location.Row++;
                    didMove = true;
                    break;
                case Directions.EAST when Location.Column < Rooms.GetLength(1) - 1:
                    Location.Column++;
                    didMove = true;
                    break;
                case Directions.WEST when Location.Column > 0:
                    Location.Column--;
                    didMove = true;
                    break;
                default:
                    didMove = false;
                    break;
            }

            return didMove;
        }

        private static readonly string[,] Rooms = {
            {"Rocky Trail", "South of House", "Canyon View" },
            {"Forest", "West of House", "Behind House" },
            {"Dense Woods", "North of House", "Clearing" }
        };

        private static (int Row, int Column) Location;
    }
}
