using System;
using System.ComponentModel;
using System.Runtime.InteropServices;
using System.Windows.Forms;
using Zork.Builder.ViewModels;

namespace Zork.Builder.UserControls
{
    public partial class NeighborView : UserControl
    {
        public static readonly Room NoNeighbor = new Room("<None>");

        public GameViewModel ViewModel
        {
            get => _viewmodel;
            set
            {
                _viewmodel = value;
                if ( _viewmodel != null && _viewmodel.Rooms != null)
                {
                    neighborComboBox.DataSource = _viewmodel.Rooms;
                    // hacky but works
                    _viewmodel.Rooms.Add(NoNeighbor);
                }
                else
                {
                    neighborComboBox.DataSource = new BindingList<Room>(Array.Empty<Room>());
                }

                // Todo: Make sure the specified room property (i.e the room you are specifing a neighbor for) isnt in the list
                // Todo: adding NoNeighbor
                // todo: showing the default neighbor (when loading a room)
            }
        }

        public Directions Direction
        {
            get => _direction;
            set
            {
                _direction = value;
                directionTextBox.Text = _direction.ToString();
            }
        }

        public Room Room
        {
            get => _room;
            set
            {
                _room = value;
                
                if (_room?.Neighbors.TryGetValue(Direction, out Room room) == true)
                {
                    //todo: select the neighbor in the combo box
                    // ONLY WORKS AFTER YOU SELECT A DIFFERENT ROOM
                    // Checking to see the room, in the direction of this View, and getting its Name
                    _room.NeighborNames.TryGetValue(Direction, out string NeighborName);
                    // Setting the combo box to that Room
                    neighborComboBox.SelectedIndex = neighborComboBox.FindString(NeighborName);
                }
                else
                {
                    //todo: select none
                    neighborComboBox.SelectedItem = NoNeighbor;
                }
            }
        }

        public NeighborView()
        {
            InitializeComponent();
            Direction = _direction;
            neighborComboBox.DataSource = Array.Empty<Room>();
        }

        private Directions _direction;
        private Room _room;
        private GameViewModel _viewmodel;
    }
}
