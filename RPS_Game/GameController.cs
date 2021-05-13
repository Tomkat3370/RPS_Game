using System;
using System.Collections.Generic;
using System.Text;

namespace RPS_Game
{
    public enum GameChoices
    {
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
        public int Rounds { get; set; }
        public int PlayerOneScore { get; set; }
        public int PlayerTwoScore { get; set; }
        public string WinnersName { get; set; }
        public int CurrentRound { get; set; }

        public GameChoices PlayerOneChoice { get; set; }
        public GameChoices PlayerTwoChoices { get; set; }

        private static 
        

        /// <summary>
        /// StartGame asks for the players name and how many
        /// rounds of rock, paper, scissors they want to play.
        /// </summary>
        public void StartGame()
        {
            
        }

        public void MakeChoice()
        {

        }

        public void MakeComputerChoice()
        {

        }

        public void CalculateResult()
        {

        }
    }
}
