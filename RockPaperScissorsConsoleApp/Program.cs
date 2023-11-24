using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RockPaperScissorsConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            int playerPoints = 0;
            int computerPoints = 0;

            List<string> computerOptions = new List<string>()
            { "r","p","s"};
            Random random = new Random();


            Console.Write("Welcome to Rock Paper Scissors game, please write how many points do you want to play to? ");
            string points = Console.ReadLine();

            if (int.TryParse(points, out int number))
            {
                while (true)
                {
                    Console.Write("Please choose your move: 'r' for rock, 'p' for paper or 's' for scissors: ");
                    string playerMove = Console.ReadLine();

                    if (playerMove != "r" || playerMove != "p" || playerMove != "s")
                    {
                        Console.WriteLine("Please enter correct letter to make a move.");
                    }

                    int computerOption = random.Next(computerOptions.Count);
                    string computerMove = computerOptions[computerOption];
                    if (playerMove == computerMove)
                    {
                        Console.WriteLine("It's a draw, please continue.");
                        Console.WriteLine("Current score for Player: " + playerPoints + "| Computer: " + computerPoints);

                    }
                    if (playerMove == "r" && computerMove == "s")
                    {
                        Console.WriteLine("You chose rock and your opponent chose scissors.");
                        Console.WriteLine("Congrats! you win this battle.");
                        playerPoints++;
                        Console.WriteLine("Current score for Player: " + playerPoints + "| Computer: " + computerPoints);    
                    }
                    if (playerMove == "r" && computerMove == "p")
                    {
                        Console.WriteLine("You chose rock and your opponent chose paper.");
                        Console.WriteLine("Sorry, you lost.");
                        computerPoints++;
                        Console.WriteLine("Current score for Player: " + playerPoints + "| Computer: " + computerPoints);

                    }
                    if (playerMove == "p" && computerMove == "r")
                    {
                        Console.WriteLine("You chose paper and your opponent chose rock.");
                        Console.WriteLine("Congrats! you win this battle.");
                        playerPoints++;
                        Console.WriteLine("Current score for Player: " + playerPoints + "| Computer: " + computerPoints);

                    }
                    if (playerMove == "p" && computerMove == "s")
                    {
                        Console.WriteLine("You chose paper and your opponent chose scissors.");
                        Console.WriteLine("Sorry, you lost.");
                        computerPoints++;
                        Console.WriteLine("Current score for Player: " + playerPoints + "| Computer: " + computerPoints);

                    }
                    if (playerMove == "s" && computerMove == "p")
                    {
                        Console.WriteLine("You chose scissors and your opponent chose paper.");
                        Console.WriteLine("Congrats! you win this battle.");
                        playerPoints++;
                        Console.WriteLine("Current score for Player: " + playerPoints + "| Computer: " + computerPoints);

                    }
                    if (playerMove == "s" && computerMove == "r")
                    {
                        Console.WriteLine("You chose scissors and your opponent chose rock.");
                        Console.WriteLine("Sorry, you lost.");
                        computerPoints++;
                        Console.WriteLine("Current score for Player: " + playerPoints + "| Computer: " + computerPoints);
                    }
                    if (playerPoints == number)
                    {
                        Console.WriteLine("You win the game.");
                        return;
                    }
                    if (computerPoints == number)
                    {
                        Console.WriteLine("Computer wins!");
                        return;
                    }
                }
            }
            else
            {
                Console.WriteLine("Please enter a number.");
            }

        }
    }
}
