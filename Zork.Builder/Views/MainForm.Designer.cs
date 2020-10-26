namespace Zork.Builder
{
    partial class MainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.menuStrip = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.newToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openGameToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.closeGameToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripSeparator();
            this.saveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveAsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripSeparator();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.runToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.saveFileDialog = new System.Windows.Forms.SaveFileDialog();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPageRooms = new System.Windows.Forms.TabPage();
            this.panelRoomInfo = new System.Windows.Forms.Panel();
            this.labelNeighbors = new System.Windows.Forms.Label();
            this.panelNeighbors = new System.Windows.Forms.Panel();
            this.textBoxRoomDescription = new System.Windows.Forms.TextBox();
            this.labelRoomDescription = new System.Windows.Forms.Label();
            this.textBoxRoomTitle = new System.Windows.Forms.TextBox();
            this.labelRoomTitle = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.labelStartingLocation = new System.Windows.Forms.Label();
            this.labelRooms = new System.Windows.Forms.Label();
            this.RemoveRoomButton = new System.Windows.Forms.Button();
            this.AddRoomButton = new System.Windows.Forms.Button();
            this.treeViewRooms = new System.Windows.Forms.TreeView();
            this.tabPageSettings = new System.Windows.Forms.TabPage();
            this.labelFilename = new System.Windows.Forms.Label();
            this.textBoxFilename = new System.Windows.Forms.TextBox();
            this.labelWorldName = new System.Windows.Forms.Label();
            this.textBoxWorldName = new System.Windows.Forms.TextBox();
            this.labelWelcomeMessage = new System.Windows.Forms.Label();
            this.textBoxWelcomeMessage = new System.Windows.Forms.TextBox();
            this.gameViewModelBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.menuStrip.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabPageRooms.SuspendLayout();
            this.panelRoomInfo.SuspendLayout();
            this.tabPageSettings.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gameViewModelBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip
            // 
            this.menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.runToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.menuStrip.Location = new System.Drawing.Point(0, 0);
            this.menuStrip.Name = "menuStrip";
            this.menuStrip.Size = new System.Drawing.Size(800, 24);
            this.menuStrip.TabIndex = 0;
            this.menuStrip.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newToolStripMenuItem,
            this.openGameToolStripMenuItem,
            this.closeGameToolStripMenuItem,
            this.toolStripMenuItem1,
            this.saveToolStripMenuItem,
            this.saveAsToolStripMenuItem,
            this.toolStripMenuItem2,
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "&File";
            // 
            // newToolStripMenuItem
            // 
            this.newToolStripMenuItem.Name = "newToolStripMenuItem";
            this.newToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.N)));
            this.newToolStripMenuItem.Size = new System.Drawing.Size(195, 22);
            this.newToolStripMenuItem.Text = "&New World";
            // 
            // openGameToolStripMenuItem
            // 
            this.openGameToolStripMenuItem.Name = "openGameToolStripMenuItem";
            this.openGameToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.O)));
            this.openGameToolStripMenuItem.Size = new System.Drawing.Size(195, 22);
            this.openGameToolStripMenuItem.Text = "&Open World...";
            this.openGameToolStripMenuItem.Click += new System.EventHandler(this.openGameToolStripMenuItem_Click);
            // 
            // closeGameToolStripMenuItem
            // 
            this.closeGameToolStripMenuItem.Name = "closeGameToolStripMenuItem";
            this.closeGameToolStripMenuItem.Size = new System.Drawing.Size(195, 22);
            this.closeGameToolStripMenuItem.Text = "&Close World";
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(192, 6);
            // 
            // saveToolStripMenuItem
            // 
            this.saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            this.saveToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.S)));
            this.saveToolStripMenuItem.Size = new System.Drawing.Size(195, 22);
            this.saveToolStripMenuItem.Text = "&Save World";
            this.saveToolStripMenuItem.Click += new System.EventHandler(this.SaveToolStripMenuItem_Click);
            // 
            // saveAsToolStripMenuItem
            // 
            this.saveAsToolStripMenuItem.Name = "saveAsToolStripMenuItem";
            this.saveAsToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)(((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Shift) 
            | System.Windows.Forms.Keys.S)));
            this.saveAsToolStripMenuItem.Size = new System.Drawing.Size(195, 22);
            this.saveAsToolStripMenuItem.Text = "Save As...";
            this.saveAsToolStripMenuItem.Click += new System.EventHandler(this.SaveAsToolStripMenuItem_Click);
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            this.toolStripMenuItem2.Size = new System.Drawing.Size(192, 6);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.F4)));
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(195, 22);
            this.exitToolStripMenuItem.Text = "&Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.ExitToolStripMenuItem_Click);
            // 
            // runToolStripMenuItem
            // 
            this.runToolStripMenuItem.Name = "runToolStripMenuItem";
            this.runToolStripMenuItem.Size = new System.Drawing.Size(40, 20);
            this.runToolStripMenuItem.Text = "&Run";
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.helpToolStripMenuItem.Text = "Help";
            // 
            // openFileDialog
            // 
            this.openFileDialog.FileName = "openFileDialog";
            this.openFileDialog.Filter = "JSON Files (*.json) | *.json";
            // 
            // saveFileDialog
            // 
            this.saveFileDialog.Filter = "JSON Files (*.json) | *.json";
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPageRooms);
            this.tabControl1.Controls.Add(this.tabPageSettings);
            this.tabControl1.Location = new System.Drawing.Point(0, 27);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(800, 421);
            this.tabControl1.TabIndex = 1;
            // 
            // tabPageRooms
            // 
            this.tabPageRooms.Controls.Add(this.panelRoomInfo);
            this.tabPageRooms.Controls.Add(this.comboBox1);
            this.tabPageRooms.Controls.Add(this.labelStartingLocation);
            this.tabPageRooms.Controls.Add(this.labelRooms);
            this.tabPageRooms.Controls.Add(this.RemoveRoomButton);
            this.tabPageRooms.Controls.Add(this.AddRoomButton);
            this.tabPageRooms.Controls.Add(this.treeViewRooms);
            this.tabPageRooms.Location = new System.Drawing.Point(4, 22);
            this.tabPageRooms.Name = "tabPageRooms";
            this.tabPageRooms.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageRooms.Size = new System.Drawing.Size(792, 395);
            this.tabPageRooms.TabIndex = 0;
            this.tabPageRooms.Text = "Rooms";
            this.tabPageRooms.UseVisualStyleBackColor = true;
            // 
            // panelRoomInfo
            // 
            this.panelRoomInfo.Controls.Add(this.labelNeighbors);
            this.panelRoomInfo.Controls.Add(this.panelNeighbors);
            this.panelRoomInfo.Controls.Add(this.textBoxRoomDescription);
            this.panelRoomInfo.Controls.Add(this.labelRoomDescription);
            this.panelRoomInfo.Controls.Add(this.textBoxRoomTitle);
            this.panelRoomInfo.Controls.Add(this.labelRoomTitle);
            this.panelRoomInfo.Location = new System.Drawing.Point(173, 18);
            this.panelRoomInfo.Name = "panelRoomInfo";
            this.panelRoomInfo.Size = new System.Drawing.Size(611, 371);
            this.panelRoomInfo.TabIndex = 6;
            // 
            // labelNeighbors
            // 
            this.labelNeighbors.AutoSize = true;
            this.labelNeighbors.Location = new System.Drawing.Point(4, 139);
            this.labelNeighbors.Name = "labelNeighbors";
            this.labelNeighbors.Size = new System.Drawing.Size(58, 13);
            this.labelNeighbors.TabIndex = 5;
            this.labelNeighbors.Text = "Neighbors:";
            // 
            // panelNeighbors
            // 
            this.panelNeighbors.BackColor = System.Drawing.Color.Transparent;
            this.panelNeighbors.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelNeighbors.Location = new System.Drawing.Point(7, 152);
            this.panelNeighbors.Name = "panelNeighbors";
            this.panelNeighbors.Size = new System.Drawing.Size(601, 216);
            this.panelNeighbors.TabIndex = 4;
            // 
            // textBoxRoomDescription
            // 
            this.textBoxRoomDescription.Location = new System.Drawing.Point(7, 56);
            this.textBoxRoomDescription.Multiline = true;
            this.textBoxRoomDescription.Name = "textBoxRoomDescription";
            this.textBoxRoomDescription.Size = new System.Drawing.Size(500, 80);
            this.textBoxRoomDescription.TabIndex = 3;
            // 
            // labelRoomDescription
            // 
            this.labelRoomDescription.AutoSize = true;
            this.labelRoomDescription.Location = new System.Drawing.Point(4, 40);
            this.labelRoomDescription.Name = "labelRoomDescription";
            this.labelRoomDescription.Size = new System.Drawing.Size(94, 13);
            this.labelRoomDescription.TabIndex = 2;
            this.labelRoomDescription.Text = "Room Description:";
            // 
            // textBoxRoomTitle
            // 
            this.textBoxRoomTitle.Location = new System.Drawing.Point(7, 16);
            this.textBoxRoomTitle.Name = "textBoxRoomTitle";
            this.textBoxRoomTitle.Size = new System.Drawing.Size(250, 20);
            this.textBoxRoomTitle.TabIndex = 1;
            // 
            // labelRoomTitle
            // 
            this.labelRoomTitle.AutoSize = true;
            this.labelRoomTitle.Location = new System.Drawing.Point(4, 4);
            this.labelRoomTitle.Name = "labelRoomTitle";
            this.labelRoomTitle.Size = new System.Drawing.Size(61, 13);
            this.labelRoomTitle.TabIndex = 0;
            this.labelRoomTitle.Text = "Room Title:";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(8, 18);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(159, 21);
            this.comboBox1.TabIndex = 5;
            // 
            // labelStartingLocation
            // 
            this.labelStartingLocation.AutoSize = true;
            this.labelStartingLocation.Location = new System.Drawing.Point(5, 3);
            this.labelStartingLocation.Name = "labelStartingLocation";
            this.labelStartingLocation.Size = new System.Drawing.Size(90, 13);
            this.labelStartingLocation.TabIndex = 4;
            this.labelStartingLocation.Text = "Starting Location:";
            // 
            // labelRooms
            // 
            this.labelRooms.AutoSize = true;
            this.labelRooms.Location = new System.Drawing.Point(8, 42);
            this.labelRooms.Name = "labelRooms";
            this.labelRooms.Size = new System.Drawing.Size(43, 13);
            this.labelRooms.TabIndex = 3;
            this.labelRooms.Text = "Rooms:";
            // 
            // RemoveRoomButton
            // 
            this.RemoveRoomButton.Location = new System.Drawing.Point(92, 366);
            this.RemoveRoomButton.Name = "RemoveRoomButton";
            this.RemoveRoomButton.Size = new System.Drawing.Size(75, 23);
            this.RemoveRoomButton.TabIndex = 2;
            this.RemoveRoomButton.Text = "Remove";
            this.RemoveRoomButton.UseVisualStyleBackColor = true;
            // 
            // AddRoomButton
            // 
            this.AddRoomButton.Location = new System.Drawing.Point(8, 366);
            this.AddRoomButton.Name = "AddRoomButton";
            this.AddRoomButton.Size = new System.Drawing.Size(75, 23);
            this.AddRoomButton.TabIndex = 1;
            this.AddRoomButton.Text = "Add";
            this.AddRoomButton.UseVisualStyleBackColor = true;
            // 
            // treeViewRooms
            // 
            this.treeViewRooms.Location = new System.Drawing.Point(8, 58);
            this.treeViewRooms.Name = "treeViewRooms";
            this.treeViewRooms.Size = new System.Drawing.Size(159, 304);
            this.treeViewRooms.TabIndex = 0;
            // 
            // tabPageSettings
            // 
            this.tabPageSettings.Controls.Add(this.textBoxWelcomeMessage);
            this.tabPageSettings.Controls.Add(this.labelWelcomeMessage);
            this.tabPageSettings.Controls.Add(this.textBoxWorldName);
            this.tabPageSettings.Controls.Add(this.labelWorldName);
            this.tabPageSettings.Controls.Add(this.textBoxFilename);
            this.tabPageSettings.Controls.Add(this.labelFilename);
            this.tabPageSettings.Location = new System.Drawing.Point(4, 22);
            this.tabPageSettings.Name = "tabPageSettings";
            this.tabPageSettings.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageSettings.Size = new System.Drawing.Size(792, 395);
            this.tabPageSettings.TabIndex = 1;
            this.tabPageSettings.Text = "Settings";
            this.tabPageSettings.UseVisualStyleBackColor = true;
            // 
            // labelFilename
            // 
            this.labelFilename.AutoSize = true;
            this.labelFilename.Location = new System.Drawing.Point(3, 3);
            this.labelFilename.Name = "labelFilename";
            this.labelFilename.Size = new System.Drawing.Size(52, 13);
            this.labelFilename.TabIndex = 0;
            this.labelFilename.Text = "Filename:";
            // 
            // textBoxFilename
            // 
            this.textBoxFilename.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.gameViewModelBindingSource, "FullPath", true));
            this.textBoxFilename.Location = new System.Drawing.Point(8, 19);
            this.textBoxFilename.Name = "textBoxFilename";
            this.textBoxFilename.ReadOnly = true;
            this.textBoxFilename.Size = new System.Drawing.Size(500, 20);
            this.textBoxFilename.TabIndex = 1;
            // 
            // labelWorldName
            // 
            this.labelWorldName.AutoSize = true;
            this.labelWorldName.Location = new System.Drawing.Point(5, 42);
            this.labelWorldName.Name = "labelWorldName";
            this.labelWorldName.Size = new System.Drawing.Size(69, 13);
            this.labelWorldName.TabIndex = 2;
            this.labelWorldName.Text = "World Name:";
            // 
            // textBoxWorldName
            // 
            this.textBoxWorldName.Location = new System.Drawing.Point(8, 58);
            this.textBoxWorldName.Name = "textBoxWorldName";
            this.textBoxWorldName.Size = new System.Drawing.Size(500, 20);
            this.textBoxWorldName.TabIndex = 3;
            // 
            // labelWelcomeMessage
            // 
            this.labelWelcomeMessage.AutoSize = true;
            this.labelWelcomeMessage.Location = new System.Drawing.Point(3, 81);
            this.labelWelcomeMessage.Name = "labelWelcomeMessage";
            this.labelWelcomeMessage.Size = new System.Drawing.Size(101, 13);
            this.labelWelcomeMessage.TabIndex = 4;
            this.labelWelcomeMessage.Text = "Welcome Message:";
            // 
            // textBoxWelcomeMessage
            // 
            this.textBoxWelcomeMessage.Location = new System.Drawing.Point(8, 97);
            this.textBoxWelcomeMessage.Name = "textBoxWelcomeMessage";
            this.textBoxWelcomeMessage.Size = new System.Drawing.Size(500, 20);
            this.textBoxWelcomeMessage.TabIndex = 5;
            // 
            // gameViewModelBindingSource
            // 
            this.gameViewModelBindingSource.DataSource = typeof(Zork.Builder.ViewModels.GameViewModel);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.menuStrip);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MainMenuStrip = this.menuStrip;
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.Text = "Zork Builder";
            this.menuStrip.ResumeLayout(false);
            this.menuStrip.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            this.tabPageRooms.ResumeLayout(false);
            this.tabPageRooms.PerformLayout();
            this.panelRoomInfo.ResumeLayout(false);
            this.panelRoomInfo.PerformLayout();
            this.tabPageSettings.ResumeLayout(false);
            this.tabPageSettings.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gameViewModelBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem newToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openGameToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem closeGameToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem saveToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveAsToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.OpenFileDialog openFileDialog;
        private System.Windows.Forms.SaveFileDialog saveFileDialog;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPageRooms;
        private System.Windows.Forms.TabPage tabPageSettings;
        private System.Windows.Forms.ToolStripMenuItem runToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label labelStartingLocation;
        private System.Windows.Forms.Label labelRooms;
        private System.Windows.Forms.Button RemoveRoomButton;
        private System.Windows.Forms.Button AddRoomButton;
        private System.Windows.Forms.TreeView treeViewRooms;
        private System.Windows.Forms.Panel panelRoomInfo;
        private System.Windows.Forms.TextBox textBoxRoomTitle;
        private System.Windows.Forms.Label labelRoomTitle;
        private System.Windows.Forms.Label labelRoomDescription;
        private System.Windows.Forms.TextBox textBoxRoomDescription;
        private System.Windows.Forms.Panel panelNeighbors;
        private System.Windows.Forms.Label labelNeighbors;
        private System.Windows.Forms.TextBox textBoxFilename;
        private System.Windows.Forms.Label labelFilename;
        private System.Windows.Forms.TextBox textBoxWelcomeMessage;
        private System.Windows.Forms.Label labelWelcomeMessage;
        private System.Windows.Forms.TextBox textBoxWorldName;
        private System.Windows.Forms.Label labelWorldName;
        private System.Windows.Forms.BindingSource gameViewModelBindingSource;
    }
}

