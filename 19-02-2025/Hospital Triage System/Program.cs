class MyClass
{
    
    public void PriorityByEmergency(PriorityQueue<string,int> pq)
    {
        while (pq.Count>0)
        {

            Console.WriteLine(pq.Dequeue());
        }
    }
    static void Main(string[] args)
    {
        MyClass myClass = new MyClass();
        PriorityQueue<string, int> pq = new PriorityQueue<string, int>();

        Console.Write("Enter the number of elements: ");
        int n = int.Parse(Console.ReadLine());

        for (int i = 0; i < n; i++)
        {
            Console.Write("Enter the Patient name: ");
            string name = Console.ReadLine();

            Console.Write("Enter the priority (lower number = higher priority): ");
            int priority = int.Parse(Console.ReadLine());

            pq.Enqueue(name, -priority);
        }

        myClass.PriorityByEmergency(pq);

    }
}