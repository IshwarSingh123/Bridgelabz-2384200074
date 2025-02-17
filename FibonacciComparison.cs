using System;
using System.Diagnostics;
using System.IO;
using System.Text;

class FibonacciPerformance
{
    public static int FibonacciRecursive(int n)
    {
        if (n <= 1) return n;
        return FibonacciRecursive(n - 1) + FibonacciRecursive(n - 2);
    }

    public static int FibonacciIterative(int n)
    {
        if (n <= 1) return n;
        int a = 0, b = 1, temp;
        for (int i = 2; i <= n; i++)
        {
            temp = a + b;
            a = b;
            b = temp;
        }
        return b;
    }

    static void Benchmark(Func<int, int> fibFunction, int n, string methodName)
    {
        Stopwatch sw = Stopwatch.StartNew();
        int result = fibFunction(n);
        sw.Stop();
        Console.WriteLine($"{methodName} (Fib({n})) = {result}, Time: {sw.ElapsedMilliseconds} ms");
    }

    static void Main()
    {
        int n = 30;
        Console.WriteLine("Computing Fibonacci for N = {0}", n);
        Benchmark(FibonacciRecursive, n, "Recursive Fibonacci");
        Benchmark(FibonacciIterative, n, "Iterative Fibonacci");
    }
}