using System;

class Node
{
    public int Key;
    public int Value;
    public Node Next;

    public Node(int key, int value)
    {
        Key = key;
        Value = value;
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
        return Math.Abs(key) % SIZE; // Simple modulo-based hash function
    }

    // Insert or update key-value pair
    public void Insert(int key, int value)
    {
        int hash = GetHash(key);
        Node newNode = new Node(key, value);

        if (table[hash] == null)
        {
            table[hash] = newNode;
        }
        else
        {
            Node temp = table[hash];
            while (temp != null)
            {
                if (temp.Key == key)
                {
                    temp.Value = value; // Update value if key exists
                    return;
                }
                if (temp.Next == null) break;
                temp = temp.Next;
            }
            temp.Next = newNode; // Collision handling via chaining
        }
    }

    // Retrieve value for a given key
    public int Get(int key)
    {
        int hash = GetHash(key);
        Node temp = table[hash];

        while (temp != null)
        {
            if (temp.Key == key)
                return temp.Value;
            temp = temp.Next;
        }

        return -1; // Key not found
    }

    // Remove a key-value pair
    public void Remove(int key)
    {
        int hash = GetHash(key);
        Node temp = table[hash];
        Node prev = null;

        while (temp != null)
        {
            if (temp.Key == key)
            {
                if (prev == null)
                    table[hash] = temp.Next; // Remove head node
                else
                    prev.Next = temp.Next; // Bypass the node

                return;
            }
            prev = temp;
            temp = temp.Next;
        }
    }

    // Check if key exists
    public bool ContainsKey(int key)
    {
        return Get(key) != -1;
    }
}

class Program
{
    static void Main(string[] args)
    {
        HashMap hashMap = new HashMap();

        hashMap.Insert(1, 100);
        hashMap.Insert(2, 200);
        hashMap.Insert(3, 300);

        Console.WriteLine("Value for key 2: " + hashMap.Get(2)); // 200

        hashMap.Remove(2);
        Console.WriteLine("Contains key 2: " + hashMap.ContainsKey(2)); // False

        hashMap.Insert(3, 500); // Update value for key 3
        Console.WriteLine("Updated value for key 3: " + hashMap.Get(3)); // 500
    }
}