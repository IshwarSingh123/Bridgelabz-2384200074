/*Write a program to check whether a number is positive, negative, or zero.
Hint => 
Get integer input from the user and store it in the number variable.
If the number is positive, print positive.
If the number is negative, print negative.
If the number is zero, print zero. 
*/

using System;

class CheckingNumber
{
	static void Main(string [] args)
	{
		// display the message and take input from user
		Console.WriteLine("Enter a Number: ");
		int number = Convert.ToInt32(Console.ReadLine());
		
		if(number>0)
		{
			
			Console.WriteLine("The number is Positive.");
		}
		else if(number<0){
			Console.WriteLine("The number is Negative");
		}
		else{
			Console.WriteLine("The number is Zero");
			
		}
		
		
	}
}