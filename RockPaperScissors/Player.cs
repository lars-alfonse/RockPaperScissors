using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RockPaperScissors
{
    abstract class Player
    {
        protected int playerNumber;
        protected int playerSelection;
        protected int playerScore;
        protected string playerName;

        protected abstract void ChooseMove();
        protected void AddScore()
        {
            playerScore += 1;
        }
        protected void compareSelection(Player opponent)
        {
            int scoreComparison;
            scoreComparison = (5 + playerSelection + opponent.playerSelection) % 5;
            if (scoreComparison == 0)
            {
                Console.WriteLine("Tie Game");
            }
            else if(scoreComparison % 2 == 0)
            {
                Console.WriteLine($"{playerName} loses the round!");
            }
            else
            {
                Console.WriteLine($"{playerName} wins the round!");
                AddScore();
            }
        }
        protected bool CheckScore()
        {
            if (playerScore > 2)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
