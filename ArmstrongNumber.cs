//ArmstrongNumber
using System;

class ArmstrongNumber{
	
	static void Main(string[] args)
	{
		Console.WriteLine("Enter a number: ");
		int number = Convert.ToInt32(Console.ReadLine());
		int copyNumber=number;
		double result=0;
		while(number!=0)
		{
			int digit = number%10;
			//doing cube of each digit and add to the result
			result = result+ Math.Pow(digit,3);// adding the result value on each iteration
			
			number /= 10; //updation of while loop
		}
		if(result==copyNumber)
		{
			Console.WriteLine(copyNumber+" is  Armstrong Number");
		}
		else
		{
			Console.WriteLine(copyNumber+" is Not a Armstrong Number");
		}
	}
}