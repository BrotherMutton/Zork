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
            }
        }

        public string FullPath { get; set; }

        private Game _game;
    }
}
