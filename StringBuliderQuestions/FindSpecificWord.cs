using System;

class Program
{
    static int LinearSearch(string[] sentences, string word)
    {
        for (int i = 0; i < sentences.Length; i++)
        {
            if (sentences[i].IndexOf(word, StringComparison.OrdinalIgnoreCase) >= 0)
            {
                return i; // Return the index of the first matching sentence
            }
        }
        return -1; // Return -1 if no match is found
    }

    static void Main()
    {
        string[] sentences =
        {
            "The quick brown fox jumps over the lazy dog.",
            "C# is a powerful programming language.",
            "Learning data structures and algorithms is important.",
            "This sentence does not contain the word you are looking for."
        };

        Console.Write("Enter a word to search: ");
        string word = Console.ReadLine();

        int index = LinearSearch(sentences, word);

        if (index != -1)
        {
            Console.WriteLine($"Word found in sentence {index + 1}: {sentences[index]}");
        }
        else
        {
            Console.WriteLine("Word not found in any sentence.");
        }
    }
}
