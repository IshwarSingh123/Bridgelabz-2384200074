using System;

class SmallestAndLargest
{
    // Method to find the smallest and largest of three numbers using out parameters
	//out keyword is used to return multiple values
    public static void FindSmallestAndLargest(int number1, int number2, int number3, out int smallest, out int largest)
    {
        // Initialize smallest and largest to the first number
        smallest = number1;
        largest = number1;

        // Calculate the smallest number
        if (number2 < smallest) smallest = number2;
        if (number3 < smallest) smallest = number3;

        // Calculate the largest number
        if (number2 > largest) largest = number2;
        if (number3 > largest) largest = number3;
    }

    static void Main(string[] args)
    {
        Console.WriteLine("Enter the first number: ");
        int firstNumber = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Enter the second number: ");
        int secondNumber = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Enter the third number: ");
        int thirdNumber = Convert.ToInt32(Console.ReadLine());

        // Declare variables to hold the smallest and largest numbers
        int smallest, largest;

        // Call the method with out parameters
        FindSmallestAndLargest(firstNumber, secondNumber, thirdNumber, out smallest, out largest);

        // Display the results
        Console.WriteLine("The smallest number is: " + smallest);
		Console.WriteLine("The largest number is: " + largest);

    }
}
