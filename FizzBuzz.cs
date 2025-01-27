using System;

class FizzBuzz
{
    static void Main(string[] args)
    {
        // Take user input for the number
        Console.Write("Enter a positive integer: ");
        int number = int.Parse(Console.ReadLine());

        // Check if the number is positive
        if (number <= 0)
        {
            Console.WriteLine("Please enter a positive integer.");
            return;
        }

        // Create a string array to store the results
        string[] results = new string[number + 1];

        // Loop from 1 to the given number and apply FizzBuzz logic
        for (int i = 1; i <= number; i++)
        {
            if (i % 3 == 0 && i % 5 == 0)
                results[i] = "FizzBuzz";
            else if (i % 3 == 0)
                results[i] = "Fizz";
            else if (i % 5 == 0)
                results[i] = "Buzz";
            else
                results[i] = i.ToString();
        }

        // Loop again to show the results with index positions
        for (int i = 1; i <= number; i++)
        {
            Console.WriteLine("Position " + i + " = " + results[i]);

        }
    }
}
