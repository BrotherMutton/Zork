using System;
using System.IO;
using Newtonsoft.Json;
using System.Windows.Forms;
using Zork.Builder.ViewModels;
using Zork.Builder.Forms;

namespace Zork.Builder
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
            _ViewModel = new GameViewModel(new Game(new World(), null));
            gameViewModelBindingSource.DataSource = _ViewModel;
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

        private void CreateGame()
        {
            _ViewModel.FullPath = null;
            _ViewModel.Game = new Game(new World(), null);
            tabControl.Enabled = true;
        }

        private void OpenGameToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                _ViewModel.Game = JsonConvert.DeserializeObject<Game>(File.ReadAllText(openFileDialog.FileName));
                _ViewModel.FullPath = openFileDialog.FileName;
                tabControl.Enabled = true;
                UpdateTitle();

                startingLocationBox.SelectedIndex = startingLocationBox.FindString(_ViewModel.StartingLocation.ToString());
            }
        }
        private void AddRoomButton_Click(object sender, EventArgs e)
        {
            using (var addRoomForm = new AddRoomForm())
            {
                if (addRoomForm.ShowDialog() == DialogResult.OK)
                {
                    _ViewModel.Rooms.Add(new Room(addRoomForm.RoomName));
                }
            }
        }

        private GameViewModel _ViewModel;

        private void CloseGameToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CreateGame();
            UpdateTitle();
            tabControl.Enabled = false;
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

        private void startingLocationBox_SelectionChangeCommitted(object sender, EventArgs e)
        {
            _ViewModel.StartingLocation = startingLocationBox.SelectedItem.ToString();
        }
    }
}