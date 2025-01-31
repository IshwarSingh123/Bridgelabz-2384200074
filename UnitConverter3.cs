using System;

class UnitConverter3
{
    
    // Temperature Conversions
    public static double ConvertFahrenheitToCelsius(double fahrenheit)
    {
        return (fahrenheit - 32) * 5 / 9;
    }

    public static double ConvertCelsiusToFahrenheit(double celsius)
    {
        return (celsius * 9 / 5) + 32;
    }

    // Weight Conversions
    public static double ConvertPoundsToKilograms(double pounds)
    {
        double poundsToKilogramsFactor = 0.453592;
        return pounds * poundsToKilogramsFactor;
    }

    public static double ConvertKilogramsToPounds(double kilograms)
    {
        double kilogramsToPoundsFactor = 2.20462;
        return kilograms * kilogramsToPoundsFactor;
    }

    // Volume Conversions
    public static double ConvertGallonsToLiters(double gallons)
    {
        double gallonsToLitersFactor = 3.78541;
        return gallons * gallonsToLitersFactor;
    }

    public static double ConvertLitersToGallons(double liters)
    {
        double litersToGallonsFactor = 0.264172;
        return liters * litersToGallonsFactor;
    }

    public static void Main(string[] args)
    {

        // Test Temperature Conversions
        Console.Write("Enter temperature in Fahrenheit: ");
        double fahrenheit = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("Temperature in Celsius: " + ConvertFahrenheitToCelsius(fahrenheit));

        Console.Write("Enter temperature in Celsius: ");
        double celsius = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("Temperature in Fahrenheit: " + ConvertCelsiusToFahrenheit(celsius));

        // Test Weight Conversions
        Console.Write("Enter weight in pounds: ");
        double pounds = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("Weight in kilograms: " + ConvertPoundsToKilograms(pounds));

        Console.Write("Enter weight in kilograms: ");
        double kilograms = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("Weight in pounds: " + ConvertKilogramsToPounds(kilograms));

        // Test Volume Conversions
        Console.Write("Enter volume in gallons: ");
        double gallons = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("Volume in liters: " + ConvertGallonsToLiters(gallons));

        Console.Write("Enter volume in liters: ");
        double liters = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("Volume in gallons: " + ConvertLitersToGallons(liters));
    }
}
