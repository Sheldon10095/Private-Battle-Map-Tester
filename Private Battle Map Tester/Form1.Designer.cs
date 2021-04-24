namespace Private_Battle_Map_Tester
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.connectBox = new System.Windows.Forms.GroupBox();
            this.DisconnButton = new System.Windows.Forms.Button();
            this.ConnectButton = new System.Windows.Forms.Button();
            this.IPBox = new System.Windows.Forms.TextBox();
            this.editingBox = new System.Windows.Forms.GroupBox();
            this.poke = new System.Windows.Forms.Button();
            this.mode = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.first4PlayersAlpha = new System.Windows.Forms.CheckBox();
            this.label1 = new System.Windows.Forms.Label();
            this.stage = new System.Windows.Forms.ComboBox();
            this.authorLabel = new System.Windows.Forms.Label();
            this.connectBox.SuspendLayout();
            this.editingBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // connectBox
            // 
            this.connectBox.Controls.Add(this.DisconnButton);
            this.connectBox.Controls.Add(this.ConnectButton);
            this.connectBox.Controls.Add(this.IPBox);
            this.connectBox.Location = new System.Drawing.Point(12, 12);
            this.connectBox.Name = "connectBox";
            this.connectBox.Size = new System.Drawing.Size(350, 49);
            this.connectBox.TabIndex = 6;
            this.connectBox.TabStop = false;
            this.connectBox.Text = "TCPGecko Connection";
            // 
            // DisconnButton
            // 
            this.DisconnButton.Enabled = false;
            this.DisconnButton.Location = new System.Drawing.Point(230, 17);
            this.DisconnButton.Name = "DisconnButton";
            this.DisconnButton.Size = new System.Drawing.Size(112, 23);
            this.DisconnButton.TabIndex = 2;
            this.DisconnButton.Text = "Disconnect";
            this.DisconnButton.UseVisualStyleBackColor = true;
            this.DisconnButton.Click += new System.EventHandler(this.DisconnButton_Click);
            // 
            // ConnectButton
            // 
            this.ConnectButton.Location = new System.Drawing.Point(112, 17);
            this.ConnectButton.Name = "ConnectButton";
            this.ConnectButton.Size = new System.Drawing.Size(112, 23);
            this.ConnectButton.TabIndex = 1;
            this.ConnectButton.Text = "Connect to Gecko";
            this.ConnectButton.UseVisualStyleBackColor = true;
            this.ConnectButton.Click += new System.EventHandler(this.ConnectButton_Click);
            // 
            // IPBox
            // 
            this.IPBox.Location = new System.Drawing.Point(6, 19);
            this.IPBox.Name = "IPBox";
            this.IPBox.Size = new System.Drawing.Size(100, 20);
            this.IPBox.TabIndex = 0;
            this.IPBox.Text = "192.168.1.5";
            // 
            // editingBox
            // 
            this.editingBox.Controls.Add(this.poke);
            this.editingBox.Controls.Add(this.mode);
            this.editingBox.Controls.Add(this.label2);
            this.editingBox.Controls.Add(this.first4PlayersAlpha);
            this.editingBox.Controls.Add(this.label1);
            this.editingBox.Controls.Add(this.stage);
            this.editingBox.Enabled = false;
            this.editingBox.Location = new System.Drawing.Point(12, 67);
            this.editingBox.Name = "editingBox";
            this.editingBox.Size = new System.Drawing.Size(350, 92);
            this.editingBox.TabIndex = 7;
            this.editingBox.TabStop = false;
            this.editingBox.Text = "Private Battle Editor";
            // 
            // poke
            // 
            this.poke.Location = new System.Drawing.Point(269, 36);
            this.poke.Name = "poke";
            this.poke.Size = new System.Drawing.Size(75, 23);
            this.poke.TabIndex = 8;
            this.poke.Text = "Poke";
            this.poke.UseVisualStyleBackColor = true;
            this.poke.Click += new System.EventHandler(this.poke_Click);
            // 
            // mode
            // 
            this.mode.FormattingEnabled = true;
            this.mode.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.mode.Items.AddRange(new object[] {
            "Urchin Underpass",
            "Walleye Warehouse",
            "Saltspray Rig",
            "Arowana Mall",
            "Blackbelly Skatepark",
            "Camp Triggerfish",
            "Port Mackerel",
            "Kelp Dome",
            "Moray Towers",
            "Bluefin Depot",
            "Hammerhead Bridge",
            "Flounder Heights",
            "Museum d\'Alfonsino",
            "Ancho-V Games",
            "Piranha Pit",
            "Mahi-Mahi Resort"});
            this.mode.Location = new System.Drawing.Point(174, 36);
            this.mode.Name = "mode";
            this.mode.Size = new System.Drawing.Size(88, 21);
            this.mode.TabIndex = 7;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(175, 20);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(34, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Mode";
            // 
            // first4PlayersAlpha
            // 
            this.first4PlayersAlpha.AutoSize = true;
            this.first4PlayersAlpha.Location = new System.Drawing.Point(10, 69);
            this.first4PlayersAlpha.Name = "first4PlayersAlpha";
            this.first4PlayersAlpha.Size = new System.Drawing.Size(182, 17);
            this.first4PlayersAlpha.TabIndex = 5;
            this.first4PlayersAlpha.Text = "Set First 4 Players to Team Alpha";
            this.first4PlayersAlpha.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Stage";
            // 
            // stage
            // 
            this.stage.FormattingEnabled = true;
            this.stage.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.stage.Items.AddRange(new object[] {
            "Urchin Underpass",
            "Walleye Warehouse",
            "Saltspray Rig",
            "Arowana Mall",
            "Blackbelly Skatepark",
            "Camp Triggerfish",
            "Port Mackerel",
            "Kelp Dome",
            "Moray Towers",
            "Bluefin Depot",
            "Hammerhead Bridge",
            "Flounder Heights",
            "Museum d\'Alfonsino",
            "Ancho-V Games",
            "Piranha Pit",
            "Mahi-Mahi Resort"});
            this.stage.Location = new System.Drawing.Point(10, 36);
            this.stage.Name = "stage";
            this.stage.Size = new System.Drawing.Size(158, 21);
            this.stage.TabIndex = 3;
            // 
            // authorLabel
            // 
            this.authorLabel.AutoSize = true;
            this.authorLabel.Location = new System.Drawing.Point(12, 162);
            this.authorLabel.Name = "authorLabel";
            this.authorLabel.Size = new System.Drawing.Size(90, 13);
            this.authorLabel.TabIndex = 8;
            this.authorLabel.Text = "Made by Sheldon";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(374, 184);
            this.Controls.Add(this.authorLabel);
            this.Controls.Add(this.editingBox);
            this.Controls.Add(this.connectBox);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Private Battle Map Tester";
            this.connectBox.ResumeLayout(false);
            this.connectBox.PerformLayout();
            this.editingBox.ResumeLayout(false);
            this.editingBox.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox connectBox;
        private System.Windows.Forms.Button DisconnButton;
        private System.Windows.Forms.Button ConnectButton;
        private System.Windows.Forms.TextBox IPBox;
        private System.Windows.Forms.GroupBox editingBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox stage;
        private System.Windows.Forms.Button poke;
        private System.Windows.Forms.ComboBox mode;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.CheckBox first4PlayersAlpha;
        private System.Windows.Forms.Label authorLabel;
    }
}

