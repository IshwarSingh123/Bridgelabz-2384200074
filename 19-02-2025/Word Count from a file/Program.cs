using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text.RegularExpressions;

class WordFrequencyCounter
{
    public static Dictionary<string, int> CountWordFrequency(string filePath)
    {
        var wordCount = new Dictionary<string, int>();

        if (!File.Exists(filePath))
        {
            Console.WriteLine("File not found!");
            return wordCount;
        }

        string text = File.ReadAllText(filePath).ToLower(); // Read file & normalize case
        string[] words = Regex.Split(text, @"\W+"); // Split by non-word characters

        foreach (string word in words)
        {
            if (string.IsNullOrWhiteSpace(word)) continue; // Skip empty entries

            if (wordCount.ContainsKey(word))
                wordCount[word]++;
            else
                wordCount[word] = 1;
        }

        return wordCount;
    }

    public static void Main()
    {
        string filePath = @"C:\Users\frinds system\Desktop\Sample.txt"; // Change this to your actual file path
        var result = CountWordFrequency(filePath);

        // Print word frequencies
        Console.WriteLine("Word Frequency Count:");
        foreach (var pair in result.OrderByDescending(x => x.Value))
            Console.WriteLine($"'{pair.Key}': {pair.Value}");
    }
}
