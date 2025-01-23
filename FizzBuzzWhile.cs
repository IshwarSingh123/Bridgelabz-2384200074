//FizzBuzz using while loop


using System;

class FizzBuzzWhile
{
    static void Main(string[] args)
    {
        // Prompt the user to enter a positive integer
        Console.Write("Enter a positive integer: ");
        int number = Convert.ToInt32(Console.ReadLine());

        // Check if the input number is positive
        if (number > 0)
        {
            // Initialize counter variable
            int i = 1;

            // Loop using while from 1 to the entered number
            while (i <= number)
            {
                // Check divisibility by both 3 and 5
                if (i % 3 == 0 && i % 5 == 0)
                {
                    Console.WriteLine("FizzBuzz");
                }
                // Check divisibility by 3
                else if (i % 3 == 0)
                {
                    Console.WriteLine("Fizz");
                }
                // Check divisibility by 5
                else if (i % 5 == 0)
                {
                    Console.WriteLine("Buzz");
                }
                // Print the number if not divisible by 3 or 5
                else
                {
                    Console.WriteLine(i);
                }

                // Increment the counter variable
                i++;
            }
        }
        else
        {
            // Handle invalid input
            Console.WriteLine("Please enter a positive integer.");
        }
    }
}