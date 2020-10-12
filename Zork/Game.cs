using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using Newtonsoft.Json;

namespace Zork
{
    public class Game
    {
        public World World { get; private set; }

        public string StartingLocation { get; set; }

        public string WelcomeMessage { get; set; }

        public string ExitMessage { get; set; }

        [JsonIgnore]
        public Player Player { get; private set; }

        [JsonIgnore]
        private bool IsRunning { get; set; }

        public Dictionary<string, Command> Commands { get; private set; }

        public Game(World world, Player player)
        {
            World = world;
            Player = player;

            Commands = new Dictionary<string, Command>()
            {
                { "QUIT",  new Command("QUIT",  new string[] { "QUIT", "Q", "BYE" }, Quit)},
                { "LOOK",  new Command("LOOK",  new string[] { "LOOK", "L" }, Look) },
                { "NORTH", new Command("NORTH", new string[] { "NORTH", "N"}, game => Move(game, Directions.NORTH) )},
                { "SOUTH", new Command("SOUTH", new string[] { "SOUTH", "S"}, game => Move(game, Directions.SOUTH) )},
                { "EAST",  new Command("EAST",  new string[] { "EAST", "E"},  game => Move(game, Directions.EAST) )},
                { "WEST",  new Command("WEST",  new string[] { "WEST", "W"},  game => Move(game, Directions.WEST) )},
            };
        }

        public void Run()
        {
            Console.WriteLine(string.IsNullOrWhiteSpace(WelcomeMessage) ? "Welcome to Zork!" : WelcomeMessage);

            IsRunning = true;
            Room previousroom = null;
            while (IsRunning)
            {
                Console.WriteLine(Player.Location);
                if (previousroom != Player.Location)
                {
                    Look(this);
                    previousroom = Player.Location;
                }

                Console.Write(">");
                string commandString = Console.ReadLine().Trim().ToUpper();
                Command foundCommand = null;
                foreach (Command command in Commands.Values)
                {
                    if (command.Verbs.Contains(commandString))
                    {
                        foundCommand = command;
                        break;
                    }
                }

                if (foundCommand != null)
                {
                    foundCommand?.Action(this);
                }
                else
                {
                    Console.WriteLine("Unknown command");
                }
            }
            Console.WriteLine(string.IsNullOrWhiteSpace(ExitMessage) ? "Welcome to Zork!" : ExitMessage);
        }

        private static void Look(Game game)
        {
            Console.WriteLine(game.Player.Location.Description);
        }

        private void Quit(Game game)
        {
            game.IsRunning = false;
        }

        private void Move(Game game, Directions direction)
        {
            if (game.Player.Move(direction) == false)
            {
                Console.WriteLine("The way is shut!");
            }
        }

        [OnDeserialized]
        private void OnDeserialized(StreamingContext context)
        {
            Player = new Player(World, StartingLocation);
        }
    }
}