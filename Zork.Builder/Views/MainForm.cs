using System;
using System.IO;
using Newtonsoft.Json;
using System.Windows.Forms;
using Zork.Builder.ViewModels;

namespace Zork.Builder
{
    public partial class MainForm : Form
    {
        private Game Game { get; set; }

        private string GameFileName { get; set; }

        public MainForm()
        {
            InitializeComponent();
            CreateGame();

            _gameViewModel = new GameViewModel();
        }

        private void NewToolStripMenuItem_Click(object sender, EventArgs e)
        {
            GameFileName = null;
            CreateGame();
        }

        private void SaveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(GameFileName))
            {
                saveAsToolStripMenuItem.PerformClick();
            }
            else
            {
                SaveGame();
            }

        }

        private void SaveAsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                GameFileName = saveFileDialog.FileName;
                SaveGame();
            }
        }

        private void ExitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void CreateGame()
        {
            GameFileName = null;
            Game = new Game(new World(), null);
        }

        private void SaveGame()
        {
            JsonSerializer jsonSerializer = new JsonSerializer() { Formatting = Formatting.Indented };

            using (StreamWriter streamWriter = new StreamWriter(GameFileName))
            using (JsonWriter jsonWriter = new JsonTextWriter(streamWriter))
            {
                jsonSerializer.Serialize(jsonWriter, Game);
            }
        }

        private void openGameToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                _gameViewModel.Game = JsonConvert.DeserializeObject<Game>(File.ReadAllText(openFileDialog.FileName));
                _gameViewModel.FullPath = openFileDialog.FileName;
            }
        }

        private GameViewModel _gameViewModel;
    }
}
