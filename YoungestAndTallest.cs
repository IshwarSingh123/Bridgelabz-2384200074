/*Create a program to find the youngest friends among 3 Amar, Akbar and Anthony based on their ages and tallest among the friends based on their heights and display it
Hint => 
a.               Take user input for age and height for the 3 friends and store it in two arrays each to store the values for age and height of the 3 friends
b.               Write a Method to find the youngest of the 3 friends
c.                Write a Method to find the tallest of the 3 friends*/


using System;

class YoungestAndTallest
{
    // Method to find the youngest person
    public int FindYoungest(int[] ages, out int index)
    {
        int young = ages[0];
        index = 0;
        for (int i = 1; i < ages.Length; i++)
        {
            if (ages[i] < young)
            {
                young = ages[i];
                index = i;
            }
        }
        return young;
    }

    // Method to find the tallest person
    public int FindTallest(int[] heights, out int index)
    {
        int tallest = heights[0];
        index = 0;
        for (int i = 1; i < heights.Length; i++)
        {
            if (heights[i] > tallest)
            {
                tallest = heights[i];
                index = i;
            }
        }
        return tallest;
    }

    public static void Main(string[] args)
    {
        YoungestAndTallest obj = new YoungestAndTallest();
        string[] names = { "Amar", "Akbar", "Anthony" };
        int[] ages = new int[names.Length];
        int[] heights = new int[names.Length];

        // Take input for ages and heights
        for (int i = 0; i < names.Length; i++)
        {
            Console.Write("Enter the age of " + names[i] + ": ");
            ages[i] = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter the height of " + names[i] + ": ");
            heights[i] = Convert.ToInt32(Console.ReadLine());
        }

        // Find the youngest and tallest person
        int youngestIndex, tallestIndex;
        int youngestAge = obj.FindYoungest(ages, out youngestIndex);
        int tallestHeight = obj.FindTallest(heights, out tallestIndex);

        // Display results
        Console.WriteLine("\nResults:");
        Console.WriteLine("Youngest: " + names[youngestIndex] + " Age: " + youngestAge);
        Console.WriteLine("Tallest: " + names[tallestIndex] + " Height: " + tallestHeight);
    }
}
