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

        protected abstract void ChooseMove();
    }
}
