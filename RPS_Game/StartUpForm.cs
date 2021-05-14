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
        public const string ComputerName = "Computer";

        private GameForm gameForm;
        private GameController gameController;

        public StartUpForm()
        {
            InitializeComponent();
            gameController = new GameController();
            
            
        }

        private void ChangeName(object sender, EventArgs e)
        {
            if (computerCheckBox.Checked)
            {
                playerTwoTextBox.Text = ComputerName;
                playerTwoTextBox.ReadOnly = true;
            }
            else
            {
                playerTwoTextBox.Text = "";
                playerTwoTextBox.ReadOnly = false;
            }
        }

        private void StartGame(object sender, EventArgs e)
        {
            

            if (playerOneTextBox.Text.Length >= 3 && 
                playerTwoTextBox.Text.Length >=3)
            {
                gameController.PlayerOneName = playerOneTextBox.Text;
                gameController.PlayerTwoName = playerTwoTextBox.Text;

                if (gameController.PlayerTwoName == ComputerName)
                {
                    gameController.VersusComputer = true;
                }
                else gameController.VersusComputer = false;

                gameController.Rounds = (int)roundsNumericUpDown.Value;

                gameForm = new GameForm(gameController);
                gameForm.Show();
                this.Close();
            }
            else
            {
                errorLabel.Text = "Please Enter Your Name";
            }
           
        }
    }
}
