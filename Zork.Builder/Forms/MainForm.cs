using System;
using System.IO;
using Newtonsoft.Json;
using System.Windows.Forms;
using Zork.Builder.ViewModels;
using Zork.Builder.Forms;
using Zork.Builder.UserControls;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Runtime.InteropServices;

namespace Zork.Builder
{
    public partial class MainForm : Form
    {
        public static string AssemblyTitle = Assembly.GetExecutingAssembly().GetCustomAttribute<AssemblyTitleAttribute>().Title;

        public MainForm()
        {
            InitializeComponent();

            gameViewModelBindingSource.DataSource = _ViewModel;

            _ViewModel.PropertyChanged += _ViewModel_PropertyChanged;

            _neighborViews.AddRange(new NeighborView[] {
                northNeighborView, southNeighborView, eastNeighborView, westNeighborView
            });

            InitalizeViewModels();
        }

        private void _ViewModel_PropertyChanged(object sender, System.ComponentModel.PropertyChangedEventArgs e)
        {
            string isModifiedLabel = _ViewModel.IsModified ? "Yes" : "No";
            IsModifiedtoolStripStatusLabel.Text = $"Modified: {isModifiedLabel}";
        }

        private void NewToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (_ViewModel.IsModified == true)
            {
                DialogResult result = MessageBox.Show("Save modified project?", AssemblyTitle, MessageBoxButtons.YesNoCancel);
                if (result == DialogResult.Yes)
                {
                    if (SaveGame() == DialogResult.Cancel)
                    {
                        return;
                    }
                }
                else if (result == DialogResult.Cancel)
                {
                    return;
                }
                else if (result == DialogResult.No)
                {
                    CreateGame();
                    Text = "Zork Builder - Untitled";
                    _ViewModel.IsModified = false;
                }
            }
            if (_ViewModel.IsModified == false)
            {
                CreateGame();
                Text = "Zork Builder - Untitled";
            }
        }

