using System;
using System.IO;
using Newtonsoft.Json;
using System.Windows.Forms;
using Newtonsoft.Json.Bson;

namespace Zork.Builder
{
    public partial class MainForm : Form
    {
        private Game Game { get; set; }

        private string GameFileName { get; set; }

        public MainForm()
        {
            InitializeComponent();
            UpdateTitle();
            CreateGame();
        }

        private void newToolStripMenuItem_Click(object sender, EventArgs e)
        {
            GameFileName = null;
            CreateGame();
        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
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

        private void saveAsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                GameFileName = saveFileDialog.FileName;
                UpdateTitle();
                SaveGame();
            }
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
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

        private void UpdateTitle()
        {
            string gameFileName = string.IsNullOrWhiteSpace(GameFileName) ? "Untitled" : Path.GetFileNameWithoutExtension(GameFileName);
            Text = $"Zork Builder - {gameFileName}";
        }

    }
}
