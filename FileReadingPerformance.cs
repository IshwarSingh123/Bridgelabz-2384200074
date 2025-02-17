using System;
using System.Diagnostics;
using System.IO;
using System.Text;

class FileReadingPerformance
{
    static void ReadWithStreamReader(string filePath)
    {
        using (StreamReader sr = new StreamReader(filePath))
        {
            while (sr.Read() != -1) { }
        }
    }

    static void ReadWithFileStream(string filePath)
    {
        using (FileStream fs = new FileStream(filePath, FileMode.Open, FileAccess.Read))
        {
            byte[] buffer = new byte[4096];
            while (fs.Read(buffer, 0, buffer.Length) > 0) { }
        }
    }

    static void Benchmark(Action<string> readFunction, string filePath, string methodName)
    {
        Stopwatch sw = Stopwatch.StartNew();
        readFunction(filePath);
        sw.Stop();
        Console.WriteLine($"{methodName}: {sw.ElapsedMilliseconds} ms");
    }

    static void Main()
    {
        string filePath = "largefile.txt"; // Replace with actual large file path
        Console.WriteLine("Reading file: {0}", filePath);
        Benchmark(ReadWithStreamReader, filePath, "StreamReader");
        Benchmark(ReadWithFileStream, filePath, "FileStream");
    }
}
