public class FindFirstAndLastOccurenceOfTarget
{
    public int[] SearchRange(int[] nums, int target)
    {
        int first = FindFirstOccurrence(nums, target);
        int last = FindLastOccurrence(nums, target);
        return new int[] { first, last };
    }

    private int FindFirstOccurrence(int[] nums, int target)
    {
        int low = 0;
        int high = nums.Length - 1;
        int result = -1;

        while (low <= high)
        {
            int mid = low + (high - low) / 2;
            if (nums[mid] == target)
            {
                result = mid; // Update result and search left for earlier occurrence
                high = mid - 1;
            }
            else if (nums[mid] < target)
            {
                low = mid + 1;
            }
            else
            {
                high = mid - 1;
            }
        }
        return result;
    }

    private int FindLastOccurrence(int[] nums, int target)
    {
        int low = 0;
        int high = nums.Length - 1;
        int result = -1;

        while (low <= high)
        {
            int mid = low + (high - low) / 2;
            if (nums[mid] == target)
            {
                result = mid; // Update result and search right for later occurrence
                low = mid + 1;
            }
            else if (nums[mid] < target)
            {
                low = mid + 1;
            }
            else
            {
                high = mid - 1;
            }
        }
        return result;
    }
    static void Main(string[] args)
    {
        var obj = new FindFirstAndLastOccurenceOfTarget();
        int[] nums = { 12, 12,12,12,12,12,12,13, 14, 15, 16, 2, 3, 4, 5, 6, 7 };
        int target = 12;
        
        int occ1 = obj.FindFirstOccurrence(nums, target);
        int occ2 = obj.FindLastOccurrence(nums, target);
        Console.WriteLine($"First Occurence of element is {nums[occ1]} at index {occ1}");
        Console.WriteLine($"Last Occurence of element is {nums[occ2]} at index {occ2}");
    }
}