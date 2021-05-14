
namespace RPS_Game
{
    partial class StartUpForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(StartUpForm));
            this.startButton = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.playerOneTextBox = new System.Windows.Forms.TextBox();
            this.playerOneLabel = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.computerCheckBox = new System.Windows.Forms.CheckBox();
            this.playerTwoTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.roundsGroupBox = new System.Windows.Forms.GroupBox();
            this.roundsNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.errorLabel = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.roundsGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.roundsNumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // startButton
            // 
            this.startButton.BackColor = System.Drawing.Color.DodgerBlue;
            this.startButton.Location = new System.Drawing.Point(828, 549);
            this.startButton.Name = "startButton";
            this.startButton.Size = new System.Drawing.Size(124, 87);
            this.startButton.TabIndex = 0;
            this.startButton.Text = "Start";
            this.startButton.UseVisualStyleBackColor = false;
            this.startButton.Click += new System.EventHandler(this.StartGame);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.DodgerBlue;
            this.groupBox1.Controls.Add(this.playerOneTextBox);
            this.groupBox1.Controls.Add(this.playerOneLabel);
            this.groupBox1.Location = new System.Drawing.Point(43, 217);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(483, 143);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Player One:";
            // 
            // playerOneTextBox
            // 
            this.playerOneTextBox.Location = new System.Drawing.Point(149, 69);
            this.playerOneTextBox.Name = "playerOneTextBox";
            this.playerOneTextBox.Size = new System.Drawing.Size(480, 60);
            this.playerOneTextBox.TabIndex = 4;
           
            // 
            // playerOneLabel
            // 
            this.playerOneLabel.AutoSize = true;
            this.playerOneLabel.Location = new System.Drawing.Point(6, 77);
            this.playerOneLabel.Name = "playerOneLabel";
            this.playerOneLabel.Size = new System.Drawing.Size(148, 51);
            this.playerOneLabel.TabIndex = 3;
            this.playerOneLabel.Text = "Name:";
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.DodgerBlue;
            this.groupBox2.Controls.Add(this.computerCheckBox);
            this.groupBox2.Controls.Add(this.playerTwoTextBox);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Location = new System.Drawing.Point(43, 417);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(483, 219);
            this.groupBox2.TabIndex = 4;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Player Two:";
            // 
            // computerCheckBox
            // 
            this.computerCheckBox.AutoSize = true;
            this.computerCheckBox.Location = new System.Drawing.Point(149, 147);
            this.computerCheckBox.Name = "computerCheckBox";
            this.computerCheckBox.Size = new System.Drawing.Size(275, 56);
            this.computerCheckBox.TabIndex = 5;
            this.computerCheckBox.Text = "is Computer";
            this.computerCheckBox.UseVisualStyleBackColor = true;
            this.computerCheckBox.CheckedChanged += new System.EventHandler(this.ChangeName);
            // 
            // playerTwoTextBox
            // 
            this.playerTwoTextBox.Location = new System.Drawing.Point(149, 69);
            this.playerTwoTextBox.Name = "playerTwoTextBox";
            this.playerTwoTextBox.Size = new System.Drawing.Size(480, 60);
            this.playerTwoTextBox.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 77);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(148, 51);
            this.label1.TabIndex = 3;
            this.label1.Text = "Name:";
            // 
            // roundsGroupBox
            // 
            this.roundsGroupBox.BackColor = System.Drawing.Color.DodgerBlue;
            this.roundsGroupBox.Controls.Add(this.roundsNumericUpDown);
            this.roundsGroupBox.Location = new System.Drawing.Point(688, 217);
            this.roundsGroupBox.Name = "roundsGroupBox";
            this.roundsGroupBox.Size = new System.Drawing.Size(263, 85);
            this.roundsGroupBox.TabIndex = 5;
            this.roundsGroupBox.TabStop = false;
            this.roundsGroupBox.Text = "Rounds:";
            // 
            // roundsNumericUpDown
            // 
            this.roundsNumericUpDown.Location = new System.Drawing.Point(179, 11);
            this.roundsNumericUpDown.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.roundsNumericUpDown.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.roundsNumericUpDown.Name = "roundsNumericUpDown";
            this.roundsNumericUpDown.Size = new System.Drawing.Size(98, 48);
            this.roundsNumericUpDown.TabIndex = 0;
            this.roundsNumericUpDown.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.roundsNumericUpDown.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.Color.Khaki;
            this.textBox1.Font = new System.Drawing.Font("Tahoma", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textBox1.ForeColor = System.Drawing.Color.Maroon;
            this.textBox1.Location = new System.Drawing.Point(33, 29);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(935, 104);
            this.textBox1.TabIndex = 6;
            this.textBox1.Text = "Rock, Paper, Scissors!";
            this.textBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.Location = new System.Drawing.Point(695, 320);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(257, 222);
            this.pictureBox1.TabIndex = 7;
            this.pictureBox1.TabStop = false;
            // 
            // errorLabel
            // 
            this.errorLabel.AutoSize = true;
            this.errorLabel.BackColor = System.Drawing.Color.Black;
            this.errorLabel.ForeColor = System.Drawing.Color.Red;
            this.errorLabel.Location = new System.Drawing.Point(600, 577);
            this.errorLabel.Name = "errorLabel";
            this.errorLabel.Size = new System.Drawing.Size(0, 41);
            this.errorLabel.TabIndex = 8;
            // 
            // StartUpForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(18F, 40F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MediumSpringGreen;
            this.ClientSize = new System.Drawing.Size(1227, 844);
            this.Controls.Add(this.errorLabel);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.roundsGroupBox);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.startButton);
            this.Controls.Add(this.pictureBox1);
            this.Font = new System.Drawing.Font("Tahoma", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Name = "StartUpForm";
            this.Text = "StartUpForm";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.roundsGroupBox.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.roundsNumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button startButton;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox playerOneTextBox;
        private System.Windows.Forms.Label playerOneLabel;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.CheckBox computerCheckBox;
        private System.Windows.Forms.TextBox playerTwoTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox roundsGroupBox;
        private System.Windows.Forms.NumericUpDown roundsNumericUpDown;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label errorLabel;
    }
}