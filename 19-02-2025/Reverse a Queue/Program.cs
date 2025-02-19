class MyClass
{
    public static Queue<int> ReversedQueue(Queue<int> queue)
    {
        Stack<int> stack = new Stack<int>();

        while(queue.Count>0)
        {
           int num = queue.Dequeue();
            stack.Push(num);
        }
        while(stack.Count>0)
        {
            int num =stack.Pop();
            queue.Enqueue(num);
        }
        return queue;
    }
    static void Main(string[] args)
    {
        Queue<int> queue = new Queue<int>();
        Console.WriteLine("Enter the Elements of Queue");

        string[] arr = Console.ReadLine().Split(" ");

        foreach (var item in arr)
        {
            if(int.TryParse(item,out int ele))
            {
                queue.Enqueue(ele);
            }
        }
        Console.WriteLine("------After Reversed--------");
        Queue<int> result = ReversedQueue(queue);
        foreach (var item in result)
        {
            Console.Write(item+" ");
        }
        Console.WriteLine();
    }
}