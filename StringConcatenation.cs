using System;
using System.Diagnostics;
using System.Text;

class StringConcatenationPerformance
{
    static void ConcatenateWithString(int N)
    {
        string result = "";
        for (int i = 0; i < N; i++)
        {
            result += "a";
        }
    }

    static void ConcatenateWithStringBuilder(int N)
    {
        StringBuilder sb = new StringBuilder();
        for (int i = 0; i < N; i++)
        {
            sb.Append("a");
        }
    }

    static void Benchmark(Action<int> concatFunction, int N, string methodName)
    {
        Stopwatch sw = Stopwatch.StartNew();
        concatFunction(N);
        sw.Stop();
        Console.WriteLine($"{methodName}: {sw.ElapsedMilliseconds} ms");
    }

    static void Main()
    {
        int N = 1000000;
        Console.WriteLine("Concatenating {0} strings:", N);
        Benchmark(ConcatenateWithString, N, "String Concatenation");
        Benchmark(ConcatenateWithStringBuilder, N, "StringBuilder Concatenation");
    }
}
