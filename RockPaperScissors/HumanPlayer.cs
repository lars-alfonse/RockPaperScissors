using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RockPaperScissors
{
    class Human : Player
    {
        public Human(int playerNumber)
        {
            playerScore = 0;
            this.playerNumber = playerNumber;
            playerName = playerNameSelect();
        }
        protected override void ChooseMove()
        {
            Console.WriteLine($"{playerName} would you like to pick: \nFor Rock press 0 \nFor Paper press 1 \nFor Scissors press 2 \n For Spock press 3 \nFor Lizard press 4");
            playerSelection = int.Parse(Console.ReadLine());
        }
        private string playerNameSelect()
        {
          
            Console.WriteLine($"Player {playerNumber} please enter your name");
            return Console.ReadLine();

        }
    }
}
