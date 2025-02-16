using System;

namespace SlidingWindow
{
    // Node class for doubly linked list
    internal class Node
    {
        public int Data;
        public Node Next, Prev;

        public Node(int data)
        {
            Data = data;
            Next = Prev = null;
        }
    }

    // Custom deque implementation
    internal class Dque
    {
        private Node front, rear;

        public Dque() 
        { 
            front = rear = null; 
        }

        // Adds an element at the front
        public void AddFront(int data)
        {
            Node newNode = new Node(data);
            if (front == null)
            {
                front = rear = newNode;
                return;
            }
            newNode.Next = front;
            front.Prev = newNode;
            front = newNode;
        }

        // Adds an element at the rear
        public void AddRear(int data)
        {
            Node newNode = new Node(data);
            if (front == null)
            {
                front = rear = newNode;
                return;
            }
            newNode.Prev = rear;
            rear.Next = newNode;
            rear = newNode;
        }

        // Removes an element from the front
        public int RemoveFront()
        {
            if (front == null) 
            {
                Console.WriteLine("Deque is empty");
                return -1;
            }
            int data = front.Data;
            front = front.Next;
            if (front == null) rear = null;
            else front.Prev = null;
            return data;
        }

        // Removes an element from the rear
        public int RemoveBack()
        {
            if (rear == null) 
            {
                Console.WriteLine("Deque is empty");
                return -1;
            }
            int data = rear.Data;
            rear = rear.Prev;
            if (rear == null) front = null;
            else rear.Next = null;
            return data;
        }

        // Checks if the deque is empty
        public bool IsEmpty()
        {
            return front == null;
        }

        // Returns the value at the front of the deque
        public int GetFront()
        {
            if (front == null)
            {
                Console.WriteLine("Deque is empty");
                return -1;
            }
            return front.Data;
        }

        // Returns the value at the rear of the deque
        public int GetRear()
        {
            if (rear == null)
            {
                Console.WriteLine("Deque is empty");
                return -1;
            }
            return rear.Data;
        }
    }

    internal class SlidingWindow
    {
        public void Max(int[] arr, int k)
        {
            if (k <= 0) 
            {
                Console.WriteLine("Enter a window size greater than zero");
                return;
            }

            Dque dque = new Dque(); // Deque to store indices

            for (int i = 0; i < arr.Length; i++)
            {
                // Remove indices that are out of the current window
                while (!dque.IsEmpty() && dque.GetFront() < (i - k + 1))
                    dque.RemoveFront();

                // Remove elements that are smaller than the current element
                while (!dque.IsEmpty() && arr[dque.GetRear()] < arr[i])
                    dque.RemoveBack();

                // Add the current index at the rear
                dque.AddRear(i);

                // Print the maximum for the current window
                if (i >= k - 1)
                    Console.Write(arr[dque.GetFront()] + " ");
            }
        }
    }

    class Program
    {
        static void Main()
        {
            Console.WriteLine("Enter array size:");
            int n = Convert.ToInt32(Console.ReadLine());
            int[] arr = new int[n];

            Console.WriteLine("Enter array elements:");
            for (int i = 0; i < n; i++) arr[i] = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter window size:");
            int k = Convert.ToInt32(Console.ReadLine());

            new SlidingWindow().Max(arr, k);
        }
    }
}