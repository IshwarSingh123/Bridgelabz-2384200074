using System;

class MultiplicationTable
{
    static void Main(string[] args)
    {
        Console.WriteLine("Enter a number: ");
        int number = int.Parse(Console.ReadLine());

        int[] tableOfNum = new int[10];//tableOfNum name of array who store 10

        // Calculate the multiplication table and store in the array
        for (int i = 1; i <= 10; i++)
        {
			//this is doing for multiplication if i take i=0 the multiclicaton of numer will be incorrect
            tableOfNum[i - 1] = number * i;
        }

        Console.WriteLine("Multiplication Table:");

        // Display the multiplication table
        for (int i = 1; i <= 10; i++)
        {
            Console.WriteLine(number + " * " + i + " = " + tableOfNum[i - 1]);
        }
    }
}
