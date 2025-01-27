using System;

class StoreValuesAndCalculateSum
{
    static void Main(string[] args)
    {
        double[] numberArray = new double[10];
        double total = 0.0;
        int index = 0;

        Console.WriteLine("Enter up to 10 numbers (enter 0 or a negative number to stop):");

        // Infinite loop to get user input
        while (true)
        {
			//message to show the user
            Console.WriteLine("Enter number " + (index + 1));
            double number = double.Parse(Console.ReadLine());

            if (number <= 0 || index == 10) // Break if input is 0, negative, or array is full
            {
                break;
            }

            numberArray[index] = number;//store the numers in an array
            index++;
        }

        Console.WriteLine("Numbers entered:");
        for (int i = 0; i < index; i++)
        {
            Console.WriteLine(numbers[i]);
            total += numbers[i];//sum all the elements of array
        }

        Console.WriteLine("Total sum of numbers: " + total);
    }
}
