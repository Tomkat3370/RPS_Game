using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace RPS_Game
{
    public partial class StartUpForm : Form
    {
        public StartUpForm()
        {
            InitializeComponent();
        }

        private void ChangeName(object sender, EventArgs e)
        {
            if (computerCheckBox.Checked)
            {
                playerTwoTextBox.Text = "Computer";
                playerTwoTextBox.ReadOnly = true;
            }
            else
            {
                playerTwoTextBox.Text = "";
                playerTwoTextBox.ReadOnly = false;
            }
        }

        private void ClickStartButton(object sender, EventArgs e)
        {
            if(startButton.Enabled)
            {
                GameController.StartGame();
            }    
        }
    }
}
