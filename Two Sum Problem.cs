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

    // Search for a key and return its index
    public int Search(int key)
    {
        int hash = GetHash(key);
        Node temp = table[hash];

        while (temp != null)
        {
            if (temp.Key == key)
            {
                return temp.Index;
            }
            temp = temp.Next;
        }

        return -1; // Not found
    }
}

class TwoSum
{
    public static void FindTwoSum(int[] arr, int target)
    {
        HashMap hashMap = new HashMap();

        for (int i = 0; i < arr.Length; i++)
        {
            int complement = target - arr[i];

            int complementIndex = hashMap.Search(complement);
            if (complementIndex != -1)
            {
                Console.WriteLine("Pair found at indices: " + complementIndex + " and " + i);
                return;
            }

            // Store the current element and its index in the hash map
            hashMap.Insert(arr[i], i);
        }

        Console.WriteLine("No pair found.");
    }

    static void Main(string[] args)
    {
        int[] arr = { 2, 7, 11, 15 }; // Example input
        int target = 9;
        FindTwoSum(arr, target);
    }
}