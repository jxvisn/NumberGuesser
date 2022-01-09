using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NumberGuesser
{
    class Program
    {
        // Entry Point
        static void Main(string[] args)
        {

            //DisplayAppInfo
            var title = "Number Guesser";
            var version = "1.0.0";
            var author = "John Doe";

            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("{0} {1} by {2}", title, version, author);
            Console.ResetColor();
            //GreetUser
            Console.WriteLine("What is your name?");
            var userName = Console.ReadLine();
            Console.WriteLine("Good day {0}! Let's play a game...", userName);
            //PlayGame
            while (true)
            {
                Console.WriteLine("Pick a number between 1 and 10");

                var random = new Random();
                var correctNumber = random.Next(1, 10);
                var guess = 0;

                while (correctNumber != guess)
                {
                    //Get user input
                    var input = Console.ReadLine();
                    //Verify user input
                    if (!int.TryParse(input, out guess))
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("Please enter a number");
                        Console.ResetColor();
                    }

                    guess = Int32.Parse(input);

                    if (correctNumber != guess)
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("Wrong number, try again");
                        Console.ResetColor();
                    }

                }
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("Correct!!! You guessed right");
                Console.ResetColor();
                //Repeat game?
                Console.WriteLine("Play again? [Y] or [N]");
                var answer = Console.ReadLine().ToUpper();

                if(answer == "Y")
                {

                    continue;

                } else if(answer == "N")
                {

                    return;

                } else
                {

                    return;

                }

            }


        }
    }
}
