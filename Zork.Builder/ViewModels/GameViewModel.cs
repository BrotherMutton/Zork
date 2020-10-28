using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zork.Builder.ViewModels
{
    public class GameViewModel : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;

        public Game Game
        {
            get => _game;
            set
            {
                if (_game != value)
                {
                    _game = value;
                    if(_game != null)
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

        public string FullPath { get; set; }

        public GameViewModel(Game game = null)
        {
            Game = game;
        }

        private Game _game;
    }
}
