//Create a program to find the multiplication table of a number entered by the user from 6 to 9.

using System;
	
	class MultiplactionTable
	{
		
		static void Main(string [] args)
		{
			//take input from user for dispaly table
			Console.Write("Enter the number from 6 to 9");
			int number = Convert.ToInt32(Console.ReadLine());
			
			if(number >=6 && number<=9)
			{  //check number is between 
				for(int i = 1; i<11;i++)
				{
					int result = number*i;//compute the table
					
					Console.WriteLine(number + "*" + i +" = "+result);
				}
			}
			else
			{
					Console.WriteLine("Given number is not in range.");
			}
		}
	}
