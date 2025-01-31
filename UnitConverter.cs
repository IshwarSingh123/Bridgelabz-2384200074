/*Extend or Create a UnitConvertor utility class similar to the one shown in the notes to do the following.  Please define static methods for all the UnitConvertor class methods. 
E.g. 
public static double ConvertKmToMiles(double km) => 
a.               Method To convert kilometers to miles and return the value. Use the following code  double km2miles = 0.621371;
b.               Method to convert miles to kilometers and return the value. Use the following code  double miles2km = 1.60934;
c.                Method to convert meters to feet and return the value. Use the following code to convert  double meters2feet = 3.28084;
d.               Method to convert feet to meters and return the value. Use the following code to convert  double feet2meters = 0.3048;
*/

using System;

class UnitConverter
{
    // Static Method to convert kilometers to miles
    public static double ConvertKmToMiles(double km)
    {
        double kmToMilesFactor = 0.621371;
        return km * kmToMilesFactor;
    }
	public static double ConvertMilesToKm(double miles)
	{
		double milesToKmFactor = 1.60934;
		return miles * milesToKmFactor; 
	}
	public static double ConvertMetersToFeet(double meters)
	{
		double metersToFeetFactor = 3.28084;
		return meters * metersToFeetFactor;
	}
	
	public static double ConvertFeetToMeters(double feet)
	{
		double feetToMetersFactor = 0.3048;
		return feet * feetToMetersFactor;
	}
    public static void Main(string[] args)
    {
        // Take input from the user
        Console.Write("Enter the distance in kilometers: ");
        double km = Convert.ToDouble(Console.ReadLine());

        // Call the static method and display the result
        double miles = ConvertKmToMiles(km);
        Console.WriteLine("Distance in miles: " + miles);
		
		Console.Write("Enter the distance in  miles: ");
		double mile = Convert.ToDouble(Console.ReadLine());
		
		double kilometer = ConvertMilesToKm(mile);
		Console.WriteLine("Distance in kilometers: " + kilometer);
		
		Console.Write("Enter the distance in  meters: ");
		double meters = Convert.ToDouble(Console.ReadLine());
		
		double feet = ConvertMetersToFeet(meters);
		Console.WriteLine("Distance in feets: " + feet);
		
		Console.Write("Enter the distance in  feets: ");
		double feets = Convert.ToDouble(Console.ReadLine());
		
		double meter = ConvertFeetToMeters(feets);
		Console.WriteLine("Distance in meters: " + meter);
		
    }
}
