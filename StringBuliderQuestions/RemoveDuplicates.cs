using System;
using System.Collections.Generic;
using System.Text;

class Program
{
    static void Main()
    {
        Console.Write("Enter a string: ");
        string input = Console.ReadLine();

        string result = RemoveDuplicates(input);
        Console.WriteLine("String after removing duplicates: " + result);
    }

    static string RemoveDuplicates(string input)
    {
        HashSet<char> set = new HashSet<char>(); // To track unique characters
        StringBuilder sb = new StringBuilder();

        foreach (char c in input)
        {
            if (set.Add(c)) // Add returns true only if c is not already in HashSet
            {
                sb.Append(c);
            }
        }

        return sb.ToString();
    }
}
