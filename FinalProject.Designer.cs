namespace FinalProject
{
    partial class LarchwoodTournament
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
            this.titleBox = new System.Windows.Forms.TextBox();
            this.APButton = new System.Windows.Forms.Button();
            this.NBox = new System.Windows.Forms.TextBox();
            this.GBox = new System.Windows.Forms.TextBox();
            this.NuBox = new System.Windows.Forms.TextBox();
            this.PpBox = new System.Windows.Forms.TextBox();
            this.NameBox = new System.Windows.Forms.TextBox();
            this.PPDBox = new System.Windows.Forms.TextBox();
            this.NumberBox = new System.Windows.Forms.TextBox();
            this.GenderBox = new System.Windows.Forms.ComboBox();
            this.recentBox = new System.Windows.Forms.RichTextBox();
            this.rNameBox = new System.Windows.Forms.TextBox();
            this.rPPDBox = new System.Windows.Forms.TextBox();
            this.rNumberBox = new System.Windows.Forms.TextBox();
            this.rGenderBox = new System.Windows.Forms.TextBox();
            this.RSTBox = new System.Windows.Forms.RichTextBox();
            this.RoundCountBox = new System.Windows.Forms.TextBox();
            this.startButton = new System.Windows.Forms.Button();
            this.defaultPanel = new System.Windows.Forms.Panel();
            this.EditPlayer = new System.Windows.Forms.Panel();
            this.BoardPanel = new System.Windows.Forms.Panel();
            this.BoardsBox = new System.Windows.Forms.RichTextBox();
            this.UpdateButton = new System.Windows.Forms.Button();
            this.SearchButton = new System.Windows.Forms.Button();
            this.RePPDBox = new System.Windows.Forms.TextBox();
            this.RenameBox = new System.Windows.Forms.TextBox();
            this.RegenderBox = new System.Windows.Forms.TextBox();
            this.RenumberBox = new System.Windows.Forms.TextBox();
            this.SearchNameBox = new System.Windows.Forms.TextBox();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.EditPlayerButton = new System.Windows.Forms.Button();
            this.HomeButton = new System.Windows.Forms.Button();
            this.EditPlayer.SuspendLayout();
            this.BoardPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // titleBox
            // 
            this.titleBox.Cursor = System.Windows.Forms.Cursors.No;
            this.titleBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.titleBox.Location = new System.Drawing.Point(10, 9);
            this.titleBox.Name = "titleBox";
            this.titleBox.ReadOnly = true;
            this.titleBox.Size = new System.Drawing.Size(1808, 62);
            this.titleBox.TabIndex = 0;
            this.titleBox.Text = "LARCHWOOD TOURNAMENT";
            this.titleBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // APButton
            // 
            this.APButton.Location = new System.Drawing.Point(10, 92);
            this.APButton.Name = "APButton";
            this.APButton.Size = new System.Drawing.Size(138, 42);
            this.APButton.TabIndex = 1;
            this.APButton.Text = "ADD PLAYER";
            this.APButton.UseVisualStyleBackColor = true;
            this.APButton.Click += new System.EventHandler(this.APButton_Click);
            // 
            // NBox
            // 
            this.NBox.Location = new System.Drawing.Point(12, 157);
            this.NBox.Name = "NBox";
            this.NBox.ReadOnly = true;
            this.NBox.Size = new System.Drawing.Size(108, 26);
            this.NBox.TabIndex = 2;
            this.NBox.Text = "Name:";
            this.NBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.NBox.TextChanged += new System.EventHandler(this.NBox_TextChanged);
            // 
            // GBox
            // 
            this.GBox.Location = new System.Drawing.Point(12, 189);
            this.GBox.Name = "GBox";
            this.GBox.ReadOnly = true;
            this.GBox.Size = new System.Drawing.Size(108, 26);
            this.GBox.TabIndex = 3;
            this.GBox.Text = "Gender:";
            this.GBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.GBox.TextChanged += new System.EventHandler(this.GBox_TextChanged);
            // 
            // NuBox
            // 
            this.NuBox.Location = new System.Drawing.Point(12, 221);
            this.NuBox.Name = "NuBox";
            this.NuBox.ReadOnly = true;
            this.NuBox.Size = new System.Drawing.Size(108, 26);
            this.NuBox.TabIndex = 4;
            this.NuBox.Text = "Number:";
            this.NuBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.NuBox.TextChanged += new System.EventHandler(this.NuBox_TextChanged);
            // 
            // PpBox
            // 
            this.PpBox.Location = new System.Drawing.Point(12, 253);
            this.PpBox.Name = "PpBox";
            this.PpBox.ReadOnly = true;
            this.PpBox.Size = new System.Drawing.Size(108, 26);
            this.PpBox.TabIndex = 5;
            this.PpBox.Text = "PPD:";
            this.PpBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.PpBox.TextChanged += new System.EventHandler(this.PpBox_TextChanged);
            // 
            // NameBox
            // 
            this.NameBox.Location = new System.Drawing.Point(126, 157);
            this.NameBox.Name = "NameBox";
            this.NameBox.Size = new System.Drawing.Size(132, 26);
            this.NameBox.TabIndex = 6;
            this.NameBox.TextChanged += new System.EventHandler(this.NameBox_TextChanged);
            // 
            // PPDBox
            // 
            this.PPDBox.Location = new System.Drawing.Point(126, 253);
            this.PPDBox.Name = "PPDBox";
            this.PPDBox.Size = new System.Drawing.Size(132, 26);
            this.PPDBox.TabIndex = 8;
            this.PPDBox.TextChanged += new System.EventHandler(this.PPDBox_TextChanged);
            // 
            // NumberBox
            // 
            this.NumberBox.Location = new System.Drawing.Point(126, 221);
            this.NumberBox.Name = "NumberBox";
            this.NumberBox.ReadOnly = true;
            this.NumberBox.Size = new System.Drawing.Size(132, 26);
            this.NumberBox.TabIndex = 10;
            this.NumberBox.Text = "1";
            this.NumberBox.TextChanged += new System.EventHandler(this.NumberBox_TextChanged);
            // 
            // GenderBox
            // 
            this.GenderBox.FormattingEnabled = true;
            this.GenderBox.Items.AddRange(new object[] {
            "Male",
            "Female"});
            this.GenderBox.Location = new System.Drawing.Point(126, 187);
            this.GenderBox.Name = "GenderBox";
            this.GenderBox.Size = new System.Drawing.Size(132, 28);
            this.GenderBox.TabIndex = 7;
            this.GenderBox.SelectedIndexChanged += new System.EventHandler(this.GenderBox_SelectedIndexChanged);
            // 
            // recentBox
            // 
            this.recentBox.Location = new System.Drawing.Point(10, 296);
            this.recentBox.Name = "recentBox";
            this.recentBox.ReadOnly = true;
            this.recentBox.Size = new System.Drawing.Size(248, 221);
            this.recentBox.TabIndex = 11;
            this.recentBox.Text = "Recently Added/Edited Player\n\nName:\n\nGender:\n\nNumber:\n\nPPD:";
            // 
            // rNameBox
            // 
            this.rNameBox.Location = new System.Drawing.Point(126, 335);
            this.rNameBox.Name = "rNameBox";
            this.rNameBox.Size = new System.Drawing.Size(132, 26);
            this.rNameBox.TabIndex = 12;
            this.rNameBox.TextChanged += new System.EventHandler(this.rNameBox_TextChanged);
            // 
            // rPPDBox
            // 
            this.rPPDBox.Location = new System.Drawing.Point(126, 459);
            this.rPPDBox.Name = "rPPDBox";
            this.rPPDBox.Size = new System.Drawing.Size(132, 26);
            this.rPPDBox.TabIndex = 13;
            this.rPPDBox.TextChanged += new System.EventHandler(this.rPPDBox_TextChanged);
            // 
            // rNumberBox
            // 
            this.rNumberBox.Location = new System.Drawing.Point(126, 417);
            this.rNumberBox.Name = "rNumberBox";
            this.rNumberBox.Size = new System.Drawing.Size(132, 26);
            this.rNumberBox.TabIndex = 14;
            this.rNumberBox.TextChanged += new System.EventHandler(this.rNumberBox_TextChanged);
            // 
            // rGenderBox
            // 
            this.rGenderBox.Location = new System.Drawing.Point(126, 376);
            this.rGenderBox.Name = "rGenderBox";
            this.rGenderBox.Size = new System.Drawing.Size(132, 26);
            this.rGenderBox.TabIndex = 15;
            this.rGenderBox.TextChanged += new System.EventHandler(this.rGenderBox_TextChanged);
            // 
            // RSTBox
            // 
            this.RSTBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RSTBox.Location = new System.Drawing.Point(13, 531);
            this.RSTBox.Name = "RSTBox";
            this.RSTBox.ReadOnly = true;
            this.RSTBox.Size = new System.Drawing.Size(244, 244);
            this.RSTBox.TabIndex = 16;
            this.RSTBox.Text = "Rounds:\n\n";
            this.RSTBox.TextChanged += new System.EventHandler(this.RSTBox_TextChanged);
            // 
            // RoundCountBox
            // 
            this.RoundCountBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RoundCountBox.Location = new System.Drawing.Point(139, 531);
            this.RoundCountBox.Name = "RoundCountBox";
            this.RoundCountBox.Size = new System.Drawing.Size(118, 44);
            this.RoundCountBox.TabIndex = 17;
            this.RoundCountBox.Text = "1";
            this.RoundCountBox.TextChanged += new System.EventHandler(this.RoundCountBox_TextChanged);
            // 
            // startButton
            // 
            this.startButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.startButton.Location = new System.Drawing.Point(26, 595);
            this.startButton.Name = "startButton";
            this.startButton.Size = new System.Drawing.Size(219, 162);
            this.startButton.TabIndex = 18;
            this.startButton.Text = "START TOURNAMENT";
            this.startButton.UseVisualStyleBackColor = true;
            this.startButton.Click += new System.EventHandler(this.startButton_Click);
            // 
            // defaultPanel
            // 
            this.defaultPanel.BackColor = System.Drawing.SystemColors.ControlDark;
            this.defaultPanel.Location = new System.Drawing.Point(284, 157);
            this.defaultPanel.Name = "defaultPanel";
            this.defaultPanel.Size = new System.Drawing.Size(1533, 617);
            this.defaultPanel.TabIndex = 19;
            this.defaultPanel.Paint += new System.Windows.Forms.PaintEventHandler(this.defaultPanel_Paint);
            // 
            // EditPlayer
            // 
            this.EditPlayer.BackColor = System.Drawing.SystemColors.Control;
            this.EditPlayer.Controls.Add(this.BoardPanel);
            this.EditPlayer.Controls.Add(this.UpdateButton);
            this.EditPlayer.Controls.Add(this.SearchButton);
            this.EditPlayer.Controls.Add(this.RePPDBox);
            this.EditPlayer.Controls.Add(this.RenameBox);
            this.EditPlayer.Controls.Add(this.RegenderBox);
            this.EditPlayer.Controls.Add(this.RenumberBox);
            this.EditPlayer.Controls.Add(this.SearchNameBox);
            this.EditPlayer.Controls.Add(this.richTextBox1);
            this.EditPlayer.Location = new System.Drawing.Point(284, 157);
            this.EditPlayer.Name = "EditPlayer";
            this.EditPlayer.Size = new System.Drawing.Size(1533, 617);
            this.EditPlayer.TabIndex = 20;
            this.EditPlayer.Paint += new System.Windows.Forms.PaintEventHandler(this.EditPlayer_Paint);
            // 
            // BoardPanel
            // 
            this.BoardPanel.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.BoardPanel.Controls.Add(this.BoardsBox);
            this.BoardPanel.Location = new System.Drawing.Point(38, 32);
            this.BoardPanel.Name = "BoardPanel";
            this.BoardPanel.Size = new System.Drawing.Size(1273, 526);
            this.BoardPanel.TabIndex = 8;
            this.BoardPanel.Paint += new System.Windows.Forms.PaintEventHandler(this.BoardPanel_Paint);
            // 
            // BoardsBox
            // 
            this.BoardsBox.Location = new System.Drawing.Point(13, 14);
            this.BoardsBox.Name = "BoardsBox";
            this.BoardsBox.Size = new System.Drawing.Size(1242, 498);
            this.BoardsBox.TabIndex = 0;
            this.BoardsBox.Text = "";
            this.BoardsBox.TextChanged += new System.EventHandler(this.BoardsBox_TextChanged);
            // 
            // UpdateButton
            // 
            this.UpdateButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UpdateButton.Location = new System.Drawing.Point(255, 417);
            this.UpdateButton.Name = "UpdateButton";
            this.UpdateButton.Size = new System.Drawing.Size(406, 63);
            this.UpdateButton.TabIndex = 7;
            this.UpdateButton.Text = "UPDATE";
            this.UpdateButton.UseVisualStyleBackColor = true;
            this.UpdateButton.Click += new System.EventHandler(this.UpdateButton_Click);
            // 
            // SearchButton
            // 
            this.SearchButton.Location = new System.Drawing.Point(696, 36);
            this.SearchButton.Name = "SearchButton";
            this.SearchButton.Size = new System.Drawing.Size(130, 39);
            this.SearchButton.TabIndex = 6;
            this.SearchButton.Text = "SEARCH";
            this.SearchButton.UseVisualStyleBackColor = true;
            this.SearchButton.Click += new System.EventHandler(this.SearchButton_Click);
            // 
            // RePPDBox
            // 
            this.RePPDBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RePPDBox.Location = new System.Drawing.Point(255, 336);
            this.RePPDBox.Name = "RePPDBox";
            this.RePPDBox.Size = new System.Drawing.Size(407, 44);
            this.RePPDBox.TabIndex = 5;
            this.RePPDBox.TextChanged += new System.EventHandler(this.RePPDBox_TextChanged);
            // 
            // RenameBox
            // 
            this.RenameBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RenameBox.Location = new System.Drawing.Point(255, 96);
            this.RenameBox.Name = "RenameBox";
            this.RenameBox.Size = new System.Drawing.Size(407, 44);
            this.RenameBox.TabIndex = 4;
            this.RenameBox.TextChanged += new System.EventHandler(this.RenameBox_TextChanged);
            // 
            // RegenderBox
            // 
            this.RegenderBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RegenderBox.Location = new System.Drawing.Point(255, 178);
            this.RegenderBox.Name = "RegenderBox";
            this.RegenderBox.Size = new System.Drawing.Size(407, 44);
            this.RegenderBox.TabIndex = 3;
            this.RegenderBox.TextChanged += new System.EventHandler(this.RegenderBox_TextChanged);
            // 
            // RenumberBox
            // 
            this.RenumberBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RenumberBox.Location = new System.Drawing.Point(255, 260);
            this.RenumberBox.Name = "RenumberBox";
            this.RenumberBox.ReadOnly = true;
            this.RenumberBox.Size = new System.Drawing.Size(407, 44);
            this.RenumberBox.TabIndex = 2;
            this.RenumberBox.TextChanged += new System.EventHandler(this.RenumberBox_TextChanged);
            // 
            // SearchNameBox
            // 
            this.SearchNameBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SearchNameBox.Location = new System.Drawing.Point(283, 36);
            this.SearchNameBox.Name = "SearchNameBox";
            this.SearchNameBox.Size = new System.Drawing.Size(407, 44);
            this.SearchNameBox.TabIndex = 1;
            this.SearchNameBox.TextChanged += new System.EventHandler(this.SearchNameBox_TextChanged);
            // 
            // richTextBox1
            // 
            this.richTextBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.richTextBox1.Location = new System.Drawing.Point(38, 32);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.ReadOnly = true;
            this.richTextBox1.Size = new System.Drawing.Size(1273, 526);
            this.richTextBox1.TabIndex = 0;
            this.richTextBox1.Text = "Search Number:\n\nName: \n\nGender:\n\nNumber:\n\nPPD:";
            // 
            // EditPlayerButton
            // 
            this.EditPlayerButton.Location = new System.Drawing.Point(1679, 109);
            this.EditPlayerButton.Name = "EditPlayerButton";
            this.EditPlayerButton.Size = new System.Drawing.Size(138, 42);
            this.EditPlayerButton.TabIndex = 21;
            this.EditPlayerButton.Text = "EDIT PLAYER";
            this.EditPlayerButton.UseVisualStyleBackColor = true;
            this.EditPlayerButton.Click += new System.EventHandler(this.EditPlayerButton_Click);
            // 
            // HomeButton
            // 
            this.HomeButton.Location = new System.Drawing.Point(284, 109);
            this.HomeButton.Name = "HomeButton";
            this.HomeButton.Size = new System.Drawing.Size(73, 41);
            this.HomeButton.TabIndex = 22;
            this.HomeButton.Text = "HOME";
            this.HomeButton.UseVisualStyleBackColor = true;
            this.HomeButton.Click += new System.EventHandler(this.HomeButton_Click);
            // 
            // LarchwoodTournament
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1830, 799);
            this.Controls.Add(this.HomeButton);
            this.Controls.Add(this.EditPlayerButton);
            this.Controls.Add(this.EditPlayer);
            this.Controls.Add(this.defaultPanel);
            this.Controls.Add(this.startButton);
            this.Controls.Add(this.RoundCountBox);
            this.Controls.Add(this.RSTBox);
            this.Controls.Add(this.rGenderBox);
            this.Controls.Add(this.rNumberBox);
            this.Controls.Add(this.rPPDBox);
            this.Controls.Add(this.rNameBox);
            this.Controls.Add(this.recentBox);
            this.Controls.Add(this.GenderBox);
            this.Controls.Add(this.NumberBox);
            this.Controls.Add(this.PPDBox);
            this.Controls.Add(this.NameBox);
            this.Controls.Add(this.PpBox);
            this.Controls.Add(this.NuBox);
            this.Controls.Add(this.GBox);
            this.Controls.Add(this.NBox);
            this.Controls.Add(this.APButton);
            this.Controls.Add(this.titleBox);
            this.Name = "LarchwoodTournament";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "LarchwoodTournament";
            this.Load += new System.EventHandler(this.LarchwoodTournament_Load);
            this.EditPlayer.ResumeLayout(false);
            this.EditPlayer.PerformLayout();
            this.BoardPanel.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox titleBox;
        private System.Windows.Forms.Button APButton;
        private System.Windows.Forms.TextBox NBox;
        private System.Windows.Forms.TextBox GBox;
        private System.Windows.Forms.TextBox NuBox;
        private System.Windows.Forms.TextBox PpBox;
        private System.Windows.Forms.TextBox NameBox;
        private System.Windows.Forms.TextBox PPDBox;
        private System.Windows.Forms.TextBox NumberBox;
        private System.Windows.Forms.ComboBox GenderBox;
        private System.Windows.Forms.RichTextBox recentBox;
        private System.Windows.Forms.TextBox rNameBox;
        private System.Windows.Forms.TextBox rPPDBox;
        private System.Windows.Forms.TextBox rNumberBox;
        private System.Windows.Forms.TextBox rGenderBox;
        private System.Windows.Forms.RichTextBox RSTBox;
        private System.Windows.Forms.TextBox RoundCountBox;
        private System.Windows.Forms.Button startButton;
        private System.Windows.Forms.Panel defaultPanel;
        private System.Windows.Forms.Panel EditPlayer;
        private System.Windows.Forms.Button EditPlayerButton;
        private System.Windows.Forms.Button HomeButton;
        private System.Windows.Forms.TextBox RePPDBox;
        private System.Windows.Forms.TextBox RenameBox;
        private System.Windows.Forms.TextBox RegenderBox;
        private System.Windows.Forms.TextBox RenumberBox;
        private System.Windows.Forms.TextBox SearchNameBox;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.Button SearchButton;
        private System.Windows.Forms.Button UpdateButton;
        private System.Windows.Forms.Panel BoardPanel;
        private System.Windows.Forms.RichTextBox BoardsBox;
    }
}

