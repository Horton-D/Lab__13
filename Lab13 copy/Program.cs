using System;

namespace Lab13
{
    class Program
    {
        static void Main(string[] args)
        {
            string tryAgain;



            Console.WriteLine("Welcome to Rock Paper Scissors!");
            Console.WriteLine("Please enter your name");
            var name = Console.ReadLine();

            Console.WriteLine("Would you like to play against The Jets or TheSharks(j / s) ?: ");
            var choice = Console.ReadLine();
            var team = choice == "j" ? "The Jets" : "The Sharks";
            var cpuTeam = team == "The Jets" ? "The Sharks" : "The Jets";
           
            do
            {

                Console.Write("Rock, Paper or Scissors: ");
                var pick = Console.ReadLine();
                if (!Selection(pick)) Console.WriteLine("Invalid selection, try again");
                IPlayer cpu = new RandomPlayer("Jeff");
                IPlayer player = new HumanPlayer(name, pick);
              
              
                switch (pick)
                {
                    case "r":
                        
                        Console.WriteLine($"{team} :{player.GenerateRPS()}");
                        Console.WriteLine($"{cpuTeam} {cpu.GenerateRPS()}");
                        break;

                    case "p":
                        Console.WriteLine($"{team} :{player.GenerateRPS()}");
                        Console.WriteLine($"{cpuTeam} {cpu.GenerateRPS()}");
                        break;

                    case "s":
                        Console.WriteLine($"{team} :{player.GenerateRPS()}");
                        Console.WriteLine($"{cpuTeam} {cpu.GenerateRPS()}");
                        break;

                    default:
                        break;
                }



                Console.WriteLine("Play again ? (y / n) :");
                tryAgain = Console.ReadLine();
            } while (!tryAgain.Equals("n", StringComparison.OrdinalIgnoreCase));
        }

        private static bool Selection(string choice)
        {
            if (choice != "r" && choice != "p" && choice != "s")
            {
                return false;
            }
            return true;
        }

       




    }

   
}
