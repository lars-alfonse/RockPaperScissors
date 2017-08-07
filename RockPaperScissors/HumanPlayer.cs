using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RockPaperScissors
{
    class Human : Player
    {
        public Human(int playerNumber) : base(playerNumber)
        {
            playerNameSelect();
        }
        public override void ChooseMove()
        {
            try
            {
                Console.WriteLine($"{playerName} would you like to pick: \nFor Rock press 0 \nFor Paper press 1 \nFor Scissors press 2 \nFor Spock press 3 \nFor Lizard press 4");
                playerSelection = int.Parse(Console.ReadLine());
            }
            catch (FormatException)
            {
                Console.WriteLine("please enter an integer number");
                ChooseMove();
                return;
            }
            if (playerSelection != 0 && playerSelection != 1 && playerSelection != 2 && playerSelection != 3 && playerSelection != 4)
            {
                Console.WriteLine($"{playerSelection} is not a appropriate choice");
                ChooseMove();
            }
        }
        private void playerNameSelect()
        {
          
            Console.WriteLine($"Player {playerNumber} please enter your name");
            playerName = Console.ReadLine();

        }
    }
}
