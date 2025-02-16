using System;

class Node
{
    public int Key;
    public Node Next;

    public Node(int key)
    {
        Key = key;
        Next = null;
    }
}

class CustomHashMap
{
    private const int SIZE = 1000;
    private Node[] table;

    public CustomHashMap()
    {
        table = new Node[SIZE];
    }

    private int GetHash(int key)
    {
        return Math.Abs(key) % SIZE;
    }

    public void Insert(int key)
    {
        int hash = GetHash(key);
        Node newNode = new Node(key);

        if (table[hash] == null)
        {
            table[hash] = newNode;
        }
        else
        {
            Node temp = table[hash];
            while (temp.Next != null)
                temp = temp.Next;
            temp.Next = newNode;
        }
    }

    public bool Contains(int key)
    {
        int hash = GetHash(key);
        Node temp = table[hash];

        while (temp != null)
        {
            if (temp.Key == key)
                return true;
            temp = temp.Next;
        }
        return false;
    }
}

class PairWithGivenSum
{
    public static bool HasPairWithSum(int[] arr, int target)
    {
        CustomHashMap hashMap = new CustomHashMap();

        for (int i = 0; i < arr.Length; i++)
        {
            int complement = target - arr[i];

            if (hashMap.Contains(complement))
            {
                Console.WriteLine($"Pair found: ({arr[i]}, {complement})");
                return true;
            }

            hashMap.Insert(arr[i]);
        }

        return false;
    }

    static void Main()
    {
        int[] arr = { 1, 4, 7, 8, 5 };
        int target = 12;
        if (!HasPairWithSum(arr, target))
        {
            Console.WriteLine("No pair found.");
        }
    }
}