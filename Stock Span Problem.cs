using System;

class Node
{
    public int data; // Stores index of the price
    public Node next;

    public Node(int data)
    {
        this.data = data;
        this.next = null;
    }
}

class CustomStack
{
    private Node top;

    public CustomStack()
    {
        this.top = null;
    }

    // Push an element (index) onto the stack
    public void Push(int data)
    {
        Node newNode = new Node(data);
        newNode.next = top;
        top = newNode;
    }

    // Pop an element (index) from the stack
    public int Pop()
    {
        if (IsEmpty())
            return -1;

        int poppedData = top.data;
        top = top.next;
        return poppedData;
    }

    // Peek at the top element (index)
    public int Peek()
    {
        if (IsEmpty())
            return -1;
        return top.data;
    }

    // Check if the stack is empty
    public bool IsEmpty()
    {
        return top == null;
    }
}

class StockSpan
{
    public static void CalculateSpan(int[] prices, int[] span)
    {
        int n = prices.Length;
        CustomStack stack = new CustomStack();

        // Span for the first day is always 1
        span[0] = 1;
        stack.Push(0); // Push the first index

        // Process each stock price
        for (int i = 1; i < n; i++)
        {
            // Pop elements until we find a greater price
            while (!stack.IsEmpty() && prices[stack.Peek()] <= prices[i])
            {
                stack.Pop();
            }

            // Calculate span
            span[i] = stack.IsEmpty() ? (i + 1) : (i - stack.Peek());

            // Push current index onto stack
            stack.Push(i);
        }
    }

    static void PrintArray(int[] arr)
    {
        for (int i = 0; i < arr.Length; i++)
        {
            Console.Write(arr[i] + " ");
        }
        Console.WriteLine();
    }

    static void Main()
    {
        int[] prices = { 100, 80, 60, 70, 60, 75, 85 };
        int[] span = new int[prices.Length];

        CalculateSpan(prices, span);

        Console.WriteLine("Stock Prices:");
        PrintArray(prices);

        Console.WriteLine("Stock Span:");
        PrintArray(span);
    }
}
