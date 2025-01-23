//program FizzBuzz, take a number as user input, and if it is a positive integer loop from 0 to the number and print the number, but for multiples of 3 print "Fizz" instead of the number, for multiples of 5 print "Buzz", and for multiples of both print "FizzBuzz".



using System;

class FizzBuzz
{
    static void Main(string[] args)
    {
        // Prompt the user to enter a positive integer
        Console.Write("Enter a positive integer: ");
        int number = Convert.ToInt32(Console.ReadLine());

        // Check if the input number is positive
        if (number > 0)
        {
            // Loop from 1 to the entered number
            for (int i = 1; i <= number; i++)
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
            }
        }
        else
        {
            // Handle invalid input
            Console.WriteLine("Please enter a positive integer.");
        }
    }
}

