using System;
using System.ComponentModel;
using System.Collections.Generic;
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
                neighborComboBox.SelectedIndexChanged -= NeighborComboBox_SelectedIndexChanged;
                if ( _viewmodel != null && _viewmodel.Rooms != null)
                {
                    var rooms = new List<Room>(_viewmodel.Rooms);
                    rooms.Insert(0, NoNeighbor);
                    
                    neighborComboBox.DataSource = rooms;                    
                }
                else
                {
                    neighborComboBox.DataSource = new BindingList<Room>(Array.Empty<Room>());
                }

                neighborComboBox.SelectedIndexChanged += NeighborComboBox_SelectedIndexChanged;

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
                if (_room != null && _room.Neighbors.TryGetValue(Direction, out Room neighbor))
                {
                    neighborComboBox.SelectedItem = neighbor;
                }
                else
                {
                    neighborComboBox.SelectedItem = NoNeighbor;
                }
            }
        }

        public NeighborView()
        {
            InitializeComponent();                        
        }

        private void NeighborComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (_room != null)
            {
                Room selectedRoom = (Room)neighborComboBox.SelectedItem;
                if (selectedRoom != null)
                {
                    if (selectedRoom == NoNeighbor)
                    {
                        _room.RemoveNeighbor(Direction);
                    }
                    else
                    {
                        _room.AssignNeighbor(Direction, selectedRoom);
                    }
                }
            }
        }

        private Directions _direction;
        private Room _room;
        private GameViewModel _viewmodel;
    }
}