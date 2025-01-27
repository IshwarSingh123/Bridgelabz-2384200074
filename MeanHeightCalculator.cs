using System;

class MeanHeightCalculator
{
    static void Main(string[] args)
    {
        double[] heights = new double[11];
        double sum = 0.0;

        Console.WriteLine("Enter the heights of 11 players:");

        // Get input values from the user
        for (int i = 0; i < heights.Length; i++)
        {
            Console.WriteLine("Enter height of player " + (i + 1));
            heights[i] = double.Parse(Console.ReadLine());
            sum += heights[i];//sum all the value of array
        }

        // Calculate the mean height
        double mean = sum / heights.Length;

        Console.WriteLine("The mean height of the football team is: " + mean);
    }
}
