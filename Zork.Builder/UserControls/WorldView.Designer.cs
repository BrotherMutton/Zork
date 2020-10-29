namespace Zork.Builder
{
    partial class WorldView
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.labelRooms = new System.Windows.Forms.Label();
            this.roomsListBox = new System.Windows.Forms.ListBox();
            this.addRoomButton = new System.Windows.Forms.Button();
            this.removeRoomButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // labelRooms
            // 
            this.labelRooms.AutoSize = true;
            this.labelRooms.Location = new System.Drawing.Point(14, 11);
            this.labelRooms.Name = "labelRooms";
            this.labelRooms.Size = new System.Drawing.Size(43, 13);
            this.labelRooms.TabIndex = 0;
            this.labelRooms.Text = "Rooms:";
            // 
            // roomsListBox
            // 
            this.roomsListBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.roomsListBox.FormattingEnabled = true;
            this.roomsListBox.Location = new System.Drawing.Point(17, 28);
            this.roomsListBox.Name = "roomsListBox";
            this.roomsListBox.Size = new System.Drawing.Size(157, 329);
            this.roomsListBox.TabIndex = 1;
            this.roomsListBox.ValueMember = "Description";
            // 
            // addRoomButton
            // 
            this.addRoomButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.addRoomButton.Location = new System.Drawing.Point(17, 363);
            this.addRoomButton.Name = "addRoomButton";
            this.addRoomButton.Size = new System.Drawing.Size(75, 23);
            this.addRoomButton.TabIndex = 2;
            this.addRoomButton.Text = "&Add";
            this.addRoomButton.UseVisualStyleBackColor = true;
            // 
            // removeRoomButton
            // 
            this.removeRoomButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.removeRoomButton.Location = new System.Drawing.Point(99, 363);
            this.removeRoomButton.Name = "removeRoomButton";
            this.removeRoomButton.Size = new System.Drawing.Size(75, 23);
            this.removeRoomButton.TabIndex = 3;
            this.removeRoomButton.Text = "&Remove";
            this.removeRoomButton.UseVisualStyleBackColor = true;
            // 
            // WorldView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.removeRoomButton);
            this.Controls.Add(this.addRoomButton);
            this.Controls.Add(this.roomsListBox);
            this.Controls.Add(this.labelRooms);
            this.Name = "WorldView";
            this.Size = new System.Drawing.Size(722, 404);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelRooms;
        private System.Windows.Forms.ListBox roomsListBox;
        private System.Windows.Forms.Button addRoomButton;
        private System.Windows.Forms.Button removeRoomButton;
    }
}
