namespace InsertionSort
{
    class Program
    {

        static void Main(string[] args)
        {
            Console.WriteLine("Enter the number of Employee");
            int employee = Convert.ToInt32(Console.ReadLine());

            int[] arr = new int[employee];


            for (int i = 0; i < employee; i++)
            {
                Console.WriteLine($"Enter the {i + 1}. employee ID: ");
                arr[i] = Convert.ToInt32(Console.ReadLine());
            }

            Insertion insertion = new Insertion();
            insertion.Display(arr);

            insertion.Sort(arr);
            Console.WriteLine("Employee ID afrter bubble sorting ");
            insertion.Display(arr);


        }
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InsertionSort
{
    internal class Insertion
    {
        public void Sort(int[] arr)
        {
            int len = arr.Length;

            for (int i = 0; i < len; i++)
            {
                int index = i;
                while (index > 0 && arr[index - 1] > arr[index])
                {
                    int temp = arr[index - 1];
                    arr[index-1] = arr[index];
                    arr[index] = temp;
                    index--;
                }
            }
        }

        public void Display(int[] arr)
        {
            int len = arr.Length;

            for (int i = 0; i < len; i++)
            {
                Console.WriteLine(arr[i] + "");
            }
        }
    }
}