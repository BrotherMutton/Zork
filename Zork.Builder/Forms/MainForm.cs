using System;
using System.IO;
using Newtonsoft.Json;
using System.Windows.Forms;
using Zork.Builder.ViewModels;
using Zork.Builder.Forms;
using Zork.Builder.UserControls;
using System.Collections.Generic;
using System.Linq;

namespace Zork.Builder
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
            _ViewModel = new GameViewModel(new Game(new World(), null));
            gameViewModelBindingSource.DataSource = _ViewModel;

            _neighborViews.AddRange(new NeighborView[] {
                northNeighborView, southNeighborView, eastNeighborView, westNeighborView
            });

            InitalizeViewModels();
        }

        private void NewToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CreateGame();
            Text = "Zork Builder - Untitled";
        }

        private void SaveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(_ViewModel.FullPath))
            {
                saveAsToolStripMenuItem.PerformClick();
            }
            else
            {
                _ViewModel.Save();
                UpdateTitle();
            }

        }

        private void SaveAsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                _ViewModel.FullPath = saveFileDialog.FileName;
                _ViewModel.Save();
                UpdateTitle();
            }
        }

        private void ExitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void OpenGameToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                _ViewModel.Game = JsonConvert.DeserializeObject<Game>(File.ReadAllText(openFileDialog.FileName));
                _ViewModel.FullPath = openFileDialog.FileName;
                tabControl.Enabled = true;
                UpdateTitle();

                InitalizeViewModels();
                
                _startingLocationList = new List<Room>(_ViewModel.Rooms);
                startingLocationBox.DataSource = _startingLocationList;
                startingLocationBox.SelectedIndex = startingLocationBox.FindString(_ViewModel.StartingLocation);                    
            }
        }

        private void AddRoomButton_Click(object sender, EventArgs e)
        {
            using (var addRoomForm = new AddRoomForm())
            {
                if (addRoomForm.ShowDialog() == DialogResult.OK)
                {
                    bool foundExistingRoom = false;
                    foreach (Room room in _ViewModel.Rooms)
                    {
                        if (room.Name.Equals(addRoomForm.RoomName, StringComparison.InvariantCultureIgnoreCase))
                        {
                            foundExistingRoom = true;
                        }
                    }

                    if (foundExistingRoom == false)
                    {
                        _ViewModel.Rooms.Add(new Room(addRoomForm.RoomName));
                        InitalizeViewModels();
                    }
                    else
                    {
                        MessageBox.Show($"Room named \"{addRoomForm.RoomName}\" already exists.");
                    }
                }
            }
        }       

        private void CloseGameToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CreateGame();
            UpdateTitle();
            tabControl.Enabled = false;
        }

        private void StartingLocationBox_SelectionChangeCommitted(object sender, EventArgs e)
        {
            _ViewModel.StartingLocation = startingLocationBox.SelectedItem.ToString();
        }

        private void RoomsListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            foreach (var neighborView in _neighborViews)
            {
                neighborView.Room = (Room)roomsListBox.SelectedItem;
                neighborView._SelectedRoom = (Room)roomsListBox.SelectedItem;
            }
        }

        private void CreateGame()
        {
            _ViewModel.FullPath = null;
            _ViewModel.Game = new Game(new World(), null);
            tabControl.Enabled = true;
            InitalizeViewModels();
        }

        private void InitalizeViewModels()
        {
            foreach (var neighborView in _neighborViews)
            {
                neighborView.ViewModel = _ViewModel;
            }
        }

        private void UpdateTitle()
        {
            if (string.IsNullOrWhiteSpace(_ViewModel.FullPath))
            {
                Text = "Zork Builder";
            }
            else
            {
                Text = $"Zork Builder - {Path.GetFileNameWithoutExtension(_ViewModel.FullPath)}";
            }
        }

        private readonly List<NeighborView> _neighborViews = new List<NeighborView>();

        private List<Room> _startingLocationList;

        private GameViewModel _ViewModel;
    }
}