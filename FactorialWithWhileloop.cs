//Write a Program to find the factorial of an integer entered by the user

using System;


	
	class FactorialWithWhileloop
	{
		
		static void Main(string [] args)
		{
			int factorial = 1;
			
			//display message and take input of a number
			Console.WriteLine("Enter the number to find factorial ");
			int number = Convert.ToInt32(Console.ReadLine());
			int orgNumber = number;
			
			if (number <0)
			{
				Console.WriteLine("Enter the positive number.");
			}
			else if(number == 0)
			{
				Console.WriteLine("Factorial of 0 is 1.");
			}
			else
			{    // compute the factorial of  a number
				while(number >= 1)
				{
					factorial *= number;
					number--;
				}
			Console.WriteLine("Factorial of "+orgNumber+" is "+factorial);
			}
		}
	}
