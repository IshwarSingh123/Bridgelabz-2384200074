using System;

class PositiveNegativeZero
{
    static void Main(string[] args)
    {
        int[] numbers = new int[5];

        Console.WriteLine("Enter 5 numbers:");//message to show the user

        // Take user input and store it in an array
        for (int i = 0; i < numbers.Length; i++)
        {
            Console.WriteLine("Enter number " + (i + 1));
            numbers[i] = int.Parse(Console.ReadLine());
        }

        Console.WriteLine("Number Analysis:");

        // Loop through the array and analyze each number
        for (int i = 0; i < numbers.Length; i++)
        {
            if (numbers[i] > 0)//here for number is positive
            {
                if (numbers[i] % 2 == 0)//conditin for check no.is odd or even
                {
                    Console.WriteLine("The number " + numbers[i] + " is positive and even.");
                }
                else
                {
                    Console.WriteLine("The number " + numbers[i] + " is positive and odd.");
                }
            }
            else if (numbers[i] < 0)
            {
                Console.WriteLine("The number " + numbers[i] + " is negative.");
            }
            else
            {
                Console.WriteLine("The number is zero.");
            }
        }
	}
       
}