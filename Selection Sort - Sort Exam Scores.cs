using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SelectionSort

{
    internal class Selection
    {

        public void Sort(int[] arr)
        {
            int len = arr.Length;

            for (int i = 0; i < len - 1; i++)
            {
                int minIndex = i; // Assume the first element is the smallest

                for (int j = i + 1; j < len; j++)
                {
                    if (arr[j] < arr[minIndex])
                    {
                        minIndex = j; // Update the index of the smallest element
                    }
                }

                // Swap only once
                if (minIndex != i)
                {
                    int temp = arr[i];
                    arr[i] = arr[minIndex];
                    arr[minIndex] = temp;
                }
            }
        }

        public void Display(int[] arr)
        {
            int len = arr.Length;

            for(int i = 0; i<len; i++)
            {
                Console.WriteLine(arr[i]+ "");
            }
        }
    }
}

namespace SelectionSort
{
	class Program
	{

        static void Main(string[] args)
        {
            Console.WriteLine("Enter the number of student");
            int student = Convert.ToInt32(Console.ReadLine());

            int[] arr = new int[student];

            
            for (int i = 0; i < student; i++)
            {
                Console.WriteLine($"Enter the {i+1}. Student marks");
                arr[i] = Convert.ToInt32(Console.ReadLine());
            }

            Selection selection = new Selection();
            selection.Display(arr);

            selection.Sort(arr);
            Console.WriteLine("Array afrter bubble sorting ");
            selection.Display(arr);

            
        }
    }
}