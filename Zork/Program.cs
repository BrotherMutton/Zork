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
            inputString = inputString.ToUpper();

            //bool result = string.Compare(inputString, "QUIT", true) == 0;
            if (inputString == "QUIT")
            {
                Console.WriteLine("Thank you for playing!");
            }
            else if (inputString == "LOOK")
            {
                Console.WriteLine("This is an open field west of a white house, with a boarded front door.\nA rubber mat reading \"Welcome to Zork\" lies by the door.");
            }
            else
            {
                Console.WriteLine("That's not a verb I recognize.");
            }
        }
    }
}
