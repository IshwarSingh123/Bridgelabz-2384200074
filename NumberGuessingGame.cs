using System;

class NumberGuessingGame
{
    public static void PlayGame()
    {
        int lowerBound = 1, upperBound = 100;
        int guess;
        string feedback;
        
        Console.WriteLine("Think of a number between 1 and 100.");
        Console.WriteLine("I will try to guess it. Respond with 'high', 'low', or 'correct'.");

        while (true)
        {
            guess = (lowerBound + upperBound) / 2;
            Console.WriteLine("Is your number " + guess + "?");
            
            feedback = GetUserFeedback();

            if (feedback == "correct")
            {
                Console.WriteLine("Yay! I guessed your number.");
                break;
            }
            else if (feedback == "high")
            {
                upperBound = guess - 1;
            }
            else if (feedback == "low")
            {
                lowerBound = guess + 1;
            }

            if (lowerBound > upperBound)
            {
                Console.WriteLine("Something went wrong. Are you sure you responded correctly?");
                break;
            }
        }
    }

    public static string GetUserFeedback()
    {
        string response;
        while (true)
        {
            response = Console.ReadLine().Trim().ToLower();
            if (response == "high" || response == "low" || response == "correct")
            {
                return response;
            }
            Console.WriteLine("Invalid input. Please enter 'high', 'low', or 'correct'.");
        }
    }

    public static void Main()
    {
        PlayGame();
    }
}
