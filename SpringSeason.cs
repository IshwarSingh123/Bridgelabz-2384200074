/*Write a program SpringSeason that takes two int values month and day from the command line and 
prints “Its a Spring Season” otherwise prints “Not a Spring Season”. 
Hint => 
Spring Season is from March 20 to June 20
*/
using System;

class SpringSeason
{
    static void Main(string[] args)
    {
        // Ensure two arguments are passed
			if (args.Length != 2)
			{
				Console.WriteLine("Please provide exactly two arguments: month and day.");
				return;
			}

        
            //convert it into int minth and day
            int month = Convert.ToInt32(args[0]);
            int day = Convert.ToInt32(args[1]);

            // Check if the date is in the spring season
            bool isSpring = false;

            if (month == 3 && day >= 20 && day <= 31)
            {
                isSpring = true;
            }
            else if (month == 4 && day >= 1 && day <= 30)
            {
                isSpring = true;
            }
            else if (month == 5 && day >= 1 && day <= 31)
            {
                isSpring = true;
            }
            else if (month == 6 && day >= 1 && day <= 20)
            {
                isSpring = true;
            }

            // Print the result
            if (isSpring)
            {
                Console.WriteLine("It's a Spring Season");
            }
            else
            {
                Console.WriteLine("Not a Spring Season");
            }
    }

}