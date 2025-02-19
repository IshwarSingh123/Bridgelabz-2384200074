class MyClass
{

    public static void GenerateBinaryNumbers(int n)
    {
        Queue<string> q = new Queue<string>();
        q.Enqueue("1");
        for (int i = 0; i < n; i++)
        {
            string binaryNum = q.Dequeue();
            Console.WriteLine(binaryNum+" ");

            q.Enqueue(binaryNum+"0");
            q.Enqueue(binaryNum+"1");
        }
    }
    static void Main(string[] args)
    {
        Console.Write("Enter the value of N: ");
        int N = int.Parse(Console.ReadLine());

        Console.WriteLine($"First {N} binary numbers:");
        GenerateBinaryNumbers(N);
    }
}