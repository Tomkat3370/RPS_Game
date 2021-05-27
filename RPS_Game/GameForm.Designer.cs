
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
            this.scoreOneLabel = new System.Windows.Forms.Label();
            this.scissorsRadioButtonOne = new System.Windows.Forms.RadioButton();
            this.paperRadioButtonOne = new System.Windows.Forms.RadioButton();
            this.rockRadioButtonOne = new System.Windows.Forms.RadioButton();
            this.errorLabel = new System.Windows.Forms.Label();
            this.groupBoxTwo = new System.Windows.Forms.GroupBox();
            this.scoreTwoLabel = new System.Windows.Forms.Label();
            this.scissorsRadioButtonTwo = new System.Windows.Forms.RadioButton();
            this.paperRadioButtonTwo = new System.Windows.Forms.RadioButton();
            this.rockRadioButtonTwo = new System.Windows.Forms.RadioButton();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.playButton = new System.Windows.Forms.Button();
            this.winnerLabel = new System.Windows.Forms.Label();
            this.clearButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.restartButton = new System.Windows.Forms.Button();
            this.groupBoxOne.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.groupBoxTwo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBoxOne
            // 
            this.groupBoxOne.Controls.Add(this.pictureBox1);
            this.groupBoxOne.Controls.Add(this.scoreOneLabel);
            this.groupBoxOne.Controls.Add(this.scissorsRadioButtonOne);
            this.groupBoxOne.Controls.Add(this.paperRadioButtonOne);
            this.groupBoxOne.Controls.Add(this.rockRadioButtonOne);
            this.groupBoxOne.Location = new System.Drawing.Point(24, 69);
            this.groupBoxOne.Name = "groupBoxOne";
            this.groupBoxOne.Size = new System.Drawing.Size(348, 544);
            this.groupBoxOne.TabIndex = 4;
            this.groupBoxOne.TabStop = false;
            this.groupBoxOne.Text = "NameOne";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(29, 70);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(271, 229);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 5;
            this.pictureBox1.TabStop = false;
            // 
            // scoreOneLabel
            // 
            this.scoreOneLabel.AutoSize = true;
            this.scoreOneLabel.Location = new System.Drawing.Point(202, 0);
            this.scoreOneLabel.Name = "scoreOneLabel";
            this.scoreOneLabel.Size = new System.Drawing.Size(42, 48);
            this.scoreOneLabel.TabIndex = 4;
            this.scoreOneLabel.Text = "0";
            // 
            // scissorsRadioButtonOne
            // 
            this.scissorsRadioButtonOne.AutoSize = true;
            this.scissorsRadioButtonOne.Location = new System.Drawing.Point(29, 422);
            this.scissorsRadioButtonOne.Name = "scissorsRadioButtonOne";
            this.scissorsRadioButtonOne.Size = new System.Drawing.Size(184, 52);
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
            this.paperRadioButtonOne.Size = new System.Drawing.Size(145, 52);
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
            this.rockRadioButtonOne.Size = new System.Drawing.Size(130, 52);
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
            this.errorLabel.Size = new System.Drawing.Size(0, 48);
            this.errorLabel.TabIndex = 7;
            // 
            // groupBoxTwo
            // 
            this.groupBoxTwo.Controls.Add(this.scoreTwoLabel);
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
            // scoreTwoLabel
            // 
            this.scoreTwoLabel.AutoSize = true;
            this.scoreTwoLabel.Location = new System.Drawing.Point(198, 0);
            this.scoreTwoLabel.Name = "scoreTwoLabel";
            this.scoreTwoLabel.Size = new System.Drawing.Size(42, 48);
            this.scoreTwoLabel.TabIndex = 5;
            this.scoreTwoLabel.Text = "0";
            // 
            // scissorsRadioButtonTwo
            // 
            this.scissorsRadioButtonTwo.AutoSize = true;
            this.scissorsRadioButtonTwo.Location = new System.Drawing.Point(39, 422);
            this.scissorsRadioButtonTwo.Name = "scissorsRadioButtonTwo";
            this.scissorsRadioButtonTwo.Size = new System.Drawing.Size(184, 52);
            this.scissorsRadioButtonTwo.TabIndex = 6;
            this.scissorsRadioButtonTwo.Text = "Scissors";
            this.scissorsRadioButtonTwo.UseVisualStyleBackColor = true;
            this.scissorsRadioButtonTwo.CheckedChanged += new System.EventHandler(this.SetPlayerTwoChoice);
            // 
            // paperRadioButtonTwo
            // 
            this.paperRadioButtonTwo.AutoSize = true;
            this.paperRadioButtonTwo.Location = new System.Drawing.Point(39, 364);
            this.paperRadioButtonTwo.Name = "paperRadioButtonTwo";
            this.paperRadioButtonTwo.Size = new System.Drawing.Size(145, 52);
            this.paperRadioButtonTwo.TabIndex = 5;
            this.paperRadioButtonTwo.Text = "Paper";
            this.paperRadioButtonTwo.UseVisualStyleBackColor = true;
            this.paperRadioButtonTwo.CheckedChanged += new System.EventHandler(this.SetPlayerTwoChoice);
            // 
            // rockRadioButtonTwo
            // 
            this.rockRadioButtonTwo.AutoSize = true;
            this.rockRadioButtonTwo.Location = new System.Drawing.Point(39, 305);
            this.rockRadioButtonTwo.Name = "rockRadioButtonTwo";
            this.rockRadioButtonTwo.Size = new System.Drawing.Size(130, 52);
            this.rockRadioButtonTwo.TabIndex = 4;
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
            this.winnerLabel.Location = new System.Drawing.Point(458, 289);
            this.winnerLabel.Name = "winnerLabel";
            this.winnerLabel.Size = new System.Drawing.Size(112, 48);
            this.winnerLabel.TabIndex = 8;
            this.winnerLabel.Text = "None";
            this.winnerLabel.Click += new System.EventHandler(this.winnerLabel_Click);
            // 
            // clearButton
            // 
            this.clearButton.Enabled = false;
            this.clearButton.Location = new System.Drawing.Point(434, 466);
            this.clearButton.Name = "clearButton";
            this.clearButton.Size = new System.Drawing.Size(173, 60);
            this.clearButton.TabIndex = 10;
            this.clearButton.Text = "Clear";
            this.clearButton.UseVisualStyleBackColor = true;
            this.clearButton.Click += new System.EventHandler(this.ClearChoices);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(445, 241);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(144, 48);
            this.label1.TabIndex = 11;
            this.label1.Text = "Winner";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(369, 125);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(286, 48);
            this.label2.TabIndex = 12;
            this.label2.Text = "Round Number";
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(439, 185);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(150, 34);
            this.progressBar1.TabIndex = 13;
            // 
            // restartButton
            // 
            this.restartButton.Location = new System.Drawing.Point(772, 605);
            this.restartButton.Name = "restartButton";
            this.restartButton.Size = new System.Drawing.Size(215, 57);
            this.restartButton.TabIndex = 14;
            this.restartButton.Text = "Restart";
            this.restartButton.UseCompatibleTextRendering = true;
            this.restartButton.UseVisualStyleBackColor = true;
            this.restartButton.Visible = false;
            this.restartButton.Click += new System.EventHandler(this.RestartGame);
            // 
            // GameForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(22F, 48F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1025, 683);
            this.Controls.Add(this.restartButton);
            this.Controls.Add(this.progressBar1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.clearButton);
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
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.RadioButton scissorsRadioButtonTwo;
        private System.Windows.Forms.RadioButton paperRadioButtonTwo;
        private System.Windows.Forms.RadioButton rockRadioButtonTwo;
        private System.Windows.Forms.Button playButton;
        private System.Windows.Forms.Label errorLabel;
        private System.Windows.Forms.Label winnerLabel;
        private System.Windows.Forms.Label scoreOneLabel;
        private System.Windows.Forms.Label scoreTwoLabel;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button clearButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.Button restartButton;
    }
}