using System;

class OddEvenPositiveNegative
{
    // Method to check if a number is positive or negative
    public static bool IsPositive(int number)
    {
        return number >= 0;
    }

    // Method to check if a number is even or odd
    public static bool IsEven(int number)
    {
        return number % 2 == 0;
    }

    // Method to compare two numbers
    public static int Compare(int number1, int number2)
    {
        if (number1 > number2)
            return 1;
        else if (number1 == number2)
            return 0;
        else
            return -1;
    }

    public static void Main()
    {
        int[] numbers = new int[5];

        // Taking input for 5 numbers
        for (int i = 0; i < numbers.Length; i++)
        {
            Console.WriteLine("Enter number " + (i + 1) + ": ");
            numbers[i] = Convert.ToInt32(Console.ReadLine());
        }

        Console.WriteLine("Analysis:");
        // Loop through the array to check each number
        for (int i = 0; i < numbers.Length; i++)
        {
            if (IsPositive(numbers[i]))
            {
                Console.Write("Number " + numbers[i] + " is positive and ");
                if (IsEven(numbers[i]))
                    Console.WriteLine("even.");
                else
                    Console.WriteLine("odd.");
            }
            else
            {
                Console.WriteLine("Number " + numbers[i] + " is negative.");
            }
        }

        // Compare the first and last elements of the array
        int comparisonResult = Compare(numbers[0], numbers[numbers.Length - 1]);

        Console.WriteLine("\nComparison of the first and last numbers:");
        if (comparisonResult == 1)
            Console.WriteLine("The first number (" + numbers[0] + ") is greater than the last number " + numbers[numbers.Length - 1]);
        else if (comparisonResult == 0)
            Console.WriteLine("The first number (" + numbers[0] + ") is equal to the last number " + numbers[numbers.Length - 1]);
        else
            Console.WriteLine("The first number (" + numbers[0] + ") is less than the last number " + numbers[numbers.Length - 1]);
    }
}
