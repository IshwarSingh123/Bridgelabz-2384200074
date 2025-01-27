//Create a program to find the youngest friends among 3 Amar, Akbar, and Anthony based on their ages and the tallest among the friends based on their heights


using System;

class FriendAnalyzerYoungestAndTaller
{
    static void Main()
    {
        // Arrays to store the ages and heights of friends
        int[] friendAges = new int[3];
        float[] friendHeights = new float[3];
        string[] friendNames = { "Amar", "Akbar", "Anthony" };

        // Input the ages and heights for each friend
        for (int i = 0; i < friendNames.Length; i++)
        {
            Console.Write("Enter the age of " + friendNames[i] + ": ");
            friendAges[i] = int.Parse(Console.ReadLine());

            Console.Write("Enter the height of " + friendNames[i] + " (in cm): ");
            friendHeights[i] = float.Parse(Console.ReadLine());
        }

        // Variables to track the youngest and tallest friend
        int youngestFriendIndex = 0;  // Index of the youngest friend
        int tallestFriendIndex = 0;  // Index of the tallest friend

        // Find the youngest and tallest friends
        for (int i = 1; i < friendNames.Length; i++)
        {
            if (friendAges[i] < friendAges[youngestFriendIndex])
            {
                youngestFriendIndex = i; // Update the index of the youngest friend
            }
            if (friendHeights[i] > friendHeights[tallestFriendIndex])
            {
                tallestFriendIndex = i; // Update the index of the tallest friend
            }
        }

        // Output the youngest friend
        Console.WriteLine("\nThe youngest friend is " + friendNames[youngestFriendIndex] + ", with an age of " + friendAges[youngestFriendIndex] + " years.");

        // Output the tallest friend
        Console.WriteLine("The tallest friend is " + friendNames[tallestFriendIndex] + ", with a height of " + friendHeights[tallestFriendIndex] + " cm.");
    }
}


