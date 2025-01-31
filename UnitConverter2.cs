/*
    Extend or Create a UnitConvertor utility class similar to the one shown in the notes to do the following.  Please define static methods for all the UnitConvertor class methods.
	E.g. 
public static double ConvertYardsToFeet(double yards) => 
a.               Method to convert yards to feet and return the value. Use following code to convert  double yards2feet = 3;
b.               Method to convert feet to yards and return the value. Use following code to convert  double feet2yards = 0.333333;
c.                Method to convert meters to inches and return the value. Use following code to convert  double meters2inches = 39.3701;
d.               Method to convert inches to meters and return the value. Use following code to convert  double inches2meters = 0.0254;
e.               Method to convert inches to centimeters and return the value. Use the following code  double inches2cm = 2.54;
*/
using System;

class UnitConverter2
{
    // Static Method to convert 
    public static double ConvertYardsToFeet(double yard)
    {
        double yardsToFeetFactor = 3;
        return  yard * yardsToFeetFactor;
    }
	public static double ConvertFeetToYards(double feet)
	{
		double feetToYardsFactor = 0.333333;
		return feet * feetToYardsFactor; 
	}
	public static double ConvertMetersToInches(double meters)
	{
		double metersToInchesFactor = 39.3701;
		return meters * metersToInchesFactor;
	}
	
	public static double ConvertInchesToMeters(double Inches)
	{
		double inchesToMetersFactor = 0.0254;
		return Inches * inchesToMetersFactor;
	}
	
	public static double ConvertCentimetersToInches(double centimeters)
	{
		double centimetersToInchesFactor = 2.54;
		return centimeters * centimetersToInchesFactor;
	}
    public static void Main(string[] args)
    {
        // Take input from the user
        Console.Write("Enter the distance in Yards: ");
        double yards = Convert.ToDouble(Console.ReadLine());

        // Call the static method and display the result
        double feets = ConvertYardsToFeet(yards);
        Console.WriteLine("Distance in feets: " + feets);
		
		Console.Write("Enter the distance in  feets: ");
		double feet = Convert.ToDouble(Console.ReadLine());
		
		double yard = ConvertFeetToYards(feet);
		Console.WriteLine("Distance in yards: " + yard);
		
		Console.Write("Enter the distance in  meters: ");
		double meters = Convert.ToDouble(Console.ReadLine());
		
		double inch = ConvertMetersToInches(meters);
		Console.WriteLine("Distance in Inches: " + inch);
		
		Console.Write("Enter the distance in  inches: ");
		double inches = Convert.ToDouble(Console.ReadLine());
		
		double meter = ConvertInchesToMeters(inches);
		Console.WriteLine("Distance in meters: " + meter);
		
		Console.Write("Enter the distance in  centimeters: ");
		double centi = Convert.ToDouble(Console.ReadLine());
		
		double inche = ConvertCentimetersToInches(centi);
		Console.WriteLine("Distance in Inches: " + inche);
		
    }
}
