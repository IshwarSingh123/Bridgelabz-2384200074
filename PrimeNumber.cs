//Write a C# program that accepts two strings from the user and checks if the two strings are anagrams of each other (i.e., whether they contain the same characters in any order). 
using System;

class PrimeNumber
{
	static PrimeNumber obj =new PrimeNumber();
	
	public int Input(string msg)
	{
		Console.WriteLine(msg);
		int number = int.Parse(Console.ReadLine());
		return number;
		
	}
	
	public bool IsPrimeNumber()
	{
		
		int num = obj.Input("Enter a Number: ");
		if (num <= 1)
            return false;
        if (num == 2)
            return true;
        if (num % 2 == 0)
            return false;
		
		bool isPrime = true;
		for(int i=3;i*i<=num;i++)//efficient condition to check prime number
		{
			if(num%i==0)
			{
				isPrime = false;
			}
		}
		return isPrime;
	}
	
	public static void Main()
	{
		
		bool isPrime = obj.IsPrimeNumber();
		if(isPrime)
		{
			Console.WriteLine("number is Prime");
		}
		else
		{
			Console.WriteLine("number is not Prime");
		}
	
		
		
	}
}