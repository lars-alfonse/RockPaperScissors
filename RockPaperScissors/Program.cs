using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RockPaperScissors
{
    class Program
    {
        static void Main(string[] args)
        {
            Game game = new Game();
            Human playerOne = new Human(1);
            if (game.numberOfHumanPlayers == 2)
            {
                Human playerTwo = new Human(2);
                game.StartGame(playerOne, playerTwo);
            }
            else
            {
                Robot playerTwo = new Robot(2);
                game.StartGame(playerOne, playerTwo);
            }
        }
    }
}
