using System;

class Node
{
    public char Data;
    public Node Next;

    public Node(char data)
    {
        Data = data;
        Next = null;
    }
}

class LinkedList
{
    private Node head;

    public void Add(char data)
    {
        if (head == null)
            head = new Node(data);
        else
        {
            Node temp = head;
            while (temp.Next != null)
                temp = temp.Next;
            temp.Next = new Node(data);
        }
    }

    public char FindNthFromEnd(int N)
    {
        Node first = head, second = head;

        // Move the first pointer N steps ahead
        for (int i = 0; i < N; i++)
        {
            if (first == null)
                throw new ArgumentException("N is greater than the length of the list");
            first = first.Next;
        }

        // Move both pointers until first reaches the end
        while (first != null)
        {
            first = first.Next;
            second = second.Next;
        }

        return second.Data; // Second is now at the Nth node from the end
    }

    public static void Main()
    {
        LinkedList list = new LinkedList();
        list.Add('A');
        list.Add('B');
        list.Add('C');
        list.Add('D');
        list.Add('E');

        int N = 2;
        Console.WriteLine("Nth element from end: " + list.FindNthFromEnd(N));
    }
}
