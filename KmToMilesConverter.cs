using System;

class KmToMilesConverter
{
    static void Main(string [] args)
    {
        //display the message for users to taking input
        Console.Write("Enter distance in kilometers: ");
		
		 // Taking input of distance in kilometers from users 
        double kilometers = Convert.ToDouble(Console.ReadLine()); 

        // Conversion factor: 1 mile = 1.6 kilometers
        double miles = kilometers / 1.6;

        // Display the result
        Console.WriteLine("The total miles is "+miles+" miles for the given "+ kilometers +" km.");
    }
}
