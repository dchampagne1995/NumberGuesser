using System;

namespace NumberGuesser
{
    class Program
    {
        static void Main(string[] args)
        {

            //Initializing application vars
            String appName = "Number Guessing Application";
            String appVersion = "1.0.0";
            String creator = "Daniel Champagne";


            //Changing text colour when displaying app details
            Console.ForegroundColor = ConsoleColor.Cyan;

            Console.WriteLine("{0}: Version {1} Created By {2}",appName, appVersion, creator);

            //Resetting text colour
            Console.ResetColor();

            //Ask user's name and get input
            Console.WriteLine("What is your name?");
            String userName = Console.ReadLine();

            //Setting the random number
            Random random = new Random();
            int numberAnswer = random.Next(1,10);

            //Initializing user guess variable
            int userGuess = 0;

            Console.WriteLine("Hello {0}, Choose a number between 1 and 10", userName);

            //Getting user input and converting to int
            String stringUserGuess = Console.ReadLine();
            userGuess = Int32.Parse(stringUserGuess);

            //Comparing user guess to correct number
            while(userGuess != numberAnswer)
            {
                //Re asking for user input and converting again
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Wrong number guess again!");
                stringUserGuess = Console.ReadLine();
                userGuess = Int32.Parse(stringUserGuess);
                Console.ResetColor();

            }

            Console.WriteLine("Congratulations you guessed the number! {0} ", userGuess);

        }
    }
}
