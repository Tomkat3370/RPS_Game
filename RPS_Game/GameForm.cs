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

        private void CloseForm(object sender, EventArgs e)
        {
            Close();
        }

        private void SetPlayerOneChoice(object sender, EventArgs e)
        {
            if (rockRadioButtonOne.Checked)
                controller.PlayerOneChoice = GameChoices.Rock;
            else if (paperRadioButtonOne.Checked)
                controller.PlayerOneChoice = GameChoices.Paper;
            else if (scissorsRadioButtonOne.Checked)
                controller.PlayerOneChoice = GameChoices.Scissors;


        }

        private void SetPlayerTwoChoice(object sender, EventArgs e)
        {
            if (rockRadioButtonTwo.Checked)
                controller.PlayerTwoChoice = GameChoices.Rock;
            else if (paperRadioButtonTwo.Checked)
                controller.PlayerTwoChoice = GameChoices.Paper;
            else if (scissorsRadioButtonTwo.Checked)
                controller.PlayerTwoChoice = GameChoices.Scissors;
        }
    }
}
