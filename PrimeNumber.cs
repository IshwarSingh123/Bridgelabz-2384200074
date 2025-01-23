//Write a Program to check if the given number is a prime number or not

using System;

class PrimeNumber
{
    static void Main(string[] args)
    {
        // Prompt the user to enter a number
        Console.Write("Enter a number: ");
        int number = Convert.ToInt32(Console.ReadLine());

        // Check if the number is less than or equal to 1
        if (number <= 1)
        {
            Console.WriteLine("Number should be greater than zero.");
        }
        else
        {
            // Initialize a flag to check if the number is prime
            bool isPrime = true;

            // Loop to check for factors from 2 to number - 1
            for (int i = 2; i < number; i++)
            {
                if (number % i == 0)
                {
                    // If the number is divisible by any i, it is not prime
                    isPrime = false;
                    break; // Exit the loop as we found a divisor
                }
            }

            // Output the result based on the isPrime flag
            if (isPrime)
            {
                Console.WriteLine(number + " is a prime number.");
            }
            else
            {
                Console.WriteLine(number + " is not a prime number.");
            }
        }
    }
}