        private void SaveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(_ViewModel.FullPath))
            {
                saveAsToolStripMenuItem.PerformClick();
            }
            else
            {
                SaveGame();
                UpdateTitle();
            }
        }

        private void SaveAsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                SaveGame();
                UpdateTitle();
            }
        }

        private void ExitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (_ViewModel.IsModified == true)
            {
                DialogResult result = MessageBox.Show("Save modified project?", AssemblyTitle, MessageBoxButtons.YesNoCancel);
                if (result == DialogResult.Yes)
                {
                    if (SaveGame() == DialogResult.Cancel)
                    {
                        return;
                    }
                }
                else if (result == DialogResult.Cancel)
                {
                    return;
                }
                else if (result == DialogResult.No)
                {
                    Close();
                }
            }
            else if (_ViewModel.IsModified == false)
            {
                Close();
            }
        }

        private void OpenGameToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (_ViewModel.IsModified == false)
            {
                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    _ViewModel.Game = JsonConvert.DeserializeObject<Game>(File.ReadAllText(openFileDialog.FileName));
                    _ViewModel.FullPath = openFileDialog.FileName;
                    tabControl.Enabled = true;
                    UpdateTitle();

                    _startingLocationList = new List<Room>(_ViewModel.Rooms);
                    startingLocationBox.DataSource = _startingLocationList;
                    startingLocationBox.SelectedIndex = startingLocationBox.FindString(_ViewModel.StartingLocation);

                    InitalizeViewModels();
                }
            }
            else if (_ViewModel.IsModified == true)
            {
                DialogResult result = MessageBox.Show("Save modified project?", AssemblyTitle, MessageBoxButtons.YesNoCancel);
                if (result == DialogResult.Yes)
                {
                    if (SaveGame() == DialogResult.Cancel)
                    {
                        return;
                    }
                }
                else if (result == DialogResult.Cancel)
                {
                    return;
                }
                else if (result == DialogResult.No)
                {
                    if (openFileDialog.ShowDialog() == DialogResult.OK)
                    {
                        _ViewModel.Game = JsonConvert.DeserializeObject<Game>(File.ReadAllText(openFileDialog.FileName));
                        _ViewModel.FullPath = openFileDialog.FileName;
                        tabControl.Enabled = true;
                        UpdateTitle();

                        _startingLocationList = new List<Room>(_ViewModel.Rooms);
                        startingLocationBox.DataSource = _startingLocationList;
                        startingLocationBox.SelectedIndex = startingLocationBox.FindString(_ViewModel.StartingLocation);

                        InitalizeViewModels();

                        _ViewModel.IsModified = false;
                    }
                }
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

                        if (_ViewModel.StartingLocation == null)
                        {
                            _ViewModel.StartingLocation = addRoomForm.RoomName;
                            _startingLocationList = new List<Room>(_ViewModel.Rooms);
                            startingLocationBox.DataSource = _startingLocationList;
                            startingLocationBox.SelectedIndex = startingLocationBox.FindString(addRoomForm.RoomName);
                        }
                        else
                        {
                            _startingLocationList.Add(new Room(addRoomForm.RoomName));
                        }

                        startingLocationBox.DataSource = null;
                        startingLocationBox.DataSource = _startingLocationList;

                        InitalizeViewModels();
                    }
                    else
                    {
                        MessageBox.Show($"Room named \"{addRoomForm.RoomName}\" already exists.");
                    }
                }
            }
        }

        private void RemoveRoomButton_Click(object sender, EventArgs e)
        {
            if (_ViewModel.Rooms.Count == 1)
            {
                MessageBox.Show("Can't delete last room!");
            }
            else
            {
                if (MessageBox.Show("Delete this room?", AssemblyTitle, MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    RemoveRoomFromReferences((Room)roomsListBox.SelectedItem);

                    foreach (var neighborview in _neighborViews)
                    {
                        neighborview.RoomDeleted((Room)roomsListBox.SelectedItem);
                    }

                    _ViewModel.Rooms.Remove((Room)roomsListBox.SelectedItem);
                    InitalizeViewModels();
                    roomsListBox.SelectedItem = _ViewModel.Rooms.FirstOrDefault();
                }
            }
        }

        private void CloseGameToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (_ViewModel.IsModified == true)
            {
                DialogResult result = MessageBox.Show("Save modified project?", AssemblyTitle, MessageBoxButtons.YesNoCancel);
                if (result == DialogResult.Yes)
                {
                    if (SaveGame() == DialogResult.Cancel)
                    {
                        return;
                    }
                }
                else if (result == DialogResult.Cancel)
                {
                    return;
                }
                else if (result == DialogResult.No)
                {
                    CreateGame();
                    UpdateTitle();
                    tabControl.Enabled = false;
                    _ViewModel.IsModified = false;
                }
            }
            else if (_ViewModel.IsModified == false)
            {
                CreateGame();
                UpdateTitle();
                tabControl.Enabled = false;
            }
        }

        private void RoomsListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            foreach (var neighborView in _neighborViews)
            {
                neighborView.Room = (Room)roomsListBox.SelectedItem;
                neighborView._SelectedRoom = (Room)roomsListBox.SelectedItem;
            }
        }

        private void StartingLocationBox_SelectionChangeCommitted(object sender, EventArgs e)
        {
            _ViewModel.StartingLocation = startingLocationBox.SelectedItem.ToString();
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

        private void RemoveRoomFromReferences(Room room)
        {
            _startingLocationList.Remove(room);
            startingLocationBox.DataSource = null;
            startingLocationBox.DataSource = _startingLocationList;
            startingLocationBox.SelectedItem = _startingLocationList.FirstOrDefault();
            _ViewModel.StartingLocation = _startingLocationList.FirstOrDefault().ToString();
        }

        private DialogResult SaveGame()
        {
            if (string.IsNullOrEmpty(_ViewModel.FullPath))
            {
                var result = saveFileDialog.ShowDialog();

                if (result == DialogResult.OK)
                {
                    _ViewModel.FullPath = saveFileDialog.FileName;
                }
                else if (result == DialogResult.Cancel)
                {
                    return result;
                }
            }

            _ViewModel.Save();
            return DialogResult.OK;
        }

        private readonly List<NeighborView> _neighborViews = new List<NeighborView>();
        private List<Room> _startingLocationList;
        private GameViewModel _ViewModel = new GameViewModel(new Game(new World(), null));
        private bool exiting = false;

        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (_ViewModel.IsModified == true)
            {
                exiting = true;
                
                if (exiting == true)
                {
                    DialogResult result = MessageBox.Show("Save modified project?", AssemblyTitle, MessageBoxButtons.YesNo);
                    if (result == DialogResult.Yes)
                    {
                        if (SaveGame() == DialogResult.Cancel)
                        {
                            return;
                        }
                    }
                    else if (result == DialogResult.No)
                    {
                        Application.Exit();
                    }
                }
            }
        }
    }
}