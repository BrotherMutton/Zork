﻿namespace Zork.Builder
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
            this.runGameToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.saveFileDialog = new System.Windows.Forms.SaveFileDialog();
            this.tabControl = new System.Windows.Forms.TabControl();
            this.worldTabPage = new System.Windows.Forms.TabPage();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.IsModifiedtoolStripStatusLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.southNeighborView = new Zork.Builder.UserControls.NeighborView();
            this.eastNeighborView = new Zork.Builder.UserControls.NeighborView();
            this.westNeighborView = new Zork.Builder.UserControls.NeighborView();
            this.northNeighborView = new Zork.Builder.UserControls.NeighborView();
            this.descriptionTextBox = new System.Windows.Forms.TextBox();
            this.roomsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.gameViewModelBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.descriptionLabel = new System.Windows.Forms.Label();
            this.nameTextBox = new System.Windows.Forms.TextBox();
            this.nameLabel = new System.Windows.Forms.Label();
            this.removeRoomButton = new System.Windows.Forms.Button();
            this.addRoomButton = new System.Windows.Forms.Button();
            this.roomsListBox = new System.Windows.Forms.ListBox();
            this.labelRooms = new System.Windows.Forms.Label();
            this.settingsTabPage = new System.Windows.Forms.TabPage();
            this.StartingLocationLabel = new System.Windows.Forms.Label();
            this.startingLocationBox = new System.Windows.Forms.ComboBox();
            this.gameFilenameTextBox = new System.Windows.Forms.TextBox();
            this.gameFilenameLabel = new System.Windows.Forms.Label();
            this.exitMessageTextBox = new System.Windows.Forms.TextBox();
            this.exitMessageLabel = new System.Windows.Forms.Label();
            this.welcomeMessageTextBox = new System.Windows.Forms.TextBox();
            this.welcomeMessageLabel = new System.Windows.Forms.Label();
            this.menuStrip.SuspendLayout();
            this.tabControl.SuspendLayout();
            this.worldTabPage.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.roomsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gameViewModelBindingSource)).BeginInit();
            this.settingsTabPage.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip
            // 
            this.menuStrip.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.runToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.menuStrip.Location = new System.Drawing.Point(0, 0);
            this.menuStrip.Name = "menuStrip";
            this.menuStrip.Padding = new System.Windows.Forms.Padding(5, 2, 0, 2);
            this.menuStrip.Size = new System.Drawing.Size(1067, 28);
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
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(46, 24);
            this.fileToolStripMenuItem.Text = "&File";
            // 
            // newToolStripMenuItem
            // 
            this.newToolStripMenuItem.Name = "newToolStripMenuItem";
            this.newToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.N)));
            this.newToolStripMenuItem.Size = new System.Drawing.Size(285, 26);
            this.newToolStripMenuItem.Text = "&New Game";
            this.newToolStripMenuItem.Click += new System.EventHandler(this.NewToolStripMenuItem_Click);
            // 
            // openGameToolStripMenuItem
            // 
            this.openGameToolStripMenuItem.Name = "openGameToolStripMenuItem";
            this.openGameToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.O)));
            this.openGameToolStripMenuItem.Size = new System.Drawing.Size(285, 26);
            this.openGameToolStripMenuItem.Text = "&Open Game...";
            this.openGameToolStripMenuItem.Click += new System.EventHandler(this.OpenGameToolStripMenuItem_Click);
            // 
            // closeGameToolStripMenuItem
            // 
            this.closeGameToolStripMenuItem.Name = "closeGameToolStripMenuItem";
            this.closeGameToolStripMenuItem.Size = new System.Drawing.Size(285, 26);
            this.closeGameToolStripMenuItem.Text = "&Close Game";
            this.closeGameToolStripMenuItem.Click += new System.EventHandler(this.CloseGameToolStripMenuItem_Click);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(282, 6);
            // 
            // saveToolStripMenuItem
            // 
            this.saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            this.saveToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.S)));
            this.saveToolStripMenuItem.Size = new System.Drawing.Size(285, 26);
            this.saveToolStripMenuItem.Text = "&Save Game";
            this.saveToolStripMenuItem.Click += new System.EventHandler(this.SaveToolStripMenuItem_Click);
            // 
            // saveAsToolStripMenuItem
            // 
            this.saveAsToolStripMenuItem.Name = "saveAsToolStripMenuItem";
            this.saveAsToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)(((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Shift) 
            | System.Windows.Forms.Keys.S)));
            this.saveAsToolStripMenuItem.Size = new System.Drawing.Size(285, 26);
            this.saveAsToolStripMenuItem.Text = "Save Game As...";
            this.saveAsToolStripMenuItem.Click += new System.EventHandler(this.SaveAsToolStripMenuItem_Click);
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            this.toolStripMenuItem2.Size = new System.Drawing.Size(282, 6);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.F4)));
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(285, 26);
            this.exitToolStripMenuItem.Text = "&Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.ExitToolStripMenuItem_Click);
            // 
            // runToolStripMenuItem
            // 
            this.runToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.runGameToolStripMenuItem});
            this.runToolStripMenuItem.Name = "runToolStripMenuItem";
            this.runToolStripMenuItem.Size = new System.Drawing.Size(48, 24);
            this.runToolStripMenuItem.Text = "&Run";
            // 
            // runGameToolStripMenuItem
            // 
            this.runGameToolStripMenuItem.Name = "runGameToolStripMenuItem";
            this.runGameToolStripMenuItem.Size = new System.Drawing.Size(160, 26);
            this.runGameToolStripMenuItem.Text = "Run Game";
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(55, 24);
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
            // tabControl
            // 
            this.tabControl.Controls.Add(this.worldTabPage);
            this.tabControl.Controls.Add(this.settingsTabPage);
            this.tabControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl.Enabled = false;
            this.tabControl.Location = new System.Drawing.Point(0, 28);
            this.tabControl.Margin = new System.Windows.Forms.Padding(4);
            this.tabControl.Name = "tabControl";
            this.tabControl.SelectedIndex = 0;
            this.tabControl.Size = new System.Drawing.Size(1067, 576);
            this.tabControl.TabIndex = 1;
            // 
            // worldTabPage
            // 
            this.worldTabPage.Controls.Add(this.statusStrip1);
            this.worldTabPage.Controls.Add(this.groupBox1);
            this.worldTabPage.Controls.Add(this.removeRoomButton);
            this.worldTabPage.Controls.Add(this.addRoomButton);
            this.worldTabPage.Controls.Add(this.roomsListBox);
            this.worldTabPage.Controls.Add(this.labelRooms);
            this.worldTabPage.Location = new System.Drawing.Point(4, 25);
            this.worldTabPage.Margin = new System.Windows.Forms.Padding(4);
            this.worldTabPage.Name = "worldTabPage";
            this.worldTabPage.Padding = new System.Windows.Forms.Padding(4);
            this.worldTabPage.Size = new System.Drawing.Size(1059, 547);
            this.worldTabPage.TabIndex = 0;
            this.worldTabPage.Text = "World";
            this.worldTabPage.UseVisualStyleBackColor = true;
            // 
            // statusStrip1
            // 
            this.statusStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.IsModifiedtoolStripStatusLabel});
            this.statusStrip1.Location = new System.Drawing.Point(4, 517);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(1051, 26);
            this.statusStrip1.TabIndex = 11;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // IsModifiedtoolStripStatusLabel
            // 
            this.IsModifiedtoolStripStatusLabel.Name = "IsModifiedtoolStripStatusLabel";
            this.IsModifiedtoolStripStatusLabel.Size = new System.Drawing.Size(97, 20);
            this.IsModifiedtoolStripStatusLabel.Text = "Modified: No";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.southNeighborView);
            this.groupBox1.Controls.Add(this.eastNeighborView);
            this.groupBox1.Controls.Add(this.westNeighborView);
            this.groupBox1.Controls.Add(this.northNeighborView);
            this.groupBox1.Controls.Add(this.descriptionTextBox);
            this.groupBox1.Controls.Add(this.descriptionLabel);
            this.groupBox1.Controls.Add(this.nameTextBox);
            this.groupBox1.Controls.Add(this.nameLabel);
            this.groupBox1.Location = new System.Drawing.Point(232, 25);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox1.Size = new System.Drawing.Size(813, 488);
            this.groupBox1.TabIndex = 10;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Selected Room";
            // 
            // southNeighborView
            // 
            this.southNeighborView.Direction = Zork.Directions.SOUTH;
            this.southNeighborView.Location = new System.Drawing.Point(225, 396);
            this.southNeighborView.Margin = new System.Windows.Forms.Padding(5);
            this.southNeighborView.Name = "southNeighborView";
            this.southNeighborView.Room = null;
            this.southNeighborView.Size = new System.Drawing.Size(327, 85);
            this.southNeighborView.TabIndex = 15;
            this.southNeighborView.ViewModel = null;
            // 
            // eastNeighborView
            // 
            this.eastNeighborView.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.eastNeighborView.Direction = Zork.Directions.EAST;
            this.eastNeighborView.Location = new System.Drawing.Point(496, 301);
            this.eastNeighborView.Margin = new System.Windows.Forms.Padding(5);
            this.eastNeighborView.Name = "eastNeighborView";
            this.eastNeighborView.Room = null;
            this.eastNeighborView.Size = new System.Drawing.Size(308, 85);
            this.eastNeighborView.TabIndex = 14;
            this.eastNeighborView.ViewModel = null;
            // 
            // westNeighborView
            // 
            this.westNeighborView.Direction = Zork.Directions.WEST;
            this.westNeighborView.Location = new System.Drawing.Point(12, 304);
            this.westNeighborView.Margin = new System.Windows.Forms.Padding(5);
            this.westNeighborView.Name = "westNeighborView";
            this.westNeighborView.Room = null;
            this.westNeighborView.Size = new System.Drawing.Size(385, 85);
            this.westNeighborView.TabIndex = 13;
            this.westNeighborView.ViewModel = null;
            // 
            // northNeighborView
            // 
            this.northNeighborView.Direction = Zork.Directions.NORTH;
            this.northNeighborView.Location = new System.Drawing.Point(225, 215);
            this.northNeighborView.Margin = new System.Windows.Forms.Padding(5);
            this.northNeighborView.Name = "northNeighborView";
            this.northNeighborView.Room = null;
            this.northNeighborView.Size = new System.Drawing.Size(327, 82);
            this.northNeighborView.TabIndex = 12;
            this.northNeighborView.ViewModel = null;
            // 
            // descriptionTextBox
            // 
            this.descriptionTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.roomsBindingSource, "Description", true));
            this.descriptionTextBox.Location = new System.Drawing.Point(8, 98);
            this.descriptionTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.descriptionTextBox.Multiline = true;
            this.descriptionTextBox.Name = "descriptionTextBox";
            this.descriptionTextBox.Size = new System.Drawing.Size(592, 109);
            this.descriptionTextBox.TabIndex = 11;
            // 
            // roomsBindingSource
            // 
            this.roomsBindingSource.DataMember = "Rooms";
            this.roomsBindingSource.DataSource = this.gameViewModelBindingSource;
            // 
            // gameViewModelBindingSource
            // 
            this.gameViewModelBindingSource.DataSource = typeof(Zork.Builder.ViewModels.GameViewModel);
            // 
            // descriptionLabel
            // 
            this.descriptionLabel.AutoSize = true;
            this.descriptionLabel.Location = new System.Drawing.Point(8, 79);
            this.descriptionLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.descriptionLabel.Name = "descriptionLabel";
            this.descriptionLabel.Size = new System.Drawing.Size(83, 17);
            this.descriptionLabel.TabIndex = 10;
            this.descriptionLabel.Text = "&Description:";
            // 
            // nameTextBox
            // 
            this.nameTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.roomsBindingSource, "Name", true));
            this.nameTextBox.Location = new System.Drawing.Point(8, 44);
            this.nameTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.nameTextBox.Name = "nameTextBox";
            this.nameTextBox.Size = new System.Drawing.Size(429, 22);
            this.nameTextBox.TabIndex = 9;
            // 
            // nameLabel
            // 
            this.nameLabel.AutoSize = true;
            this.nameLabel.Location = new System.Drawing.Point(8, 25);
            this.nameLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.nameLabel.Name = "nameLabel";
            this.nameLabel.Size = new System.Drawing.Size(49, 17);
            this.nameLabel.TabIndex = 8;
            this.nameLabel.Text = "&Name:";
            // 
            // removeRoomButton
            // 
            this.removeRoomButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.removeRoomButton.Location = new System.Drawing.Point(124, 485);
            this.removeRoomButton.Margin = new System.Windows.Forms.Padding(4);
            this.removeRoomButton.Name = "removeRoomButton";
            this.removeRoomButton.Size = new System.Drawing.Size(100, 28);
            this.removeRoomButton.TabIndex = 7;
            this.removeRoomButton.Text = "&Remove";
            this.removeRoomButton.UseVisualStyleBackColor = true;
            this.removeRoomButton.Click += new System.EventHandler(this.RemoveRoomButton_Click);
            // 
            // addRoomButton
            // 
            this.addRoomButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.addRoomButton.Location = new System.Drawing.Point(16, 485);
            this.addRoomButton.Margin = new System.Windows.Forms.Padding(4);
            this.addRoomButton.Name = "addRoomButton";
            this.addRoomButton.Size = new System.Drawing.Size(100, 28);
            this.addRoomButton.TabIndex = 6;
            this.addRoomButton.Text = "&Add";
            this.addRoomButton.UseVisualStyleBackColor = true;
            this.addRoomButton.Click += new System.EventHandler(this.AddRoomButton_Click);
            // 
            // roomsListBox
            // 
            this.roomsListBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.roomsListBox.DataSource = this.roomsBindingSource;
            this.roomsListBox.DisplayMember = "Name";
            this.roomsListBox.FormattingEnabled = true;
            this.roomsListBox.ItemHeight = 16;
            this.roomsListBox.Location = new System.Drawing.Point(15, 25);
            this.roomsListBox.Margin = new System.Windows.Forms.Padding(4);
            this.roomsListBox.Name = "roomsListBox";
            this.roomsListBox.Size = new System.Drawing.Size(208, 436);
            this.roomsListBox.TabIndex = 5;
            this.roomsListBox.ValueMember = "Description";
            this.roomsListBox.SelectedIndexChanged += new System.EventHandler(this.RoomsListBox_SelectedIndexChanged);
            // 
            // labelRooms
            // 
            this.labelRooms.AutoSize = true;
            this.labelRooms.Location = new System.Drawing.Point(11, 4);
            this.labelRooms.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelRooms.Name = "labelRooms";
            this.labelRooms.Size = new System.Drawing.Size(56, 17);
            this.labelRooms.TabIndex = 4;
            this.labelRooms.Text = "Rooms:";
            // 
            // settingsTabPage
            // 
            this.settingsTabPage.Controls.Add(this.StartingLocationLabel);
            this.settingsTabPage.Controls.Add(this.startingLocationBox);
            this.settingsTabPage.Controls.Add(this.gameFilenameTextBox);
            this.settingsTabPage.Controls.Add(this.gameFilenameLabel);
            this.settingsTabPage.Controls.Add(this.exitMessageTextBox);
            this.settingsTabPage.Controls.Add(this.exitMessageLabel);
            this.settingsTabPage.Controls.Add(this.welcomeMessageTextBox);
            this.settingsTabPage.Controls.Add(this.welcomeMessageLabel);
            this.settingsTabPage.Location = new System.Drawing.Point(4, 25);
            this.settingsTabPage.Margin = new System.Windows.Forms.Padding(4);
            this.settingsTabPage.Name = "settingsTabPage";
            this.settingsTabPage.Padding = new System.Windows.Forms.Padding(4);
            this.settingsTabPage.Size = new System.Drawing.Size(1059, 545);
            this.settingsTabPage.TabIndex = 1;
            this.settingsTabPage.Text = "Settings";
            this.settingsTabPage.UseVisualStyleBackColor = true;
            // 
            // StartingLocationLabel
            // 
            this.StartingLocationLabel.AutoSize = true;
            this.StartingLocationLabel.Location = new System.Drawing.Point(12, 420);
            this.StartingLocationLabel.Name = "StartingLocationLabel";
            this.StartingLocationLabel.Size = new System.Drawing.Size(119, 17);
            this.StartingLocationLabel.TabIndex = 11;
            this.StartingLocationLabel.Text = "Starting Location:";
            // 
            // startingLocationBox
            // 
            this.startingLocationBox.DataSource = this.roomsBindingSource;
            this.startingLocationBox.DisplayMember = "Name";
            this.startingLocationBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.startingLocationBox.FormattingEnabled = true;
            this.startingLocationBox.Location = new System.Drawing.Point(11, 441);
            this.startingLocationBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.startingLocationBox.Name = "startingLocationBox";
            this.startingLocationBox.Size = new System.Drawing.Size(436, 24);
            this.startingLocationBox.TabIndex = 10;
            this.startingLocationBox.SelectionChangeCommitted += new System.EventHandler(this.StartingLocationBox_SelectionChangeCommitted);
            // 
            // gameFilenameTextBox
            // 
            this.gameFilenameTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.gameViewModelBindingSource, "FullPath", true));
            this.gameFilenameTextBox.Location = new System.Drawing.Point(16, 36);
            this.gameFilenameTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.gameFilenameTextBox.Name = "gameFilenameTextBox";
            this.gameFilenameTextBox.ReadOnly = true;
            this.gameFilenameTextBox.Size = new System.Drawing.Size(681, 22);
            this.gameFilenameTextBox.TabIndex = 9;
            // 
            // gameFilenameLabel
            // 
            this.gameFilenameLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gameFilenameLabel.AutoSize = true;
            this.gameFilenameLabel.Location = new System.Drawing.Point(12, 16);
            this.gameFilenameLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.gameFilenameLabel.Name = "gameFilenameLabel";
            this.gameFilenameLabel.Size = new System.Drawing.Size(111, 17);
            this.gameFilenameLabel.TabIndex = 8;
            this.gameFilenameLabel.Text = "Game Filename:";
            // 
            // exitMessageTextBox
            // 
            this.exitMessageTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.exitMessageTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.gameViewModelBindingSource, "ExitMessage", true));
            this.exitMessageTextBox.Location = new System.Drawing.Point(12, 241);
            this.exitMessageTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.exitMessageTextBox.Multiline = true;
            this.exitMessageTextBox.Name = "exitMessageTextBox";
            this.exitMessageTextBox.Size = new System.Drawing.Size(685, 162);
            this.exitMessageTextBox.TabIndex = 7;
            // 
            // exitMessageLabel
            // 
            this.exitMessageLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.exitMessageLabel.AutoSize = true;
            this.exitMessageLabel.Location = new System.Drawing.Point(12, 222);
            this.exitMessageLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.exitMessageLabel.Name = "exitMessageLabel";
            this.exitMessageLabel.Size = new System.Drawing.Size(95, 17);
            this.exitMessageLabel.TabIndex = 6;
            this.exitMessageLabel.Text = "Exit Message:";
            // 
            // welcomeMessageTextBox
            // 
            this.welcomeMessageTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.welcomeMessageTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.gameViewModelBindingSource, "WelcomeMessage", true));
            this.welcomeMessageTextBox.Location = new System.Drawing.Point(15, 90);
            this.welcomeMessageTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.welcomeMessageTextBox.Multiline = true;
            this.welcomeMessageTextBox.Name = "welcomeMessageTextBox";
            this.welcomeMessageTextBox.Size = new System.Drawing.Size(685, 127);
            this.welcomeMessageTextBox.TabIndex = 5;
            // 
            // welcomeMessageLabel
            // 
            this.welcomeMessageLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.welcomeMessageLabel.AutoSize = true;
            this.welcomeMessageLabel.Location = new System.Drawing.Point(11, 70);
            this.welcomeMessageLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.welcomeMessageLabel.Name = "welcomeMessageLabel";
            this.welcomeMessageLabel.Size = new System.Drawing.Size(131, 17);
            this.welcomeMessageLabel.TabIndex = 4;
            this.welcomeMessageLabel.Text = "Welcome Message:";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1067, 604);
            this.Controls.Add(this.tabControl);
            this.Controls.Add(this.menuStrip);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MainMenuStrip = this.menuStrip;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.Text = "Zork Builder";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainForm_FormClosing);
            this.menuStrip.ResumeLayout(false);
            this.menuStrip.PerformLayout();
            this.tabControl.ResumeLayout(false);
            this.worldTabPage.ResumeLayout(false);
            this.worldTabPage.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.roomsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gameViewModelBindingSource)).EndInit();
            this.settingsTabPage.ResumeLayout(false);
            this.settingsTabPage.PerformLayout();
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
        private System.Windows.Forms.TabControl tabControl;
        private System.Windows.Forms.TabPage worldTabPage;
        private System.Windows.Forms.TabPage settingsTabPage;
        private System.Windows.Forms.ToolStripMenuItem runToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.BindingSource gameViewModelBindingSource;
        private System.Windows.Forms.Button removeRoomButton;
        private System.Windows.Forms.Button addRoomButton;
        private System.Windows.Forms.ListBox roomsListBox;
        private System.Windows.Forms.Label labelRooms;
        private System.Windows.Forms.BindingSource roomsBindingSource;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox nameTextBox;
        private System.Windows.Forms.Label nameLabel;
        private System.Windows.Forms.TextBox descriptionTextBox;
        private System.Windows.Forms.Label descriptionLabel;
        private System.Windows.Forms.TextBox exitMessageTextBox;
        private System.Windows.Forms.Label exitMessageLabel;
        private System.Windows.Forms.TextBox welcomeMessageTextBox;
        private System.Windows.Forms.Label welcomeMessageLabel;
        private System.Windows.Forms.TextBox gameFilenameTextBox;
        private System.Windows.Forms.Label gameFilenameLabel;
        private System.Windows.Forms.ComboBox startingLocationBox;
        private System.Windows.Forms.Label StartingLocationLabel;
        private UserControls.NeighborView southNeighborView;
        private UserControls.NeighborView eastNeighborView;
        private UserControls.NeighborView westNeighborView;
        private UserControls.NeighborView northNeighborView;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel IsModifiedtoolStripStatusLabel;
        private System.Windows.Forms.ToolStripMenuItem runGameToolStripMenuItem;
    }
}

