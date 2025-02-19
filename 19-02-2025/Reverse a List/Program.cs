using System;
using System.Collections;

class Program
{
    static void Main()
    {
        LinkedList<int> linkedList = new LinkedList<int>();
        Console.WriteLine("Enter integer elements in Linked List dynamically (type 'stop' to end input):");

        while (true)
        {
            string input = Console.ReadLine();
            if (input.ToLower() == "stop")
                break;

            if (int.TryParse(input, out int intValue))
            {
                linkedList.AddLast(intValue);
            }
            else
            {
                Console.WriteLine("Invalid input! Please enter an integer.");
            }
        }
        Console.Write("Original List: ");
        PrintLinkedList(linkedList);

        ReverseLinkedList(linkedList);

        Console.Write("Reversed List: ");
        PrintLinkedList(linkedList);

        ArrayList list = new ArrayList();
        Console.WriteLine("Enter elements in Array List  dynamically (type 'stop' to end input):");

        while (true)
        {
            string input = Console.ReadLine();
            if (input.ToLower() == "stop")
                break;

            if (int.TryParse(input, out int intValue))
            {
                list.Add(intValue);
            }
            else if (double.TryParse(input, out double doubleValue))
            {
                list.Add(doubleValue);
            }
            else
            {
                list.Add(input);
            }
        }

        Console.Write("Original List: ");
        PrintList(list);

        ReverseArrayList(list);

        Console.Write("Reversed List: ");
        PrintList(list);
    }


    static void ReverseLinkedList(LinkedList<int> linkedList)
    {
        LinkedListNode<int> prev = null, current = linkedList.First, next = null;

        while (current != null)
        {
            next = current.Next;
            linkedList.Remove(current);
            linkedList.AddFirst(current);
            current = next;
        }
    }

    static void ReverseArrayList(ArrayList list)
    {
        int left = 0, right = list.Count - 1;
        while (left < right)
        {
            object temp = list[left];
            list[left] = list[right];
            list[right] = temp;
            left++;
            right--;
        }
    }

    static void PrintList(ArrayList list)
    {
        foreach (var item in list)
        {
            Console.Write(item + " ");
        }
        Console.WriteLine();
    }
    static void PrintLinkedList(LinkedList<int> linkedList)
    {
        foreach (var item in linkedList)
        {
            Console.Write(item + " ");
        }
        Console.WriteLine();
    }
}
