using System;

class SimpleInterest{
	
	static void Main(string[] args){
		
		Console.WriteLine("Enter the Principal amount: ");
		int principal=Convert.ToInt32(Console.ReadLine());
		
		Console.WriteLine("Enter the Rate: ");
		double rate=Convert.ToDouble(Console.ReadLine());
		
		Console.WriteLine("Enter the Time Period in Years: ");
		double time=Convert.ToDouble(Console.ReadLine());
		
		double simpleInterest=(principal*rate*time)/100;
		
		Console.WriteLine("Simple Interest is: "+ simpleInterest);
		
	
	}
}