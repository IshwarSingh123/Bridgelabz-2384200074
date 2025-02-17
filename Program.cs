using System;
using System.Diagnostics;

class SearchComparison
{
    static void Main()
    {
        int[] sizes = { 100000, 10000000, 1000000000 }; // Dataset sizes
        Random rand = new Random();

        foreach (int N in sizes)
        {
            int[] data = new int[N];

            // Generate Random Data
            for (int i = 0; i < N; i++)
                data[i] = rand.Next(1, N * 10);

            int target = data[rand.Next(0, N)]; // Pick a random target

            // Measure Linear Search Time
            Stopwatch sw = Stopwatch.StartNew();
            int linearIndex = LinearSearch(data, target);
            sw.Stop();
            long linearTime = sw.ElapsedMilliseconds;

            // Sort Data for Binary Search
            Array.Sort(data); // O(N log N)

            // Measure Binary Search Time
            sw.Restart();
            int binaryIndex = BinarySearch(data, target);
            sw.Stop();
            long binaryTime = sw.ElapsedMilliseconds;

            // Output results
            Console.WriteLine($"Dataset Size: {N}");
            Console.WriteLine($"Linear Search Time: {linearTime} ms");
            Console.WriteLine($"Binary Search Time: {binaryTime} ms (after sorting)");
            Console.WriteLine(new string('-', 40));
        }
    }

    // Linear Search O(N)
    static int LinearSearch(int[] arr, int target)
    {
        for (int i = 0; i < arr.Length; i++)
        {
            if (arr[i] == target)
                return i;
        }
        return -1; // Not found
    }

    // Binary Search O(log N)
    static int BinarySearch(int[] arr, int target)
    {
        int left = 0, right = arr.Length - 1;
        while (left <= right)
        {
            int mid = left + (right - left) / 2;
            if (arr[mid] == target)
                return mid;
            else if (arr[mid] < target)
                left = mid + 1;
            else
                right = mid - 1;
        }
        return -1; // Not found
    }
}
