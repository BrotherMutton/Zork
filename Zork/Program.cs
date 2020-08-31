using System;
using System.Numerics;

namespace Zork
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Zork!");

            string inputString = Console.ReadLine();
            Commands command = ToCommand(inputString.Trim().ToUpper());
            Console.WriteLine(command);
                     
        }


        private static Commands ToCommand(string inputString)
        {
            Commands command;

            if (inputString == "QUIT")
            {
                command = Commands.QUIT;
            }
            else if (inputString == "LOOK")
            {

                command = Commands.LOOK;
            }
            else if (inputString == "NORTH")
            {

                command = Commands.NORTH;
            }
            else if (inputString == "SOUTH")
            {

                command = Commands.SOUTH;
            }
            else if (inputString == "EAST")
            {

                command = Commands.EAST;
            }
            else if (inputString == "WEST")
            {

                command = Commands.WEST;
            }
            else
            {
                command = Commands.UNKNOWN;
            }

            return command;
        }

    }
}
