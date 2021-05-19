using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace RPS_Game
{
    public partial class GameForm : Form
    {
        private GameController controller;
        private string rockFileName = "rock.jpg";
        private string paperFileName = "paper.jpg";
        private string scissorsFileName = "scissors.jpg";

        public GameForm(GameController controller)
        {
            InitializeComponent();

            groupBoxOne.Text = controller.PlayerOneName;
            groupBoxTwo.Text = controller.PlayerTwoName;
            this.controller = controller;

            if(controller.VersusComputer)
            {
                rockRadioButtonTwo.Enabled = false;
                paperRadioButtonTwo.Enabled = false;
                scissorsRadioButtonTwo.Enabled = false;
            }
        }

        public void RunGame()
        {

        }

        private void PlayChoiceOne(object sender, EventArgs e)
        {
            if (controller.PlayerOneChoice != GameChoices.None)
            {
                if (controller.VersusComputer)
                {
                    controller.MakeComputerChoice();
                    controller.CalculateResult();
                }
            }
        }

        private void SetPlayerOneChoice(object sender, EventArgs e)
        {
            if (rockRadioButtonOne.Checked)
            {
                controller.PlayerOneChoice = GameChoices.Rock;
                pictureBox1.Image = Image.FromFile("Images/Stone.jpg");
            }
            else if (paperRadioButtonOne.Checked)
            {
                controller.PlayerOneChoice = GameChoices.Paper;
                pictureBox1.Image = Image.FromFile("Images/paper.jpg");
            }
            else if (scissorsRadioButtonOne.Checked)
            {
                controller.PlayerOneChoice = GameChoices.Scissors;
                pictureBox1.Image = Image.FromFile("Images/scissors.jpg");
            }


        }

        private void SetPlayerTwoChoice(object sender, EventArgs e)
        {
            if (rockRadioButtonTwo.Checked)
            {
                controller.PlayerTwoChoice = GameChoices.Rock;
                pictureBox2.Image = Image.FromFile("Images/stone.jpg"); 
            }
            else if (paperRadioButtonTwo.Checked)
            {
                controller.PlayerTwoChoice = GameChoices.Paper;
                pictureBox2.Image = Image.FromFile("Images/paper");
            }
            else if (scissorsRadioButtonTwo.Checked)
            {
                controller.PlayerTwoChoice = GameChoices.Scissors;
                pictureBox2.Image = Image.FromFile("Images/scissors");
            }
        }
    }
}
