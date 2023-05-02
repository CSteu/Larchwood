namespace FinalProject
{
    partial class PlayerPointInput
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
            this.DescBox = new System.Windows.Forms.RichTextBox();
            this.NameBox = new System.Windows.Forms.TextBox();
            this.PointsBox = new System.Windows.Forms.TextBox();
            this.EnterButton = new System.Windows.Forms.Button();
            this.DoneButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // DescBox
            // 
            this.DescBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DescBox.Location = new System.Drawing.Point(37, 33);
            this.DescBox.Name = "DescBox";
            this.DescBox.ReadOnly = true;
            this.DescBox.Size = new System.Drawing.Size(730, 383);
            this.DescBox.TabIndex = 0;
            this.DescBox.Text = "Player:\n\nPoints Earned: ";
            // 
            // NameBox
            // 
            this.NameBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NameBox.Location = new System.Drawing.Point(205, 42);
            this.NameBox.Name = "NameBox";
            this.NameBox.ReadOnly = true;
            this.NameBox.Size = new System.Drawing.Size(550, 62);
            this.NameBox.TabIndex = 1;
            this.NameBox.TextChanged += new System.EventHandler(this.NameBox_TextChanged);
            // 
            // PointsBox
            // 
            this.PointsBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PointsBox.Location = new System.Drawing.Point(358, 144);
            this.PointsBox.Name = "PointsBox";
            this.PointsBox.Size = new System.Drawing.Size(368, 62);
            this.PointsBox.TabIndex = 2;
            this.PointsBox.Text = "10";
            this.PointsBox.TextChanged += new System.EventHandler(this.PointsBox_TextChanged);
            // 
            // EnterButton
            // 
            this.EnterButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EnterButton.Location = new System.Drawing.Point(209, 291);
            this.EnterButton.Name = "EnterButton";
            this.EnterButton.Size = new System.Drawing.Size(399, 91);
            this.EnterButton.TabIndex = 3;
            this.EnterButton.Text = "ENTER POINTS";
            this.EnterButton.UseVisualStyleBackColor = true;
            this.EnterButton.Click += new System.EventHandler(this.EnterButton_Click);
            // 
            // DoneButton
            // 
            this.DoneButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DoneButton.Location = new System.Drawing.Point(56, 372);
            this.DoneButton.Name = "DoneButton";
            this.DoneButton.Size = new System.Drawing.Size(129, 28);
            this.DoneButton.TabIndex = 4;
            this.DoneButton.Text = "DONE";
            this.DoneButton.UseVisualStyleBackColor = true;
            this.DoneButton.Click += new System.EventHandler(this.DoneButton_Click);
            // 
            // PlayerPointInput
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.DoneButton);
            this.Controls.Add(this.EnterButton);
            this.Controls.Add(this.PointsBox);
            this.Controls.Add(this.NameBox);
            this.Controls.Add(this.DescBox);
            this.Name = "PlayerPointInput";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "PlayerPointInput";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox DescBox;
        private System.Windows.Forms.TextBox NameBox;
        private System.Windows.Forms.TextBox PointsBox;
        private System.Windows.Forms.Button EnterButton;
        private System.Windows.Forms.Button DoneButton;
    }
}