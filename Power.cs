using System;

class Power{
	
	static void Main(string[] args){
		
		 Console.WriteLine("Enter the base Value: ");
         double baseNum = Convert.ToDouble(Console.ReadLine());

		 Console.WriteLine("Enter the power: ");
         double power = Convert.ToDouble(Console.ReadLine());
		 
         double result = Math.Pow(baseNum, power);
		 
		 Console.WriteLine(baseNum + " raised to the power of " + power +" is " + result);
		
	}
}