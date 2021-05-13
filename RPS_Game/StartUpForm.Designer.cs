
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
            this.startButton = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.playerOneNameTextBox = new System.Windows.Forms.TextBox();
            this.playerOneLabel = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.computerCheckBox = new System.Windows.Forms.CheckBox();
            this.playerTwoTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
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
            var gameForm = new GameForm();
            gameForm.Show();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.playerOneNameTextBox);
            this.groupBox1.Controls.Add(this.playerOneLabel);
            this.groupBox1.Location = new System.Drawing.Point(43, 61);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(483, 143);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Player One:";
            // 
            // playerOneNameTextBox
            // 
            this.playerOneNameTextBox.Location = new System.Drawing.Point(149, 69);
            this.playerOneNameTextBox.Name = "playerOneNameTextBox";
            this.playerOneNameTextBox.Size = new System.Drawing.Size(307, 56);
            this.playerOneNameTextBox.TabIndex = 4;
            // 
            // playerOneLabel
            // 
            this.playerOneLabel.AutoSize = true;
            this.playerOneLabel.Location = new System.Drawing.Point(6, 77);
            this.playerOneLabel.Name = "playerOneLabel";
            this.playerOneLabel.Size = new System.Drawing.Size(137, 48);
            this.playerOneLabel.TabIndex = 3;
            this.playerOneLabel.Text = "Name:";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.computerCheckBox);
            this.groupBox2.Controls.Add(this.playerTwoTextBox);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Location = new System.Drawing.Point(43, 234);
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
            this.computerCheckBox.Size = new System.Drawing.Size(258, 52);
            this.computerCheckBox.TabIndex = 5;
            this.computerCheckBox.Text = "is Computer";
            this.computerCheckBox.UseVisualStyleBackColor = true;
            this.computerCheckBox.CheckedChanged += new System.EventHandler(this.ChangeName);
            // 
            // playerTwoTextBox
            // 
            this.playerTwoTextBox.Location = new System.Drawing.Point(149, 69);
            this.playerTwoTextBox.Name = "playerTwoTextBox";
            this.playerTwoTextBox.Size = new System.Drawing.Size(307, 56);
            this.playerTwoTextBox.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 77);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(137, 48);
            this.label1.TabIndex = 3;
            this.label1.Text = "Name:";
            // 
            // StartUpForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(22F, 48F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(980, 674);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.startButton);
            this.Font = new System.Drawing.Font("Tahoma", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Name = "StartUpForm";
            this.Text = "StartUpForm";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button startButton;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox playerOneNameTextBox;
        private System.Windows.Forms.Label playerOneLabel;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.CheckBox computerCheckBox;
        private System.Windows.Forms.TextBox playerTwoTextBox;
        private System.Windows.Forms.Label label1;
    }
}