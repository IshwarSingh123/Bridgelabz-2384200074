using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

class Program
{
    static void Main(string[] args)
    {
        string filePath = @"C:\Users\frinds system\Desktop\NewDocument.txt"; // Replace with the path to your text file

        try
        {
            // Dictionary to store word counts
            Dictionary<string, int> wordCounts = new Dictionary<string, int>();

            // Read the file line by line using StreamReader
            using (StreamReader reader = new StreamReader(filePath))
            {
                string line;
                while ((line = reader.ReadLine()) != null)
                {
                    // Split the line into words (ignoring punctuation and case)
                    string[] words = line.Split(new[] { ' ', '\t', '\n', '\r', '.', ',', ';', '!', '?', ':', '-', '(', ')' },
                                               StringSplitOptions.RemoveEmptyEntries);

                    foreach (string word in words)
                    {
                        string cleanedWord = word.ToLower(); // Convert to lowercase for case insensitivity

                        // Update the word count in the dictionary
                        if (wordCounts.ContainsKey(cleanedWord))
                        {
                            wordCounts[cleanedWord]++;
                        }
                        else
                        {
                            wordCounts[cleanedWord] = 1;
                        }
                    }
                }
            }

            // Sort the dictionary by value (word count) in descending order
            var sortedWords = wordCounts.OrderByDescending(pair => pair.Value);

            // Display the top 5 most frequently occurring words
            Console.WriteLine("Top 5 most frequently occurring words:");
            int count = 0;
            foreach (var pair in sortedWords)
            {
                if (count >= 5) break; // Stop after displaying the top 5
                Console.WriteLine($"{pair.Key}: {pair.Value} occurrences");
                count++;
            }
        }
        catch (FileNotFoundException)
        {
            Console.WriteLine("The file was not found.");
        }
        catch (IOException ex)
        {
            Console.WriteLine($"An I/O error occurred: {ex.Message}");
        }
        catch (Exception ex)
        {
            Console.WriteLine($"An error occurred: {ex.Message}");
        }
    }
}