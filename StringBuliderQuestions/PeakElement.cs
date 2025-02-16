using System;

class Program
{
    static int FindPeakElement(int[] nums)
    {
        int left = 0;
        int right = nums.Length - 1;

        while (left <= right)
        {
            int mid = left + (right - left) / 2;

            // Check if mid is a peak
            bool isGreaterThanLeft = (mid == 0 || nums[mid] > nums[mid - 1]);
            bool isGreaterThanRight = (mid == nums.Length - 1 || nums[mid] > nums[mid + 1]);

            if (isGreaterThanLeft && isGreaterThanRight)
            {
                return mid; // Found a peak
            }
            else if (mid > 0 && nums[mid - 1] > nums[mid])
            {
                right = mid - 1; // Peak is in the left half
            }
            else
            {
                left = mid + 1; // Peak is in the right half
            }
        }

        return -1; // No peak found (should not happen for valid inputs)
    }

    static void Main(string[] args)
    {
        int[] nums = { 12, 12, 13, 14, 15, 16, 2, 3, 4, 5, 6, 7 };
        int peakIndex = FindPeakElement(nums);
        Console.WriteLine($"Peak element is {nums[peakIndex]} at index {peakIndex}");
    }
}