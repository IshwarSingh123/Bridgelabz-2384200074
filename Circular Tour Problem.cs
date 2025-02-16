using System;

class Node
{
    public int index;
    public Node next;

    public Node(int index)
    {
        this.index = index;
        this.next = null;
    }
}

class CustomQueue
{
    private Node front, rear;

    public CustomQueue()
    {
        front = rear = null;
    }

    // Enqueue an element (index)
    public void Enqueue(int index)
    {
        Node newNode = new Node(index);
        if (rear == null)
        {
            front = rear = newNode;
            return;
        }
        rear.next = newNode;
        rear = newNode;
    }

    // Dequeue an element (index)
    public int Dequeue()
    {
        if (IsEmpty())
            return -1;

        int dequeuedData = front.index;
        front = front.next;

        if (front == null)
            rear = null;

        return dequeuedData;
    }

    // Check if the queue is empty
    public bool IsEmpty()
    {
        return front == null;
    }
}

class CircularTour
{
    public static int FindStartingPump(int[] petrol, int[] distance)
    {
        int n = petrol.Length;
        int totalSurplus = 0, currentSurplus = 0, start = 0;

        for (int i = 0; i < n; i++)
        {
            totalSurplus += petrol[i] - distance[i];
            currentSurplus += petrol[i] - distance[i];

            if (currentSurplus < 0)
            {
                start = i + 1; // Start from the next pump
                currentSurplus = 0; // Reset surplus
            }
        }

        return (totalSurplus >= 0) ? start : -1;
    }

    static void Main()
    {
        int[] petrol = { 4, 6, 7, 4 };
        int[] distance = { 6, 5, 3, 5 };

        int startIndex = FindStartingPump(petrol, distance);

        if (startIndex == -1)
            Console.WriteLine("No possible circular tour.");
        else
            Console.WriteLine("Start at petrol pump index: " + startIndex);
    }
}
