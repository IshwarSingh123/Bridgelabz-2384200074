using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BubbleSort
{
    internal class Bubble
    {
        public void Sort(int[] arr)
        {
            int len = arr.Length;

            for (int i = 0; i < len -1; i++)
            {
                for (int j = 0; j < (len -i) -1; j++)
                {
                    if (arr[j] > arr[j+1])
                    {
                        int temp = arr[j+1];
                        arr[j+1] = arr[j];
                        arr[j] = temp;
                    }
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


namespace BubbleSort
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
                Console.WriteLine($"Enter the {i + 1}. Student marks");
                arr[i] = Convert.ToInt32(Console.ReadLine());
            }

            Bubble bubble = new Bubble();
            bubble.Display(arr);

            bubble.Sort(arr);
            Console.WriteLine("Array afrter bubble sorting ");
            bubble.Display(arr);


        }
    }
}