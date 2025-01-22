using System;

class DistanceConverter
{
    static void Main(string[] args)   
    {
        // Define the distance in kilometers
        double distanceInKilometers = 10.8;

        // Conversion factor from kilometers to miles 1 miles = 1.6km so from thisi 1 km= 0.62 
        double conversionValue = 1.6; //here we divide by 1.6

        // Calculate the distance in miles
        double distanceInMiles = distanceInKilometers / conversionValue;

        // Display the result
        Console.WriteLine("The distance " + distanceInKilometers + " km in miles is " + distanceInMiles);
    }
}

/*
D:\c-sharp>DistanceConvertInMiles
The distance 10.8 km in miles is 6.75
*/