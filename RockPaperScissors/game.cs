using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RockPaperScissors
{
    class Game
    {
        public int numberOfHumanPlayers;
        public int scoreLimit;

        public Game()
        {
            GetHumanPlayers();
            GetScoreLimit();
        }

        private void GetHumanPlayers()
        {
            Console.WriteLine("How many human people will be playing? (1 or 2)");
            numberOfHumanPlayers = int.Parse(Console.ReadLine());
            if(numberOfHumanPlayers == 1 || numberOfHumanPlayers == 2)
            {
                Console.WriteLine($"There will be {numberOfHumanPlayers} humans playing");
            }
            else
            {
                Console.WriteLine("please select 1 or 2 players");
                GetHumanPlayers();
            }
        }
        private void GetScoreLimit()
        {
            int gameNumberChoice;
            Console.WriteLine("Please Select Number of Games: (Best out of...)");
            gameNumberChoice = int.Parse(Console.ReadLine());
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
        private void compareSelection(Player playerOne, Player playerTwo)
        {
            int scoreComparison;
            scoreComparison = (5 + playerOne.playerSelection + playerTwo.playerSelection) % 5;
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
        private bool CheckScore(Player playerOne, Player playerTwo)
        {
            if (playerOne.playerScore > 2)
            {
                Console.WriteLine($"{playerOne.playerName} Wins The Game!!!");
                return true;
            }
            else if (playerTwo.playerScore > 2)
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
    }
}
