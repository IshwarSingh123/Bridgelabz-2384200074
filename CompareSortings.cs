using System;
using System.Diagnostics;

class SortingComparison
{
    static void BubbleSort(int[] array)
    {
        int n = array.Length;
        for (int i = 0; i < n - 1; i++)
        {
            for (int j = 0; j < n - i - 1; j++)
            {
                if (array[j] > array[j + 1])
                {
                    (array[j], array[j + 1]) = (array[j + 1], array[j]);
                }
            }
        }
    }

    static void MergeSort(int[] array)
    {
        if (array.Length <= 1)
            return;

        int mid = array.Length / 2;
        int[] left = new int[mid];
        int[] right = new int[array.Length - mid];

        Array.Copy(array, 0, left, 0, mid);
        Array.Copy(array, mid, right, 0, array.Length - mid);

        MergeSort(left);
        MergeSort(right);
        Merge(array, left, right);
    }

    static void Merge(int[] array, int[] left, int[] right)
    {
        int i = 0, j = 0, k = 0;
        while (i < left.Length && j < right.Length)
        {
            array[k++] = (left[i] < right[j]) ? left[i++] : right[j++];
        }
        while (i < left.Length) array[k++] = left[i++];
        while (j < right.Length) array[k++] = right[j++];
    }

    static void QuickSort(int[] array, int low, int high)
    {
        if (low < high)
        {
            int pivotIndex = Partition(array, low, high);
            QuickSort(array, low, pivotIndex - 1);
            QuickSort(array, pivotIndex + 1, high);
        }
    }

    static int Partition(int[] array, int low, int high)
    {
        int pivot = array[high];
        int i = low - 1;
        for (int j = low; j < high; j++)
        {
            if (array[j] < pivot)
            {
                i++;
                (array[i], array[j]) = (array[j], array[i]);
            }
        }
        (array[i + 1], array[high]) = (array[high], array[i + 1]);
        return i + 1;
    }

    static void Benchmark(Action<int[]> sortFunction, int[] array, string sortName)
    {
        int[] copy = (int[])array.Clone();
        Stopwatch sw = Stopwatch.StartNew();
        sortFunction(copy);
        sw.Stop();
        Console.WriteLine($"{sortName}: {sw.ElapsedMilliseconds} ms");
    }

    static void Main()
    {
        int N = 10000;
        Random rand = new Random();
        int[] array = new int[N];
        for (int i = 0; i < N; i++)
        {
            array[i] = rand.Next(0, N);
        }

        Console.WriteLine("Sorting {0} elements:", N);
        Benchmark(BubbleSort, array, "Bubble Sort");
        Benchmark(arr => MergeSort(arr), array, "Merge Sort");
        Benchmark(arr => QuickSort(arr, 0, arr.Length - 1), array, "Quick Sort");
    }
}
