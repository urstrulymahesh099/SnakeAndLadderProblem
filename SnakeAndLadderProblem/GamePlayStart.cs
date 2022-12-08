using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace SnakeAndLadderProblem
{
    public class GamePlayStart
    {
        Random random = new Random();
        int startGamePosition = 0;
        const int no_Paly = 0, ladder = 1, snake = 2, winning_Position = 100; int count =0;
           
        public void Position()
        {
            const int startGamePosition = 0;
            Console.WriteLine("Lets Play!!!" + "\n" + "You are at - " + startGamePosition);
        }
        public int RollsTheDie()
        {
            int startGamePosition = 0;
            int dice = random.Next(1, 7);
            Console.WriteLine("Output of Dice - " + dice);
            Console.WriteLine("You are at -",startGamePosition);
            count++;
            return dice;


        }
        public void CheckOption()
        {
            while (startGamePosition < winning_Position)

            {
                int rand = random.Next(0, 3);
                Console.WriteLine(rand);
                switch (rand)
                {
                    case no_Paly:
                       this.startGamePosition += 0;
                        break;
                    case ladder:
                        this.startGamePosition += RollsTheDie();
                        int die = RollsTheDie();
                        if (this.startGamePosition + die <= winning_Position)
                            this.startGamePosition += die;
                        break;
                    case snake:
                        this.startGamePosition -=RollsTheDie();
                        break;
                        {
                            this.startGamePosition = 0;
                        }
                        break;
                }
                Console.WriteLine(this.startGamePosition);
            }
            Console.WriteLine("Count of dice PLAYED " + count);
            Console.WriteLine("You won the GAME");
        }

    }
}
