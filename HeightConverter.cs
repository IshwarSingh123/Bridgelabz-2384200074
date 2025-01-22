using System;

class HeightConverter
{
    static void Main()
    {
        // display message to the  user for height input in centimeters
        Console.Write("Enter your height in centimeters: ");
		
		// taking input from user in centemeters
        double heightCm = Convert.ToDouble(Console.ReadLine());

        // Conversion factors
        double totalInches = heightCm / 2.54;
		
		// Get the whole number of feet
        int feet = (int)(totalInches / 12);  
		
		// Get the remaining inches
        double inches = totalInches % 12;    

        // Print the result
        Console.WriteLine("Your height in cm is "+ heightCm+", while in feet is "+feet+" and inches is "+inches);
    }
}

//D:\c-sharp>HeightConverter
//Enter your height in centimeters: 177
//Your height in cm is 177, while in feet is 5 and inches is 9.68503937007874