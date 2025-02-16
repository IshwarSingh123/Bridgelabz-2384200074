using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CountSort
{
    internal class CountingSort
    {
        public static void CountSort(int[] arr, int min, int max)
        {
            int range = max - min + 1;
            int[] count = new int[range];  // Count array
            int[] output = new int[arr.Length]; // Sorted output array

            // Step 1: Count occurrences of each age
            for (int i = 0; i < arr.Length; i++)
            {
                count[arr[i] - min]++;
            }

            // Step 2: Compute cumulative frequency
            for (int i = 1; i < range; i++)
            {
                count[i] += count[i - 1];
            }

            // Step 3: Place elements in correct position in output array
            for (int i = arr.Length - 1; i >= 0; i--)
            {
                output[count[arr[i] - min] - 1] = arr[i];
                count[arr[i] - min]--;
            }

            // Copy sorted elements back to original array
            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = output[i];
            }
        }
    }
}
namespace CountSort {
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the number of students:");
            int num = Convert.ToInt32(Console.ReadLine());

            int[] ages = new int[num];

            Console.WriteLine($"Enter {num} student ages (between 10 and 18):");
            for (int i = 0; i < num; i++)
            {
                ages[i] = Convert.ToInt32(Console.ReadLine());

                // Validate input range
                if (ages[i] < 10 || ages[i] > 18)
                {
                    Console.WriteLine("Invalid age! Please enter ages between 10 and 18.");
                    i--;  // Ask for input again
                }
            }

            Console.WriteLine("\nUnsorted Student Ages:");
            Console.WriteLine(string.Join(" ", ages));

            // Perform Counting Sort
            CountingSort.CountSort(ages, 10, 18);

            Console.WriteLine("\nSorted Student Ages:");
            Console.WriteLine(string.Join(" ", ages));
        }
    }
}