using System;

class Program
{
    static int FindRotationPoint(int[] arr)
    {
        int left = 0, right = arr.Length - 1;

        while (left < right)
        {
            int mid = left + (right - left) / 2;

            // If mid element is greater than the last element, search in the right half
            if (arr[mid] > arr[right])
                left = mid + 1;
            else
                right = mid; // Otherwise, search in the left half
        }

        return left; // The smallest element is at index 'left'
    }

    static void Main()
    {
        int[] arr = { 15, 18, 2, 3, 6, 12 };

        int index = FindRotationPoint(arr);

        Console.WriteLine($"Smallest element is at index {index}");
    }
}
