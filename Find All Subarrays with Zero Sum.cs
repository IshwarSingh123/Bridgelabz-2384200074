using System;

class Node
{
    public int Key;
    public int Index;
    public Node Next;

    public Node(int key, int index)
    {
        Key = key;
        Index = index;
        Next = null;
    }
}

class HashMap
{
    private const int SIZE = 1000; // Hash table size
    private Node[] table;

    public HashMap()
    {
        table = new Node[SIZE];
    }

    private int GetHash(int key)
    {
        return Math.Abs(key) % SIZE;
    }

    // Insert key and index into HashMap
    public void Insert(int key, int index)
    {
        int hash = GetHash(key);
        Node newNode = new Node(key, index);

        if (table[hash] == null)
        {
            table[hash] = newNode;
        }
        else
        {
            Node temp = table[hash];
            while (temp.Next != null)
            {
                temp = temp.Next;
            }
            temp.Next = newNode; // Collision handling using chaining
        }
    }

    // Get all indices for a key (if found)
    public int[] Get(int key)
    {
        int hash = GetHash(key);
        Node temp = table[hash];

        int[] indices = new int[100]; // Assume at most 100 collisions per key
        int count = 0;

        while (temp != null)
        {
            if (temp.Key == key)
            {
                indices[count++] = temp.Index;
            }
            temp = temp.Next;
        }

        int[] result = new int[count];
        for (int i = 0; i < count; i++)
        {
            result[i] = indices[i];
        }
        return result;
    }
}

class ZeroSumSubarrays
{
    public static void FindZeroSumSubarrays(int[] arr)
    {
        HashMap hashMap = new HashMap();
        int sum = 0;

        hashMap.Insert(0, -1); // Initialize for sum=0 at index -1

        for (int i = 0; i < arr.Length; i++)
        {
            sum += arr[i];

            int[] indices = hashMap.Get(sum); // Check if sum exists before

            if (indices.Length > 0)
            {
                foreach (int start in indices)
                {
                    Console.Write("Subarray found from index " + (start + 1) + " to " + i + ": ");
                    for (int k = start + 1; k <= i; k++)
                    {
                        Console.Write(arr[k] + " ");
                    }
                    Console.WriteLine();
                }
            }

            // Store the sum and index in hashmap
            hashMap.Insert(sum, i);
        }
    }

    static void Main(string[] args)
    {
        int[] arr = { 3, 4, -7, 3, 1, 3, 1, -4, -2, -2 }; // Example input
        FindZeroSumSubarrays(arr);
    }
}