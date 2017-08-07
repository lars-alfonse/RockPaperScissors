using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RockPaperScissors
{
    class Robot : Player
    {
        protected Random rnd = new Random();

        public Robot(int playerNumber)
        {
            playerScore = 0;
            this.playerNumber = playerNumber;
            playerName = $"Computer Player {playerNumber}";
        }
        protected override void ChooseMove()
        {
            Console.WriteLine($"{playerName} will now select their choice");
            playerSelection = rnd.Next(0, 5);
        }
    }
}
