namespace Zork.Builder.UserControls
{
    partial class SettingsView
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
            this.welcomeMessageLabel = new System.Windows.Forms.Label();
            this.welcomeMessageTextBox = new System.Windows.Forms.TextBox();
            this.exitMessageLabel = new System.Windows.Forms.Label();
            this.exitMessageTextBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // welcomeMessageLabel
            // 
            this.welcomeMessageLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.welcomeMessageLabel.AutoSize = true;
            this.welcomeMessageLabel.Location = new System.Drawing.Point(2, 3);
            this.welcomeMessageLabel.Name = "welcomeMessageLabel";
            this.welcomeMessageLabel.Size = new System.Drawing.Size(101, 13);
            this.welcomeMessageLabel.TabIndex = 0;
            this.welcomeMessageLabel.Text = "Welcome Message:";
            // 
            // welcomeMessageTextBox
            // 
            this.welcomeMessageTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.welcomeMessageTextBox.Location = new System.Drawing.Point(5, 19);
            this.welcomeMessageTextBox.Multiline = true;
            this.welcomeMessageTextBox.Name = "welcomeMessageTextBox";
            this.welcomeMessageTextBox.Size = new System.Drawing.Size(515, 104);
            this.welcomeMessageTextBox.TabIndex = 1;
            // 
            // exitMessageLabel
            // 
            this.exitMessageLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.exitMessageLabel.AutoSize = true;
            this.exitMessageLabel.Location = new System.Drawing.Point(3, 126);
            this.exitMessageLabel.Name = "exitMessageLabel";
            this.exitMessageLabel.Size = new System.Drawing.Size(73, 13);
            this.exitMessageLabel.TabIndex = 2;
            this.exitMessageLabel.Text = "Exit Message:";
            // 
            // exitMessageTextBox
            // 
            this.exitMessageTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.exitMessageTextBox.Location = new System.Drawing.Point(3, 142);
            this.exitMessageTextBox.Multiline = true;
            this.exitMessageTextBox.Name = "exitMessageTextBox";
            this.exitMessageTextBox.Size = new System.Drawing.Size(515, 90);
            this.exitMessageTextBox.TabIndex = 3;
            // 
            // SettingsView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.exitMessageTextBox);
            this.Controls.Add(this.exitMessageLabel);
            this.Controls.Add(this.welcomeMessageTextBox);
            this.Controls.Add(this.welcomeMessageLabel);
            this.Name = "SettingsView";
            this.Size = new System.Drawing.Size(528, 247);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label welcomeMessageLabel;
        private System.Windows.Forms.TextBox welcomeMessageTextBox;
        private System.Windows.Forms.Label exitMessageLabel;
        private System.Windows.Forms.TextBox exitMessageTextBox;
    }
}
