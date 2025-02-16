public class Solution
{
    public bool SearchMatrix(int[][] matrix, int target)
    {
        foreach (int[] row in matrix)
        {
            if (row[0] > target)
            {
                continue; // Target can't be in this row
            }
            if (row[row.Length - 1] < target)
            {
                continue; // Target can't be in this row
            }
            // Perform binary search on the current row
            int left = 0;
            int right = row.Length - 1;
            while (left <= right)
            {
                int mid = left + (right - left) / 2;
                if (row[mid] == target)
                {
                    return true;
                }
                else if (row[mid] < target)
                {
                    left = mid + 1;
                }
                else
                {
                    right = mid - 1;
                }
            }
        }
        return false;
    }

    static void Main(string[] args)
    {
        int[][] matrix = {
        new int[] {1, 3, 5, 7},
        new int[] {10, 11, 16, 20},
        new int[] {23, 30, 34, 60}
};

        Console.WriteLine(new Solution().SearchMatrix(matrix, 3));  // Output: True
        Console.WriteLine(new Solution().SearchMatrix(matrix, 13)); // Output: False
    }
}