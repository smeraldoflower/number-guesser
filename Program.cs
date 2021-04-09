using System;

// Namespace
namespace NumberGuesser
{
   // Main Class
   class Program
    {
        // Entry Point Method
        static void Main(string[] args)
        {
            // Run GetAppInfo function
            GetAppInfo();

            // Ask for user's name and greet
            GreetUser();

            while (true)
            {


                // Create a new random object
                Random random = new Random();

                // Init correct number
                int correctNumber = random.Next(1, 101);

                // Init guess var
                int guess = 0;

                // Count var for attempts
                int tries = 0;

                // Ask user for number
                PrintColorMessage(ConsoleColor.Magenta, "Guess a number between 1 and 100");

                // While guess is incorrect
                while (guess != correctNumber)
                {
                    // Get user input
                    string input = Console.ReadLine();

                    // User input validation
                    if (!int.TryParse(input, out guess))
                    {
                        // Print error message
                        PrintColorMessage(ConsoleColor.Red, "Invalid number input! Please enter a number...");

                        // Keep Going
                        continue;
                    }

                    // Cast to int and put in guess variable
                    guess = Int32.Parse(input);

                    // Match guess to correct number
                    if (guess != correctNumber)
                    {
                       tries++;
                       // Print Error message
                       PrintColorMessage(ConsoleColor.Red, "WRONG Number, please try again!");
                       if(guess > correctNumber)
                       {
                           PrintColorMessage(ConsoleColor.Yellow, "Guess LOWER");
                       }
                       if (guess < correctNumber)
                       {
                           PrintColorMessage(ConsoleColor.Yellow, "Guess HIGHER");
                       }
                    }
                }

                // Output success message
                PrintColorMessage(ConsoleColor.Green, "You are CORRECT!");
                PrintColorMessage(ConsoleColor.Green, "Number of guesses: "+tries.ToString());

                // Ask to play again
                Console.WriteLine("Play Again? [Y or N]");

                // Get Answer
                string ans = Console.ReadLine().ToUpper();

                if (ans == "Y")
                {
                    continue;
                }
                else if (ans == "N")
                {
                    return;
                }
                else
                {
                    return;
                }
            }
        }

        // Get and display app info
        static void GetAppInfo()
        {
            // Set app vars
            string appName = "Number Guesser";
            string appVersion = "1.1.0";
            string appAuthor = "Nusaiba Mahmood";

            // Change text color
            Console.ForegroundColor = ConsoleColor.Cyan;

            // Write out app info
            Console.WriteLine("{0}: Version {1} by {2}", appName, appVersion, appAuthor);

            // Reset text color
            Console.ResetColor();
        }

        // Ask user's name and greet
        static void GreetUser()
        {
            // Ask user's name
            PrintColorMessage(ConsoleColor.Magenta, "What is your name?");

            // Get user input
            string inputName = Console.ReadLine();

            Console.ForegroundColor = ConsoleColor.Magenta;
            Console.WriteLine("Hello {0}, let's play a game!", inputName);
            Console.ResetColor();
        }

        // Print color message
        static void PrintColorMessage(ConsoleColor color, string message)
        {
            // Change text color
            Console.ForegroundColor = color;

            // Tell user guess is incorrect
            Console.WriteLine(message);

            // Reset text color
            Console.ResetColor();
        }
    }
}
