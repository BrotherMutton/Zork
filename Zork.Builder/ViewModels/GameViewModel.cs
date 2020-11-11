using Newtonsoft.Json;
using System;
using System.ComponentModel;
using System.IO;

namespace Zork.Builder.ViewModels
{  
    public class GameViewModel : INotifyPropertyChanged
    {
#pragma warning disable CS0067       
        public event PropertyChangedEventHandler PropertyChanged;
#pragma warning restore CS0067
        public Game Game
        {
            set
            {
                if (_game != value)
                {
                    if (_game != null)
                    {
                        _game.PropertyChanged -= Game_PropertyChanged;
                        _game.World.PropertyChanged -= Game_PropertyChanged;
                        foreach (Room room in _game.World.Rooms)
                        {
                            room.PropertyChanged -= Game_PropertyChanged;
                        }
                    }

                    _game = value;

                    if (_game != null)
                    {
                        Rooms = new BindingList<Room>(_game.World.Rooms);
                        _game.PropertyChanged += Game_PropertyChanged;
                        _game.World.PropertyChanged += Game_PropertyChanged;
                        foreach (Room room in _game.World.Rooms)
                        {
                            room.PropertyChanged += Game_PropertyChanged;
                        }
                    }
                    else
                    {
                        Rooms = new BindingList<Room>(Array.Empty<Room>());
                    }
                }
            }
        }

        private void Game_PropertyChanged(object sender, PropertyChangedEventArgs e)
        {
            IsModified = true;
            PropertyChanged?.Invoke(this, e);
        }

        public BindingList<Room> Rooms { get; set; }

        public bool IsModified { get; set; }

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

            IsModified = false;
        }

        private Game _game;
    }
}