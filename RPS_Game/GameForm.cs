﻿using System;
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
        private static Bitmap stone = Properties.Resources.Stone;
        private static Bitmap paper = Properties.Resources.Paper;
        private static Bitmap scissors = Properties.Resources.Scissors;


        public GameForm(GameController controller)
        {
            InitializeComponent();

            groupBoxOne.Text = controller.PlayerOneName;
            groupBoxTwo.Text = controller.PlayerTwoName;
            this.controller = controller;

            if (controller.VersusComputer)
            {
                rockRadioButtonTwo.Enabled = false;
                paperRadioButtonTwo.Enabled = false;
                scissorsRadioButtonTwo.Enabled = false;
            }


        }

        public void RunGame()
        {

        }

        private void SetPlayerOneChoice(object sender, EventArgs e)
        {
            if (rockRadioButtonOne.Checked)
            {
                controller.PlayerOneChoice = GameChoices.Rock;
                pictureBox1.Image = stone;
                paperRadioButtonOne.Enabled = false;
                scissorsRadioButtonOne.Enabled = false;
            }
            else if (paperRadioButtonOne.Checked)
            {
                controller.PlayerOneChoice = GameChoices.Paper;
                pictureBox1.Image = paper;
                rockRadioButtonOne.Enabled = false;
                scissorsRadioButtonOne.Enabled = false;
            }
            else if (scissorsRadioButtonOne.Checked)
            {
                controller.PlayerOneChoice = GameChoices.Scissors;
                pictureBox1.Image = scissors;
                paperRadioButtonOne.Enabled = false;
                scissorsRadioButtonOne.Enabled = false;
            }
        }

        private void SetPlayerTwoChoice(object sender, EventArgs e)
        {
            if (rockRadioButtonTwo.Checked)
            {
                controller.PlayerTwoChoice = GameChoices.Rock;
                pictureBox2.Image = stone;
                paperRadioButtonTwo.Enabled = false;
                scissorsRadioButtonTwo.Enabled = false;
            }
            else if (paperRadioButtonTwo.Checked)
            {
                controller.PlayerTwoChoice = GameChoices.Paper;
                pictureBox2.Image = paper;
                rockRadioButtonTwo.Enabled = false;
                scissorsRadioButtonTwo.Enabled = false;
            }
            else if (scissorsRadioButtonTwo.Checked)
            {
                controller.PlayerTwoChoice = GameChoices.Scissors;
                pictureBox2.Image = scissors;
                paperRadioButtonTwo.Enabled = false;
                rockRadioButtonTwo.Enabled = false;
            }

        }



        private void SelectPlayButton(object sender, EventArgs e)
        {
            if (controller.PlayerOneChoice != GameChoices.None
                && controller.VersusComputer == true)
            {
                controller.MakeComputerChoice();
                winnerLabel.Text = controller.WinnersName;
                scoreOneLabel.Text = controller.PlayerOneScore.ToString();
                scoreTwoLabel.Text = controller.PlayerTwoScore.ToString();
            }
            else if (controller.PlayerOneChoice != GameChoices.None
                && controller.PlayerTwoChoice != GameChoices.None)
            {
                controller.CalculateResult();

            }
            else
            {
                errorLabel.Text = "MAKE A CHOICE, THEN PRESS PLAY!!";
            }
        }

        private void DisplayWinner()
        {
            if (controller.WinnersName == "Computer")
            {
                winnerLabel.Text = "The Computer Has Won!";
            }
            else if (controller.WinnersName == controller.PlayerOneName)
            {
                winnerLabel.Text = $"Congratulations" +
                    $"{controller.PlayerOneName} You Win!";
            }
            else if (controller.WinnersName == controller.PlayerTwoName)
            {
                winnerLabel.Text = $"Congratulations " +
                    $"{controller.PlayerTwoName} You Win!";
            }
            else
                winnerLabel.Text = "Draw";
        }

        private void SetComputerChoice(object sender, EventArgs e)
        {


        }


        //Todo: Add "MakeComputerChoice" random generator
        //Todo: Add "Exit Game" Method
        //Todo: Add "End Round" and "End Game" methods
        //Todo: Add round number and current score to GameForm
    }

}
