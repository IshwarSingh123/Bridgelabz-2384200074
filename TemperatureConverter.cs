using System;

class TemperatureConverter
{
	
	public double CelsiusToFehrenheit(double celsius )
	{
		double fehrenheit = 9.0/5.0*celsius+32;
		return fehrenheit;
	}
	
	public double FehrenheitToCelsius(double fehrenheit)
	{
		double celsius = 5.0/9.0*(fehrenheit-32);
		return celsius;
	}
	
	public int Input(string msg)
	{
		Console.WriteLine(msg);
		int num = int.Parse(Console.ReadLine());
		return num;
		
	}
	public void Display()
	{
		double celsius = Input("Enter the temoerature in Celsius.: ");//call input method
		double fahrenheit = Input("Enter the temperature in Fahrenheit: ");//call input method
		double fehren = CelsiusToFehrenheit(celsius);
		Console.WriteLine("temprature in fehrenheeit is "+fehren);
		
		double cels = FehrenheitToCelsius(fahrenheit);
		Console.WriteLine("temprature in Celsius is "+cels);
	}
	public static void Main()
	{
		TemperatureConverter obj =new TemperatureConverter();
		obj.Display();
	}
}