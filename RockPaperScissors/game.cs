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

        public Game()
        {
            numberOfHumanPlayers = GetHumanPlayers();
        }
        protected void compareSelection(Player playerOne, Player playerTwo)
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
        protected bool CheckScore(Player playerOne, Player playerTwo)
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
    }
}
