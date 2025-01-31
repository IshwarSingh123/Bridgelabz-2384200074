/*
Write a program that takes a year as input and outputs the Year is a Leap Year or not 
Hint => 
a.               The LeapYear program only works for year >= 1582, corresponding to a year in the 
                  Gregorian calendar. 
b.               Also Leap year is divisible by 4 and not divisible by 100 or divisible by 400
c.                Write a method to check for Leap Year using the conditions a and b
*/
using System;
 
class LeapYear
{
	public static bool IsLeapYear(int year)
	{
		bool isLeapYear=false;
		if(year%4==0)
		{
			if(year%100!=0 || year%400==0)
			{
					isLeapYear=true;
			}
		}
		return isLeapYear;
	}
	
	public static void Main()
	{
		Console.WriteLine("Enter a year: ");
		int year = int.Parse(Console.ReadLine());
		
		if(year<1582){
			 Console.WriteLine("It is not a Valide year");
			 Environment.Exit(0);
		}
			
		bool leapYear = IsLeapYear(year);
		
		
		
		if(leapYear){
			Console.WriteLine("It is a leap year");
		}
		else{
			Console.WriteLine("It is not a leap year");
		}
		
		
	}
}
