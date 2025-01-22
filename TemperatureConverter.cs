// Import System namespace
using System; 
	
    class TemperatureConverter
{
		static void Main(string[] args)
	{
            // Take input from user of  temperature in Celsius
            Console.WriteLine("Enter temperature in Celsius: ");
			
			// Convert input to double
			double celsius = double.Parse(Console.ReadLine()); 

            // Convert Celsius to Fahrenheit using formula
            double fahrenheit = (celsius * 9 / 5) + 32;

            // Display the result
            Console.WriteLine(celsius + " Celsius is " + fahrenheit + " Fahrenheit");
        
    }
}

