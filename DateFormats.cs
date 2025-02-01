/*Write a program that:
● Displays the current date in three different formats:
o dd/MM/yyyy
o yyyy-MM-dd
o EEE, MMM dd, yyyy

Hint: Use DateTime.ToString() with custom date format strings.*/
using System;

class DateFormats
{
    public static void Main()
    {
        DateTime dateTime = DateTime.Now;

	
   
        Console.WriteLine("dd/MM/dd: " + dateTime.ToString("dd/MM/dd"));
		Console.WriteLine("yyyy-MM-dd: " + dateTime.ToString("yyyy-MM-dd"));
		Console.WriteLine("EEE,MMM,dd,yyyy: " + dateTime.ToString("EEE,MMM,dd,yyyy"));
        
      
        
    }

}