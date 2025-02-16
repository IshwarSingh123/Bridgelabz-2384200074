using System;

class CustomStack
{
    private int[] stackArray;
    private int top;
    private int capacity;

    public CustomStack(int size)
    {
        capacity = size;
        stackArray = new int[capacity];
        top = -1; // Stack is empty initially
    }

    // Push an element onto the stack
    public void Push(int data)
    {
        if (top == capacity - 1)
        {
            Console.WriteLine("Stack Overflow");
            return;
        }
        stackArray[++top] = data;
    }

    // Pop an element from the stack
    public int Pop()
    {
        if (IsEmpty())
        {
            Console.WriteLine("Stack Underflow");
            return -1;
        }
        return stackArray[top--];
    }

    // Peek at the top element
    public int Peek()
    {
        if (IsEmpty())
            return -1;
        return stackArray[top];
    }

    // Check if the stack is empty
    public bool IsEmpty()
    {
        return top == -1;
    }

    // Insert element in sorted order
    public void SortedInsert(int element)
    {
        if (IsEmpty() || element > Peek())
        {
            Push(element);
        }
        else
        {
            int temp = Pop();
            SortedInsert(element);
            Push(temp);
        }
    }

    // Sort the stack recursively
    public void SortStack()
    {
        if (!IsEmpty())
        {
            int temp = Pop();
            SortStack();
            SortedInsert(temp);
        }
    }

    // Print the stack elements
    public void PrintStack()
    {
        for (int i = 0; i <= top; i++)
        {
            Console.Write(stackArray[i] + " ");
        }
        Console.WriteLine();
    }
}

class Program
{
    static void Main()
    {
        CustomStack stack = new CustomStack(10);
        stack.Push(5);
        stack.Push(1);
        stack.Push(0);
        stack.Push(2);
        stack.Push(4);

        Console.WriteLine("Original Stack:");
        stack.PrintStack();

        stack.SortStack();

        Console.WriteLine("Sorted Stack:");
        stack.PrintStack();
    }
}
