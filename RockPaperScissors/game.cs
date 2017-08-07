using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RockPaperScissors
{
    class Game
    {
        private Player playerOne;
        private Player playerTwo;
        public int numberOfHumanPlayers;
        public int scoreLimit;

        public Game()
        {
            GetHumanPlayers();
            GetScoreLimit();
        }

        private void GetHumanPlayers()
        {
            try
            {
                Console.WriteLine("How many human people will be playing? (1 or 2)");
                numberOfHumanPlayers = int.Parse(Console.ReadLine());
            }
            catch (FormatException)
            {
                Console.WriteLine("please enter an integer number");
                GetHumanPlayers();
                return;
            }
            if (numberOfHumanPlayers == 2)
            {
                playerOne = new Human(1);
                playerTwo = new Human(2);
            }
            else if (numberOfHumanPlayers == 1)
                {

                playerTwo = new Robot(2);
                playerOne = new Human(1);
                }
            else
            {
                Console.WriteLine("please select 1 or 2 players");
                GetHumanPlayers();
            }
        }
        private void GetScoreLimit()
        {
            int gameNumberChoice = 0;
            try
            {
                Console.WriteLine("Please Select Number of Games: (Best out of...)");
                gameNumberChoice = int.Parse(Console.ReadLine());
            }
            catch (FormatException)
            {
                Console.WriteLine("please enter an integer number");
                GetScoreLimit();
                return;
            }
            if (gameNumberChoice % 2 == 0)
            {
                Console.WriteLine("Please Select an odd number of games");
                GetScoreLimit();
            }
            else if (gameNumberChoice < 3)
            {
                Console.WriteLine("Minimum number of games is three");
                GetScoreLimit();
            }
            else
            {
                Console.WriteLine($"The Game will be Best out of {gameNumberChoice}");
                decimal dividedGameNumber = gameNumberChoice / 2; 
                scoreLimit = (int)Math.Ceiling(dividedGameNumber);
            }  

        }
        private void CompareSelection()
        {
            int scoreComparison;
            scoreComparison = (5 + playerOne.playerSelection - playerTwo.playerSelection) % 5;
            if (scoreComparison == 0)
            {
                Console.WriteLine("Tie Game");
            }
            else if (scoreComparison % 2 == 0)
            {
                Console.WriteLine($"{playerTwo.playerName} wins the round!");
                playerTwo.AddScore();
            }
            else
            {
                Console.WriteLine($"{playerOne.playerName} wins the round!");
                playerOne.AddScore();
            }
        }
        private bool CheckScore()
        {
            if (playerOne.playerScore > scoreLimit)
            {
                Console.WriteLine($"{playerOne.playerName} Wins The Game!!!");
                return true;
            }
            else if (playerTwo.playerScore > scoreLimit)
            {
                Console.WriteLine($"{playerTwo.playerName} Wins The Game!!!");
                return true;
            }
            else
            {
                return false;
            }
        }
        private void ClearBoard()
        {
            Console.Clear();
        }
        private void ReportScores()
        {
            Console.WriteLine($"{playerOne.playerName}'s score is {playerOne.playerScore} \n{playerTwo.playerName}'s score is {playerTwo.playerScore}\n");
        }
        public void StartGame()
        {
            bool GameOver = false;
            while (!GameOver)
            {
                playerOne.ChooseMove();
                ClearBoard();
                playerTwo.ChooseMove();
                ClearBoard();
                CompareSelection();
                ReportScores();
                GameOver = CheckScore();
            }
            Console.ReadLine();
        }
    }
}
