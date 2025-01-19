using System;

class Conversion{
	
	static void Main(string[] args){
		
		Console.WriteLine("Enter the temperature in Celsius: ");
		int celsius=Convert.ToInt32(Console.ReadLine());
		
		int fahrenheit= (celsius*9/5)+32;
		
		Console.WriteLine("Temperature in Fahrenheit: "+ fahrenheit);
		
	}
}