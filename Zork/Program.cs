using System;
using System.Collections.Generic;
using System.IO;
using Newtonsoft.Json;

namespace Zork
{
    class Program
    {
        static void Main(string[] args)
        {
            const string defaultGameFileName = "Zork.json";
            string gameFileName = args.Length > 0 ? args[(int)CommandLineArguments.RoomsFilename] : defaultGameFileName;

            Console.WriteLine("Welcome to Zork!");

            Game game = JsonConvert.DeserializeObject<Game>(File.ReadAllText(gameFileName));
            game.Run();
        }

        private enum CommandLineArguments
        {
            RoomsFilename = 0,
        }
    }
}
