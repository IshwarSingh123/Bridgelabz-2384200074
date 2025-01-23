/*Write a program to check if a number is divisible by 5
I/P => number
O/P => Is the number ___ divisible by 5? ___
*/
using System;

class DivisiblityCheck
{
	static void Main(string[] args)
	{
		//define a variable name result type string
		string result="";
		
		//Display Message to the user and taking a number in input
		Console.WriteLine("Enter a Number: ");
		int number =Convert.ToInt32(Console.ReadLine());
		
		//use if codition to check number divisible 5 or not
		if(number%5==0)
		{
			result="Yes";
		}
		else
		{
			result="No";
		}
		//Display the result
		Console.WriteLine("Is the "+number+" divisible by 5? "+result);
		
		
	}
}