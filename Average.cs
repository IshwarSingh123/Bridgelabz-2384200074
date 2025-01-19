using System;

class Average{
	
	static void Main(string[] args){
		
		Console.WriteLine("Enter the first number ");
		int num1=Convert.ToInt32(Console.ReadLine());
		
		Console.WriteLine("Enter the second number: ");
		int num2=Convert.ToInt32(Console.ReadLine());
		
		Console.WriteLine("Enter the third number: ");
		int num3=Convert.ToInt32(Console.ReadLine());
		double avg=(num1+num2+num3)/3;
		
		Console.WriteLine("Average of three number is: "+ avg);
		
	
	}
}
