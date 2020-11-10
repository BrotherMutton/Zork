using Newtonsoft.Json;
using System;
using System.ComponentModel;
using System.IO;

namespace Zork.Builder.ViewModels
{
    public class GameViewModel : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;

        public Game Game
        {
            set
            {
                if (_game != value)
                {
                    _game = value;
                    if (_game != null)
                    {
                        Rooms = new BindingList<Room>(_game.World.Rooms);
                    }
                    else
                    {
                        Rooms = new BindingList<Room>(Array.Empty<Room>());
                    }
                }
            }
        }

        public BindingList<Room> Rooms { get; set; }

        public string WelcomeMessage
        {
            get => _game.WelcomeMessage;
            set => _game.WelcomeMessage = value;
        }

        public string ExitMessage
        {
            get => _game.ExitMessage;
            set => _game.ExitMessage = value;
        }

        public string StartingLocation
        {
            get => _game.StartingLocation;
            set => _game.StartingLocation = value;
        }

        public string FullPath { get; set; }

        public GameViewModel(Game game = null)
        {
            Game = game;
        }

        public void Save()
        {
            JsonSerializer jsonSerializer = new JsonSerializer() { Formatting = Formatting.Indented };
            if (StartingLocation == null)
            {
                StartingLocation = Rooms[0].ToString();
            }
            using (StreamWriter streamWriter = new StreamWriter(FullPath))
            using (JsonWriter jsonWriter = new JsonTextWriter(streamWriter))
            {
                jsonSerializer.Serialize(jsonWriter, _game);
            }
        }

        private Game _game;
    }
}