using System;
using System.Collections.Generic;

class Program
{
    static HashSet<int> ComputeUnion(HashSet<int> set1, HashSet<int> set2)
    {
        HashSet<int> unionSet = new HashSet<int>();

        // Add all elements of set1
        foreach (int num in set1)
        {
            unionSet.Add(num);
        }

        // Add elements from set2 that are not already present
        foreach (int num in set2)
        {
            if (!unionSet.Contains(num))
                unionSet.Add(num);
        }

        return unionSet;
    }

    static HashSet<int> ComputeIntersection(HashSet<int> set1, HashSet<int> set2)
    {
        HashSet<int> intersectionSet = new HashSet<int>();

        // Add elements that exist in both sets
        foreach (int num in set1)
        {
            if (set2.Contains(num))
                intersectionSet.Add(num);
        }

        return intersectionSet;
    }

    static void Main()
    {
        HashSet<int> set1 = new HashSet<int>() { 1, 2, 3 };
        HashSet<int> set2 = new HashSet<int>() { 3, 4, 5 };

        HashSet<int> unionResult = ComputeUnion(set1, set2);
        HashSet<int> intersectionResult = ComputeIntersection(set1, set2);

        Console.WriteLine("Union: {" + string.Join(", ", unionResult) + "}");
        Console.WriteLine("Intersection: {" + string.Join(", ", intersectionResult) + "}");
    }
}
