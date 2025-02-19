using System;
using System.Collections.Generic;

class DictionaryInverter
{
    public static Dictionary<V, List<K>> InvertDictionary<K, V>(Dictionary<K, V> inputDict)
    {
        Dictionary<V, List<K>> invertedDict = new Dictionary<V, List<K>>();

        foreach (var pair in inputDict)
        {
            if (!invertedDict.ContainsKey(pair.Value))
                invertedDict[pair.Value] = new List<K>(); // Initialize list

            invertedDict[pair.Value].Add(pair.Key);
        }

        return invertedDict;
    }

    public static void Main()
    {
        var input = new Dictionary<char, int>
        {
            { 'A', 1 },
            { 'B', 2 },
            { 'C', 1 }
        };

        var output = InvertDictionary(input);

        // Print result
        foreach (var pair in output)
        {
            Console.Write($"{pair.Key} = [");
            Console.Write(string.Join(", ", pair.Value));
            Console.WriteLine("]");
        }
    }
}
