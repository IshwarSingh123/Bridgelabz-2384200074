//Create a program to print odd and even numbers between 1 to the number entered by the user.

using System;
	
	class CheckEvenOdd
	{
		
		static void Main(string[] args)
		{
			//display message and get input
			Console.WriteLine("Enter the number ");
			int number = Convert.ToInt32(Console.ReadLine());
			
			if (number <1)//number shouldbe greater than 0
			{
				Console.WriteLine("Enter the natural number. Number should be grater than 0.");
			}else
			{
				for (int i = 1;i<=number;i++)
				{
					if(i % 2 ==0)//check i is divisible by 2 or not
					{
						Console.WriteLine(i+" is an Even number");
					}else
					{
						Console.WriteLine(i+" is an odd number");
					}
				}
			}
		}
	}
