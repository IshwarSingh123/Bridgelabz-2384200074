//Create a program to find the bonus of employees based on their years of service.

using System;
	
	class BonusCalculator
	{
		
		static void Main (string[] args)
		{
			//take input for salary and year of service
			Console.WriteLine("Enter the salary");
			int salary = Convert.ToInt32(Console.ReadLine());
			
			Console.WriteLine("Enter the year of service");
			int experiance = Convert.ToInt32(Console.ReadLine());
			
			if(experiance>5)
			{
				double bonusPercentage = 5;
				//compute the bonous by using percentage formula
				double bonus = (salary*bonusPercentage)/100;
				
				Console.WriteLine("Bonus for employee is: "+ bonus);
			}
			else
			{
				Console.WriteLine("Service Year is less than 5.");
			}
		}
	}
