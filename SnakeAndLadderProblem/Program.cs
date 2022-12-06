using Microsoft.VisualBasic.FileIO;
using System;
 namespace SnakeAndLadderProblem
{
    public class Program
    {
        public static void Main(string[] args)
        {
            while (true)
            {
                Console.WriteLine("****Welcome To Snake and Ladder Problem****");
                Console.WriteLine("Please Select below options"+"\n"+ "1.GamePlayStart");
                int option = Convert.ToInt32(Console.ReadLine());
                switch (option)
                {
                    case 1:
                    GamePlayStart.Start();
                    break;
                }
            }
        }
    }
}