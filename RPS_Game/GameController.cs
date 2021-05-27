using System;
using System.Collections.Generic;
using System.Text;

namespace RPS_Game
{
    public enum GameChoices
    {
        None,
        Rock,
        Paper,
        Scissors

    }

    /// <summary>
    /// This will play a rock paper scissors game
    /// with one player vs. the compurter.
    /// The game form will do all user input and output.
    /// </summary>
    public class GameController
    {
        public string PlayerOneName { get; set; }
        public string PlayerTwoName { get; set; }
        public int PlayerOneScore { get; set; }
        public int PlayerTwoScore { get; set; }
        public string WinnersName { get; set; }
        public int CurrentRound { get; set; }

        public bool VersusComputer { get; set; }
        public Random random = new Random();
        private int choiceIndex;

        public GameChoices PlayerOneChoice { get; set; }
        public GameChoices PlayerTwoChoice { get; set; }
        public bool GameEnded { get; set; }
        public int LastRound { get; set; }

        private Random generator = new Random();

        /// <summary>
        /// StartGame asks for the players name and how many
        /// rounds of rock, paper, scissors they want to play.
        /// </summary>
        public void StartGame()
        {

        }

        public void DisplayCurrentRound()
        {

        }

        public void MakeChoice()
        {

        }

        public void MakeComputerChoice()
        {
            if (VersusComputer == true)
            {
                choiceIndex = generator.Next(1, 4);
                switch (choiceIndex)
                {
                    case 1: PlayerTwoChoice = GameChoices.Rock; break;
                    case 2: PlayerTwoChoice = GameChoices.Paper; break;
                    case 3: PlayerTwoChoice = GameChoices.Scissors; break;
                    default: PlayerTwoChoice = GameChoices.None; break;
                }
                CalculateResult();
            }
        }
        public void CalculateResult()
        {
            if (PlayerOneChoice == PlayerTwoChoice)
            {
                WinnersName = "None";
            }
            else
            {
                if ((PlayerOneChoice == GameChoices.Rock &&
                    PlayerTwoChoice == GameChoices.Paper) ||
                    (PlayerOneChoice == GameChoices.Paper &&
                    PlayerTwoChoice == GameChoices.Scissors) ||
                    (PlayerOneChoice == GameChoices.Scissors &&
                    PlayerTwoChoice == GameChoices.Rock))
                {
                    WinnersName = PlayerTwoName;
                    PlayerTwoScore++;
                }
                else if ((PlayerOneChoice == GameChoices.Rock &&
                    PlayerTwoChoice == GameChoices.Scissors) ||
                    (PlayerOneChoice == GameChoices.Paper &&
                    PlayerTwoChoice == GameChoices.Rock) ||
                    (PlayerOneChoice == GameChoices.Scissors &&
                    PlayerTwoChoice == GameChoices.Paper))
                {
                    WinnersName = PlayerOneName;
                    PlayerOneScore++;
                }
                
            }
        }

        public void EndGame()
        {
            if(PlayerTwoScore > PlayerOneScore)
            {
                WinnersName = PlayerTwoName;
            }
            else if(PlayerOneScore > PlayerTwoScore)
            {
                WinnersName = PlayerOneName;
            }
            else
            {
                WinnersName = "Draw!!";
            }
        }
    }
}
