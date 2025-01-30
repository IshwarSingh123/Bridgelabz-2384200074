//Write a C# program to count how many times a given substring occurs in a string.
using System;

class SubstringCounter
{
    public static int CountSubstringOccurrences(string str, string subStr, bool ignoreCase = false)
    {

        int strLen = str.Length;
        int subLen = subStr.Length;
        int count = 0;

      
        for (int i = 0; i <= strLen - subLen; i++) // Loop through the main string
        {
            bool match = true;
            for (int j = 0; j < subLen; j++) // Check if substring matches
            {
                if (str[i + j] != subStr[j])
                {
                    match = false;
                    break;
                }
            }

            if (match)
            {
				Console.WriteLine(match);
                count++; // Increase count if a match is found
            }
        }

        return count;
    }

   

    public static void Main()
    {
        Console.WriteLine("Enter the main string:");
        string str = Console.ReadLine();

        Console.WriteLine("Enter the substring to count:");
        string subStr = Console.ReadLine();

        Console.WriteLine("Do you want a case-insensitive search? (yes/no):");
        bool ignoreCase = Console.ReadLine()?:Trim().ToLower() == "yes";

        int occurrences = CountSubstringOccurrences(str, subStr, ignoreCase);

        Console.WriteLine("The substring '{subStr}' occurs {occurrences} times in the given string."+subStr);
    }
}
