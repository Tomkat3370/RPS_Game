
namespace RPS_Game
{
    partial class GameForm
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
            this.groupBoxOne = new System.Windows.Forms.GroupBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.scissorsRadioButtonOne = new System.Windows.Forms.RadioButton();
            this.paperRadioButtonOne = new System.Windows.Forms.RadioButton();
            this.rockRadioButtonOne = new System.Windows.Forms.RadioButton();
            this.errorLabel = new System.Windows.Forms.Label();
            this.groupBoxTwo = new System.Windows.Forms.GroupBox();
            this.scissorsRadioButtonTwo = new System.Windows.Forms.RadioButton();
            this.paperRadioButtonTwo = new System.Windows.Forms.RadioButton();
            this.rockRadioButtonTwo = new System.Windows.Forms.RadioButton();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.playButton = new System.Windows.Forms.Button();
            this.winnerLabel = new System.Windows.Forms.Label();
            this.groupBoxOne.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.groupBoxTwo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBoxOne
            // 
            this.groupBoxOne.Controls.Add(this.pictureBox1);
            this.groupBoxOne.Controls.Add(this.scissorsRadioButtonOne);
            this.groupBoxOne.Controls.Add(this.paperRadioButtonOne);
            this.groupBoxOne.Controls.Add(this.rockRadioButtonOne);
            this.groupBoxOne.Location = new System.Drawing.Point(51, 55);
            this.groupBoxOne.Name = "groupBoxOne";
            this.groupBoxOne.Size = new System.Drawing.Size(348, 908);
            this.groupBoxOne.TabIndex = 4;
            this.groupBoxOne.TabStop = false;
            this.groupBoxOne.Text = "NameOne";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::RPS_Game.Properties.Resources.Scissors;
            this.pictureBox1.Location = new System.Drawing.Point(29, 47);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(271, 229);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // scissorsRadioButtonOne
            // 
            this.scissorsRadioButtonOne.AutoSize = true;
            this.scissorsRadioButtonOne.Location = new System.Drawing.Point(29, 422);
            this.scissorsRadioButtonOne.Name = "scissorsRadioButtonOne";
            this.scissorsRadioButtonOne.Size = new System.Drawing.Size(157, 45);
            this.scissorsRadioButtonOne.TabIndex = 2;
            this.scissorsRadioButtonOne.Text = "Scissors";
            this.scissorsRadioButtonOne.UseVisualStyleBackColor = true;
            this.scissorsRadioButtonOne.CheckedChanged += new System.EventHandler(this.SetPlayerOneChoice);
            // 
            // paperRadioButtonOne
            // 
            this.paperRadioButtonOne.AutoSize = true;
            this.paperRadioButtonOne.Location = new System.Drawing.Point(29, 364);
            this.paperRadioButtonOne.Name = "paperRadioButtonOne";
            this.paperRadioButtonOne.Size = new System.Drawing.Size(125, 45);
            this.paperRadioButtonOne.TabIndex = 1;
            this.paperRadioButtonOne.Text = "Paper";
            this.paperRadioButtonOne.UseVisualStyleBackColor = true;
            this.paperRadioButtonOne.CheckedChanged += new System.EventHandler(this.SetPlayerOneChoice);
            // 
            // rockRadioButtonOne
            // 
            this.rockRadioButtonOne.AutoSize = true;
            this.rockRadioButtonOne.Location = new System.Drawing.Point(29, 305);
            this.rockRadioButtonOne.Name = "rockRadioButtonOne";
            this.rockRadioButtonOne.Size = new System.Drawing.Size(111, 45);
            this.rockRadioButtonOne.TabIndex = 0;
            this.rockRadioButtonOne.Text = "Rock";
            this.rockRadioButtonOne.UseVisualStyleBackColor = true;
            this.rockRadioButtonOne.CheckedChanged += new System.EventHandler(this.SetPlayerOneChoice);
            // 
            // errorLabel
            // 
            this.errorLabel.AutoSize = true;
            this.errorLabel.BackColor = System.Drawing.Color.Red;
            this.errorLabel.Location = new System.Drawing.Point(222, 9);
            this.errorLabel.Name = "errorLabel";
            this.errorLabel.Size = new System.Drawing.Size(0, 41);
            this.errorLabel.TabIndex = 7;
            // 
            // groupBoxTwo
            // 
            this.groupBoxTwo.Controls.Add(this.scissorsRadioButtonTwo);
            this.groupBoxTwo.Controls.Add(this.paperRadioButtonTwo);
            this.groupBoxTwo.Controls.Add(this.rockRadioButtonTwo);
            this.groupBoxTwo.Controls.Add(this.pictureBox2);
            this.groupBoxTwo.Location = new System.Drawing.Point(645, 55);
            this.groupBoxTwo.Name = "groupBoxTwo";
            this.groupBoxTwo.Size = new System.Drawing.Size(342, 544);
            this.groupBoxTwo.TabIndex = 5;
            this.groupBoxTwo.TabStop = false;
            this.groupBoxTwo.Text = "NameTwo";
            // 
            // scissorsRadioButtonTwo
            // 
            this.scissorsRadioButtonTwo.AutoSize = true;
            this.scissorsRadioButtonTwo.Location = new System.Drawing.Point(39, 422);
            this.scissorsRadioButtonTwo.Name = "scissorsRadioButtonTwo";
            this.scissorsRadioButtonTwo.Size = new System.Drawing.Size(157, 45);
            this.scissorsRadioButtonTwo.TabIndex = 6;
            this.scissorsRadioButtonTwo.TabStop = true;
            this.scissorsRadioButtonTwo.Text = "Scissors";
            this.scissorsRadioButtonTwo.UseVisualStyleBackColor = true;
            this.scissorsRadioButtonTwo.CheckedChanged += new System.EventHandler(this.SetPlayerTwoChoice);
            // 
            // paperRadioButtonTwo
            // 
            this.paperRadioButtonTwo.AutoSize = true;
            this.paperRadioButtonTwo.Location = new System.Drawing.Point(39, 364);
            this.paperRadioButtonTwo.Name = "paperRadioButtonTwo";
            this.paperRadioButtonTwo.Size = new System.Drawing.Size(125, 45);
            this.paperRadioButtonTwo.TabIndex = 5;
            this.paperRadioButtonTwo.TabStop = true;
            this.paperRadioButtonTwo.Text = "Paper";
            this.paperRadioButtonTwo.UseVisualStyleBackColor = true;
            this.paperRadioButtonTwo.CheckedChanged += new System.EventHandler(this.SetPlayerTwoChoice);
            // 
            // rockRadioButtonTwo
            // 
            this.rockRadioButtonTwo.AutoSize = true;
            this.rockRadioButtonTwo.Location = new System.Drawing.Point(39, 305);
            this.rockRadioButtonTwo.Name = "rockRadioButtonTwo";
            this.rockRadioButtonTwo.Size = new System.Drawing.Size(111, 45);
            this.rockRadioButtonTwo.TabIndex = 4;
            this.rockRadioButtonTwo.TabStop = true;
            this.rockRadioButtonTwo.Text = "Rock";
            this.rockRadioButtonTwo.UseVisualStyleBackColor = true;
            this.rockRadioButtonTwo.CheckedChanged += new System.EventHandler(this.SetPlayerTwoChoice);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Location = new System.Drawing.Point(35, 70);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(271, 212);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 3;
            this.pictureBox2.TabStop = false;
            // 
            // playButton
            // 
            this.playButton.Location = new System.Drawing.Point(434, 535);
            this.playButton.Margin = new System.Windows.Forms.Padding(8, 6, 8, 6);
            this.playButton.Name = "playButton";
            this.playButton.Size = new System.Drawing.Size(181, 64);
            this.playButton.TabIndex = 6;
            this.playButton.Text = "Play";
            this.playButton.UseVisualStyleBackColor = true;
            this.playButton.Click += new System.EventHandler(this.SelectPlayButton);
            // 
            // winnerLabel
            // 
            this.winnerLabel.AutoSize = true;
            this.winnerLabel.BackColor = System.Drawing.Color.LawnGreen;
            this.winnerLabel.Location = new System.Drawing.Point(502, 102);
            this.winnerLabel.Name = "winnerLabel";
            this.winnerLabel.Size = new System.Drawing.Size(89, 41);
            this.winnerLabel.TabIndex = 8;
            this.winnerLabel.Text = "hello";
            this.winnerLabel.Click += new System.EventHandler(this.DisplayWinner);
            // 
            // GameForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(18F, 40F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1025, 683);
            this.Controls.Add(this.winnerLabel);
            this.Controls.Add(this.errorLabel);
            this.Controls.Add(this.playButton);
            this.Controls.Add(this.groupBoxTwo);
            this.Controls.Add(this.groupBoxOne);
            this.Font = new System.Drawing.Font("Tahoma", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Name = "GameForm";
            this.Text = "Game";
            this.groupBoxOne.ResumeLayout(false);
            this.groupBoxOne.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.groupBoxTwo.ResumeLayout(false);
            this.groupBoxTwo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.GroupBox groupBoxOne;
        private System.Windows.Forms.GroupBox groupBoxTwo;
        private System.Windows.Forms.RadioButton scissorsRadioButtonOne;
        private System.Windows.Forms.RadioButton paperRadioButtonOne;
        private System.Windows.Forms.RadioButton rockRadioButtonOne;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.RadioButton scissorsRadioButtonTwo;
        private System.Windows.Forms.RadioButton paperRadioButtonTwo;
        private System.Windows.Forms.RadioButton rockRadioButtonTwo;
        private System.Windows.Forms.Button playButton;
        private System.Windows.Forms.Label errorLabel;
        private System.Windows.Forms.Label winnerLabel;
    }
}