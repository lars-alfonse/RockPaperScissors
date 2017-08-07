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
        public void AddScore()
        {
            playerScore += 1;
        }
    }
}
