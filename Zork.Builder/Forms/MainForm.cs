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
            // Just for now 
            _ViewModel = new GameViewModel(new Game(new World(), null));
            gameViewModelBindingSource.DataSource = _ViewModel;
            //worldView.ViewModel = _ViewModel;
            //settingsView.ViewModel = _ViewModel;
        }

        private void NewToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //GameFileName = null;
            //CreateGame();
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
            }

        }

        private void SaveAsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                _ViewModel.FullPath = saveFileDialog.FileName;
                _ViewModel.Save();
            }
        }

        private void ExitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void CreateGame()
        {
            //GameFileName = null;
            //Game = new Game(new World(), null);
        }

        private void openGameToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                _ViewModel.Game = JsonConvert.DeserializeObject<Game>(File.ReadAllText(openFileDialog.FileName));
                _ViewModel.FullPath = openFileDialog.FileName;
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
    }
}