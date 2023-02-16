using System.Runtime.CompilerServices;

namespace dice.game.nethma._2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            {
                //Your Roll
                Console.WriteLine("Your Roll");
                Console.ReadKey();
                Random myRand = new Random();
                int Rand = myRand.Next(1, 7);
                Random myRand2 = new Random();
                int Rand2 = myRand2.Next(1, 7);
                Console.WriteLine("You rolled a " + Rand + " and a " + Rand2);
                int resut = (Rand) + (Rand2);
                Console.WriteLine("Total is " + resut);

                //Computer's Roll
                Console.WriteLine("Press any key...");
                Console.ReadKey();

                Console.WriteLine("");
                Console.WriteLine("Computer's Roll");
                Random myRand3 = new Random();
                int Rand3 = myRand.Next(1, 7);
                Random myRand4 = new Random();
                int Rand4 = myRand2.Next(1, 7);
                Console.WriteLine("Computer rolled a " + Rand3 + " and a " + Rand4);
                int resut2 = (Rand3) + (Rand4);
                Console.WriteLine("Total is " + resut2);
                Console.WriteLine("");

                //Results
                if (resut == resut2)
                {
                    Console.WriteLine("IT IS A DRAW! YOU BOTH WIN!");
                }
                else if (resut > resut2)
                {
                    Console.WriteLine("YOU WON :)");
                }
                else Console.WriteLine("YOU LOST :(");
                Console.WriteLine("");

                Console.WriteLine("Play again? Y or N");
                

                Console.WriteLine("");

                if (Console.ReadKey().Key == ConsoleKey.Y)

                {
                    Console.WriteLine("");
                    Main(null);
                }

                else if (Console.ReadKey().Key == ConsoleKey.N)

                {
                    Environment.Exit(0);
                }
                //else { Environment.Exit(0); }
                //Use a loop, and an if->else if->else statement instead,clear up,remove return, seperate the main function







            }

        }
    }
}