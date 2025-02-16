using System;

namespace QueueUsingTwoStacks
{
    internal class Stack
    {
        Node top;

        public void Push(int data)
        {
            Node newNode = new Node(data);
            newNode.next = top;
            top = newNode;
        }

        public int Pop()
        {
            if (top == null)
            {
                throw new InvalidOperationException("Stack is Empty.");
            }

            int value = top.data;
            top = top.next;
            return value;
        }

        public int Peek()
        {
            if (top == null)
            {
                throw new InvalidOperationException("Stack is Empty.");
            }
            return top.data;
        }

        public bool IsEmpty()
        {
            return top == null;
        }
    }

    internal class Queue
    {
        Stack stack1;
        Stack stack2;

        public Queue()
        {
            stack1 = new Stack();
            stack2 = new Stack();
        }

        public void Enqueue(int data)
        {
            stack1.Push(data);
        }

        public int Dequeue()
        {
            if (stack2.IsEmpty())
            {
                while (!stack1.IsEmpty())
                {
                    stack2.Push(stack1.Pop());
                }
            }

            if (stack2.IsEmpty())
            {
                throw new InvalidOperationException("Queue is Empty.");
            }

            return stack2.Pop();
        }

        public void DisplayElementsOfQueue()
        {
            if (stack2.IsEmpty() && stack1.IsEmpty())
            {
                Console.WriteLine("Queue is Empty!");
                return;
            }

            // Temporarily transfer stack1 to a new stack to display in correct order
            Stack tempStack = new Stack();
            while (!stack1.IsEmpty())
            {
                tempStack.Push(stack1.Pop());
            }

            // Display elements of tempStack
            while (!tempStack.IsEmpty())
            {
                int data = tempStack.Pop();
                Console.Write(data + " ");
                stack1.Push(data);  // Push back to stack1 to maintain order
            }

            // Display elements of stack2
            Stack reverseStack2 = new Stack();
            while (!stack2.IsEmpty())
            {
                reverseStack2.Push(stack2.Pop());
            }

            while (!reverseStack2.IsEmpty())
            {
                int data = reverseStack2.Pop();
                Console.Write(data + " ");
                stack2.Push(data);
            }

            Console.WriteLine();
        }
    }

    internal class Node
    {
        public int data { get; set; }
        public Node next;

        public Node(int data)
        {
            this.data = data;
            this.next = null;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Queue queue = new Queue();

            while (true)
            {
                Console.WriteLine("\nChoose an Option:");
                Console.WriteLine("1. Enqueue\n2. Dequeue\n3. Display Queue\n4. Exit");
                Console.Write("Enter your choice: ");
                
                int choice;
                if (!int.TryParse(Console.ReadLine(), out choice))
                {
                    Console.WriteLine("Invalid input. Please enter a number.");
                    continue;
                }

                try
                {
                    switch (choice)
                    {
                        case 1:
                            Console.Write("Enter the element to enqueue: ");
                            int data = int.Parse(Console.ReadLine());
                            queue.Enqueue(data);
                            Console.WriteLine($"{data} enqueued successfully.");
                            break;
                        case 2:
                            Console.WriteLine($"{queue.Dequeue()} dequeued successfully.");
                            break;
                        case 3:
                            queue.DisplayElementsOfQueue();
                            break;
                        case 4:
                            return;
                        default:
                            Console.WriteLine("Invalid choice! Please enter a number between 1 and 4.");
                            break;
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
            }
        }
    }
}