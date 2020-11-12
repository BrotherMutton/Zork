using System;
using System.ComponentModel;
using System.Collections.Generic;
using System.Windows.Forms;
using Zork.Builder.ViewModels;

namespace Zork.Builder.UserControls
{
    public partial class NeighborView : UserControl
    {
        public static readonly Room NoNeighbor = new Room("<None>");

        public NeighborView()
        {
            InitializeComponent();
        }

        public GameViewModel ViewModel
        {
            get => _viewmodel;
            set
            {
                _viewmodel = value;
                neighborComboBox.SelectedIndexChanged -= NeighborComboBox_SelectedIndexChanged;
                if ( _viewmodel != null && _viewmodel.Rooms != null)
                {
                    neighborRoomsList = new List<Room>(_viewmodel.Rooms);
                    neighborRoomsList.Insert(0, NoNeighbor);
                    neighborComboBox.DataSource = neighborRoomsList;

                    RefreshSelection();
                }
                else
                {
                    neighborComboBox.DataSource = new BindingList<Room>(Array.Empty<Room>());
                }

                neighborComboBox.SelectedIndexChanged += NeighborComboBox_SelectedIndexChanged;
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

                neighborComboBox.DataSource = neighborRoomsList;

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
        
        private void NeighborComboBox_Enter(object sender, EventArgs e)
        {            
            if (neighborRoomsList.Contains(_SelectedRoom))
            {
                neighborRoomsList.Remove(_SelectedRoom);
            }
            neighborComboBox.DataSource = null;
            neighborComboBox.DataSource = neighborRoomsList;
        }

        private void NeighborComboBox_Leave(object sender, EventArgs e)
        {
            neighborRoomsList.Add(_SelectedRoom);
            neighborComboBox.DataSource = null;
            neighborComboBox.DataSource = neighborRoomsList;
        }

        public void RoomDeleted(Room room)
        {            
            foreach (Room NeighborRoom in neighborRoomsList)
            {
                _room = NeighborRoom;
                if (_room.Neighbors.TryGetValue(Direction, out Room neighbor))
                {
                    if (neighbor == room)
                    {
                        _room.RemoveNeighbor(Direction);                        
                    }
                    else
                    {
                        _room.AssignNeighbor(Direction, neighbor);
                    }
                }
                else
                {
                    neighborComboBox.SelectedItem = NoNeighbor;
                }
            }            
        }

        private void RefreshSelection()
        {
            if (neighborRoomsList != null)
            {
                foreach (var neighborRoomList in neighborRoomsList)
                {
                    Room selectedRoom = (Room)neighborComboBox.SelectedItem;
                }
            }

            if (_room != null)
            {
                if (neighborRoomsList != null)
                {
                    foreach (var neighborRoomList in neighborRoomsList)
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
            }
        }

        public Room _SelectedRoom;
        public List<Room> neighborRoomsList;
        private Directions _direction;
        private Room _room;
        private GameViewModel _viewmodel;
    }
}