using System;

class Add{
	
	static void Main(string[] args){
		
		Console.WriteLine("Enter First Number: ");
		int num1=int.Parse(Console.ReadLine());
		Console.WriteLine("Enter Second Number: ");
		int num2=int.Parse(Console.ReadLine());
		
		Console.WriteLine("Sum: " +(num1+num2));
	}
}