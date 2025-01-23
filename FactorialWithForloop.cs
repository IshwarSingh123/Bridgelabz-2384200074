//Write a Program to find the factorial of an integer entered by the user using for loop.


using System;
	
	class FactorialWithForloop
	{
		
		static void Main(string[] args)
		{
			int factorial = 1;
			
			//display the message and get input
			Console.WriteLine("Enter the number to find factorial ");
			int number = Convert.ToInt32(Console.ReadLine());
			
			if (number <0)//
			{
				Console.WriteLine("Enter the positive number.");
			}
			else if(number == 0)
			{
				Console.WriteLine("Factorial of 0 is 1.");
			}
			else
			{
			for(int i = number; i>0;i-- )// find factorial of a number by using for loop
			{
				factorial *= i;
			}
			Console.WriteLine("Factorial of "+number+" is "+factorial);
			}
		}
	}
