using System;

class MaximumOfThreeNumbers
{
	//crteate function to take input
    public static int GetInput(string message)
    {
		//message passed 
        Console.WriteLine(message);
		//Read input
        int input = Convert.ToInt32(Console.ReadLine());
        return input;
    }

	// functionyo calculate maximum number amoung three numbers
    public static int FindMaximumNumber(int num1, int num2, int num3)
    {
        int maxNum = num1;
        if (num2 > maxNum)
        {
            maxNum = num2;
        }
        if (num3 > maxNum)
        {
            maxNum = num3;
        }
		// return the valur
        return maxNum;
    }
	
    public static void Main()
    {
        int number1 = GetInput("Enter the first number:");
        int number2 = GetInput("Enter the second number:");
        int number3 = GetInput("Enter the third number:");

        // call the function 
        int maximum = FindMaximumNumber(number1, number2, number3);

		//display the result
        Console.WriteLine("The maximum of the three numbers is: " + maximum);
    }
}
