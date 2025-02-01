
/*Write a program that:
● Takes two date inputs and compares them to check if the first date is
before, after, or the same as the second date.

Hint: Use DateTime.Compare(), DateTime.CompareTo(), or direct comparison
using DateTime methods.*/

using System;

class DateComparison
{
    public static void Main()
    {
        
            Console.Write("Enter the first date (yyyy-MM-dd): ");
            DateTime firstDate = DateTime.Parse(Console.ReadLine());

            Console.Write("Enter the second date (yyyy-MM-dd): ");
            DateTime secondDate = DateTime.Parse(Console.ReadLine());

            
            int result = firstDate.CompareTo(secondDate);

            if (result < 0)
                Console.WriteLine("The first date is before the second date.");
            else if (result > 0)
                Console.WriteLine("The first date is after the second date.");
            else
                Console.WriteLine("Both dates are the same.");
        
        
    }
}
     
    