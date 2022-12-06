using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace SnakeAndLadderProblem
{
    internal class GamePlayStart
    {
        public static void Start()
        {
            int startGamePosition = 0;
            Console.WriteLine(" Lets play");
            Console.WriteLine("You are at player position  "+ startGamePosition);
            Console.WriteLine("Lets rolls the Die");
        }
        public static void RollsTheDie()
        {
            Random random = new Random();
            int dice = random.Next(1,7);
            Console.WriteLine("Result of Dice" + "\n" + dice);
        }

    }
}
