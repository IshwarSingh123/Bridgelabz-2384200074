//Write a LeapYear program that takes a year as input and outputs the Year is a Leap Year or not a Leap Year. 

using System;
	
    class LeapYear
	{
		
        static void Main(string[] args)
		{
			
            Console.WriteLine("Enter the year: ");
            int year = Convert.ToInt32(Console.ReadLine()); // Changed to Convert.ToInt32 for correct type

            if (year >= 1582)
			{
				
                if (year % 4 == 0)//leap year comes after 4 years
				{
					
                    if (year % 100 == 0)//check centuries year
					{
						
                        if (year % 400 == 0)//check leap year
						{
							
                            Console.WriteLine("Given year is a leap year");
                        }
						else
						{
                            Console.WriteLine("Given year is not a leap year");
                        }
                    }
					else
					{
                        Console.WriteLine("Given year is a leap year");
                    }
                }
				else
				{
                    Console.WriteLine("Given year is not a leap year");
                }
            }
			else
			{
                Console.WriteLine("Year should be >= 1582");
            }
        }
    }

