using System;
using System.Collections.Generic;

class Program
{
    public static HashSet<int> ComputeSymmetricDifference(HashSet<int> set1, HashSet<int> set2)
    {
        HashSet<int> symmetric = new HashSet<int>();

        // Add elements from set1 that are NOT in set2
        foreach (int num in set1)
        {
            if (!set2.Contains(num))
            {
                symmetric.Add(num);
            }
                
        }

        // Add elements from set2 that are NOT in set1
        foreach (int num in set2)
        {
            if (!set1.Contains(num))
            {
                symmetric.Add(num);
            }
                
        }

        return symmetric;
    }

    static void Main()
    {
        HashSet<int> set1 = new HashSet<int>() { 1, 2, 3 };
        HashSet<int> set2 = new HashSet<int>() { 3, 4, 5 };

        HashSet<int> symmetricDifference = ComputeSymmetricDifference(set1, set2);

        Console.WriteLine("Symmetric Difference: {" + string.Join(", ", symmetricDifference) + "}");
    }
}
