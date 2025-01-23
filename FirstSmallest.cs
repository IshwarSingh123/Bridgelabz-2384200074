/*Write a program to check if the first is the smallest of the 3 numbers.
I/P => number1, number2, number3
O/P => Is the first number the smallest? ____
*/
using System;

class FirstSmallest
{
	static void Main(string[] args)
	{
		//define the string as result to hold the result
		string result="";
		
		//Display Message to the user and taking a number1,number2 and number3 in input
		Console.WriteLine("Enter the first number: ");
		//convert string into int
		int firstNumber =Convert.ToInt32(Console.ReadLine());
		
		Console.WriteLine("Enter the second number: ");
		//convert string into int
		int secondNumber =Convert.ToInt32(Console.ReadLine());//convert string into int
		
		Console.WriteLine("Enter the third number: ");
		//convert string into int
		int thirdNumber =Convert.ToInt32(Console.ReadLine());
		
		if(firstNumber<secondNumber && firstNumber<thirdNumber)
		{
			result="Yes.";
		}
		else
		{
			result="No.";
		}
		Console.WriteLine("Is the first number the smallest? "+result);
		
		
	}
}
