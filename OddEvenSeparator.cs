using System;

class OddEvenSeparator
{
    static void Main(string[] args)
    {
        //display message and take input
		Console.Write("Enter a natural number: ");
        int number = int.Parse(Console.ReadLine());

        if (number <= 0)
        {
            Console.WriteLine("Error: Please enter a natural number greater than 0.");
            return;
        }
		//in any natural number half of the number are odd and rest are even +1 for any case
        int[] oddNumbers = new int[number / 2 + 1];//declare array and size
        int[] evenNumbers = new int[number / 2 + 1];
        int oddIndex = 0, evenIndex = 0;//initialize two variables index of two above array

        // Separate odd and even numbers
        for (int i = 1; i <= number; i++)
        {
            if (i % 2 == 0)
            {
                evenNumbers[evenIndex] = i;
                evenIndex++;
            }
            else
            {
                oddNumbers[oddIndex] = i;
                oddIndex++;
            }
        }

        // Print odd numbers
        Console.WriteLine("Odd Numbers:");
        for (int i = 0; i < oddIndex; i++)
        {
            Console.WriteLine(oddNumbers[i] + " ");
        }

        // Print even numbers
        Console.WriteLine("Even Numbers:");
        for (int i = 0; i < evenIndex; i++)
        {
            Console.WriteLine(evenNumbers[i] + " ");
        }
    }
}
