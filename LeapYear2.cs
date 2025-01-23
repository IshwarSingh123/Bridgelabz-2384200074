//Write a LeapYear program that takes a year as input and outputs the Year is a Leap Year or not a Leap Year. 

using System;
	
    class LeapYear2
	{
		
        static void Main(string[] args)
		{
			
            Console.WriteLine("Enter the year: ");
            int year = Convert.ToInt32(Console.ReadLine()); // Changed to Convert.ToInt32 for correct type

				// Using a single if statement with logical operators
			if (year < 1582)
			{
				Console.WriteLine("Year should be >= 1582");
			}
			else if (year % 4 == 0 && (year % 100 != 0 || year % 400 == 0))//single statement
			{
				Console.WriteLine(year+" is a Leap Year");
			}
			else
			{
				Console.WriteLine(year+" is  Not a Leap Year");
			}
        }
    }

