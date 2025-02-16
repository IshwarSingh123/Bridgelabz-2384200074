using System;

class HashMap
{
    private const int SIZE = 1000;
    private int[] table;

    public HashMap()
    {
        table = new int[SIZE];
    }

    private int GetHash(int key)
    {
        return Math.Abs(key) % SIZE;
    }

    public void Insert(int key)
    {
        int hash = GetHash(key);
        table[hash] = key;
    }

    public bool Contains(int key)
    {
        int hash = GetHash(key);
        return table[hash] == key;
    }
}

class LongestConsecutiveSequence
{
    public static int FindLongestSequence(int[] arr)
    {
        if (arr.Length == 0) return 0;

        HashMap hashMap = new HashMap();

        // Insert all elements into HashMap
        for (int i = 0; i < arr.Length; i++)
        {
            hashMap.Insert(arr[i]);
        }

        int maxLength = 0;

        // Check for longest consecutive sequence
        for (int i = 0; i < arr.Length; i++)
        {
            if (!hashMap.Contains(arr[i] - 1)) // Start of a sequence
            {
                int currentNum = arr[i];
                int count = 1;

                while (hashMap.Contains(currentNum + 1))
                {
                    currentNum++;
                    count++;
                }

                maxLength = Math.Max(maxLength, count);
            }
        }
        return maxLength;
    }

    static void Main()
    {
        int[] arr = { 100, 4, 200, 1, 3, 2 };
        Console.WriteLine("Longest Consecutive Sequence: " + FindLongestSequence(arr)); // Output: 4
    }
}