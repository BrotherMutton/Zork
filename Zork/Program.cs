using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Numerics;

namespace Zork
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Zork!");

            Commands command = Commands.UNKNOWN;
            while (command != Commands.QUIT)
            {

                Console.WriteLine(Rooms[Location.Row,Location.Column]);
                Console.Write("> ");
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
            bool didMove = false;

            if (command == Commands.EAST && Location.Column < Rooms.GetLength(1) - 1)
            {
                Location.Column++;
                didMove = true;
            }
            else if (command == Commands.WEST && Location.Column > 0)
            {
                Location.Column--;
                didMove = true;
            }
            else if (command == Commands.SOUTH && Location.Row < Rooms.GetLength(0) - 1)
            {
                Location.Row++;
                didMove = true;
            }
            else if (command == Commands.NORTH && Location.Row > 0)
            {
                Location.Row--;
                didMove = true;
            }

            return didMove;

        }

        // this is bascially correct but im gonna wait for lecture to upload 2.2

        private static readonly string[,] Rooms = {
            {"Rocky Trail", "South of House", "Canyon View" },
            {"Forest", "West of House", "Behind House" },
            {"Dense Woods", "North of House", "Clearing" }
        };

        private static (int Row, int Column) Location = (1,1);
    }
}
