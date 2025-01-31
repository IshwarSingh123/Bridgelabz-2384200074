/*6. Factorial Using Recursion:
Write a program that calculates the factorial of a number using a recursive function.
● Include modular code to separate input, calculation, and output processes.*/
using System;

class FactorialUsingRecursion
{
	//create function to calculates factorial
	public int Factorial(int num)
	{
		if(num==0)
		{
			return 1;
		}
		return num * Factorial(num-1);//recursive approach to find factorial
	}
	public int Input(string msg)
	{
		Console.WriteLine(msg);
		int num = int.Parse(Console.ReadLine());
		return num;
		
	}
	public void Display()//method to display factorial
	{
		int number = Input("Enter a Number: ");//call input method
		int fact = Factorial(number);
		
		Console.WriteLine("Factorial of a Number is: "+fact);
	}
	public static void Main()
	{
		FactorialUsingRecursion obj = new FactorialUsingRecursion();
		obj.Display();//call display method
	}
}