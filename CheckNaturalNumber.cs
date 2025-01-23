/*Write a program to check for the natural number and write the sum of n natural numbers 
Hint => 
A Natural Number is a positive integer (1,2,3, etc) sometimes with the inclusion of 0
A sum of n natural numbers is n * (n+1) / 2 
I/P => number
O/P => If the number is a positive integer then the output is
The sum of ___ natural numbers is ___
Otherwise 
The number ___ is not a natural number*/
using System;

class CheckNaturalNumber
{
	static void Main(string [] args)
	{
		
		Console.WriteLine("Enter a Number");
		int number=Convert.ToInt32(Console.ReadLine());
		
		if(number>0)
		{
			int sumOfNaturalNumbers = number * (number + 1) / 2;//calculate the sum
			//display the result
			Console.WriteLine("The sum of "+number+" natural numbers is "+sumOfNaturalNumbers);
		}
		else{
			Console.WriteLine("The number "+number+" is not a natural number");
		}
		
		
	}
}
