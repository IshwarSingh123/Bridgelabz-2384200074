using System; // Import System namespace

    class TemperatureConverterIntoCelsius{
		
        static void Main(string[] args){
			
            //Take input from user of  temperature in Fahrenheit
            Console.Write("Enter temperature in Fahrenheit: ");
            double fahrenheit = double.Parse(Console.ReadLine()); // Convert input to double

            // Convert Fahrenheit to Celsius using formula
            double celsius = (fahrenheit - 32) * 5 / 9;

            // Display the result
            Console.WriteLine(fahrenheit + " Fahrenheit is " + celsius + " Celsius");
        
    }
}