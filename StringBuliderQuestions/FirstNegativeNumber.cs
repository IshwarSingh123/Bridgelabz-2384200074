//using System;

//class LinearSearchNegative
//{
//    static int FindFirstNegative(int[] arr)
//    {
//        for (int i = 0; i < arr.Length; i++)
//        {
//            if (arr[i] < 0)  // Check for negative number
//                return arr[i]; // Return the first negative number found
//        }
//        return 0; // Return 0 if no negative number is found
//    }

//    static void Main()
//    {
//        Console.WriteLine("Enter the number of elements:");
//        int n = Convert.ToInt32(Console.ReadLine());

//        int[] arr = new int[n];
//        Console.WriteLine("Enter the elements:");

//        for (int i = 0; i < n; i++)
//        {
//            arr[i] = Convert.ToInt32(Console.ReadLine());
//        }

//        int firstNegative = FindFirstNegative(arr);

//        if (firstNegative != 0)
//            Console.WriteLine("First negative number found: " + firstNegative);
//        else
//            Console.WriteLine("No negative number found in the array.");
//    }
//}
