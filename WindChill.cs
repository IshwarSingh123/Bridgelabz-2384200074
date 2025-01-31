using System;

class WindChill
{
	
	public static double CalculateWindChill(double temperature, double windSpeed) 
		{
			
			double windChill = 35.74 + 0.6215 *temperature + (0.4275*temperature - 35.75) * windSpeed*0.16 ;
			return windChill;
		}
	public static void Main(string [] args)
	{
		
		Console.WriteLine("Enter the wind temperature: ");
		double temperature = Convert.ToDouble(Console.ReadLine());
		
		Console.WriteLine("Enter the wind speed: ");
		double windSpeed = Convert.ToDouble(Console.ReadLine());
		
		double result=CalculateWindChill(temperature,windSpeed);
		
		
		
		Console.WriteLine("The wind chill is: "+result);
		
		
		
		
		
		
	}
}