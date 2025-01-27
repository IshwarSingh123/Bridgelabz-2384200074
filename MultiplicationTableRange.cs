using System;

class MultiplicationTableRange
{
    static void Main(string[] args)
    {
		//display message to the user and take input
        Console.WriteLine("Enter a number to generate its multiplication table from 6 to 9: ");
        int number = int.Parse(Console.ReadLine());

        int[] multiplicationResult = new int[4];//declare an array

        // Calculate the multiplication table for numbers 6 to 9
        for (int i = 6; i <= 9; i++)
        {
            multiplicationResult[i - 6] = number * i;//store the result in array
        }

        Console.WriteLine("Multiplication Table:");

        // Display the multiplication table
        for (int i = 6; i <= 9; i++)
        {
            Console.WriteLine(number + " * " + i + " = " + multiplicationResult[i - 6]);
        }
    }
}
