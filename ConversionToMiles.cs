using System;

class ConversionToMiles{
	
	static void Main(string[] args){
		
		Console.WriteLine("Enter the distance in kilometer: ");
		double kilometers=Convert.ToDouble(Console.ReadLine());
		
		double miles= kilometers * 0.621371;
		
		Console.WriteLine("Distance in Miles: "+ miles);
		
	}
}