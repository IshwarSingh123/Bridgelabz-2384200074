using System;

class SearchOperations
{
    // Linear Search: Find the first missing positive integer
    static int FindFirstMissingPositive(int[] nums)
    {
        int n = nums.Length;

        // Step 1: Mark numbers in the correct index position
        for (int i = 0; i < n; i++)
        {
            while (nums[i] > 0 && nums[i] <= n && nums[nums[i] - 1] != nums[i])
            {
                // Swap nums[i] with its correct position
                int temp = nums[nums[i] - 1];
                nums[nums[i] - 1] = nums[i];
                nums[i] = temp;
            }
        }

        // Step 2: Find the first missing positive number
        for (int i = 0; i < n; i++)
        {
            if (nums[i] != i + 1)
            {
                return i + 1; // First missing positive
            }
        }

        return n + 1; // If all numbers are present, return next positive integer
    }

    // Binary Search: Find the target index
    static int BinarySearch(int[] arr, int target)
    {
        int left = 0, right = arr.Length - 1;

        while (left <= right)
        {
            int mid = left + (right - left) / 2;

            if (arr[mid] == target)
                return mid; // Target found

            if (arr[mid] < target)
                left = mid + 1;
            else
                right = mid - 1;
        }

        return -1; // Target not found
    }

    static void Main()
    {
        int[] nums = { 3, 4, -1, 1 }; // Example array
        int missingNumber = FindFirstMissingPositive(nums);
        Console.WriteLine($"First missing positive integer: {missingNumber}");

        // Example array for binary search
        int[] sortedArray = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
        int target = 6;
        int index = BinarySearch(sortedArray, target);

        if (index != -1)
            Console.WriteLine($"Target {target} found at index: {index}");
        else
            Console.WriteLine($"Target {target} not found in the array.");
    }
}
