using Microsoft.VisualBasic.FileIO;
using System;
namespace SnakeAndLadderProblem
{
    public class Program
    {
        public static void Main(string[] args)
        {

            Console.WriteLine("****Welcome To Snake and Ladder Problem****");

            {
                Console.WriteLine("Welcome to Snake and Ladder Problem Statement");
                GamePlayStart playe = new GamePlayStart();
                playe.Position();
                GamePlayStart dice = new GamePlayStart();
                dice.RollsTheDie();
                GamePlayStart check = new GamePlayStart();
                check.CheckOption();


            }

        }
    }
}


