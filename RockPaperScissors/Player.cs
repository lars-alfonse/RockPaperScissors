using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RockPaperScissors
{
    abstract class Player
    {
        public int playerNumber;
        public int playerSelection;
        public int playerScore;
        public string playerName;

        public Player(int playerNumber)
        {
            playerScore = 0;
            this.playerNumber = playerNumber;

        }
        public abstract void ChooseMove();
        public void AddScore()
        {
            playerScore += 1;
        }
       
    }
}
