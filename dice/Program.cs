using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dice
{
    class Program
    {
        static void Main(string[] args)
        {
            int playerRandomNumber;
            int enemyRandomNumber;

            int playerPoints = 0;
            int enemyPoints = 0;

            Random random = new Random();

            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine("Press any key to roll the dice.");

                Console.ReadKey();

                playerRandomNumber = random.Next(1, 7);
                Console.WriteLine("You rolled a " + playerRandomNumber);

                Console.WriteLine("...");
                System.Threading.Thread.Sleep(1000);

                enemyRandomNumber = random.Next(1, 7);
                Console.WriteLine("Enemy AI rolled a " + enemyRandomNumber);

                if(playerRandomNumber > enemyRandomNumber)
                {
                    playerPoints++;
                    Console.WriteLine("Player wins this round!");
                }
                else if(playerRandomNumber < enemyRandomNumber)
                {
                    enemyPoints++;
                    Console.WriteLine("Enemy wins this round!");
                }
                else
                {
                    Console.WriteLine("Draw!");
                }

                Console.WriteLine("The score is now - Player : " + playerPoints + ". Enemy : " + enemyPoints + ".");
                Console.WriteLine();
            }

            if(playerPoints > enemyPoints)
            {
                Console.WriteLine("You win!");
            }
            else if(playerPoints < enemyPoints)
            {
                Console.WriteLine("You lose!");
            }
            else 
            {
                Console.WriteLine("It's a draw!");
            }

            Console.ReadKey();

        }
    }
}
