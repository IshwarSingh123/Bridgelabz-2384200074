/*
Write a program to count down the number from the user input value to 1 using a while loop for a rocket launch
Hint => 
Create a variable counter to take user inputted value for the countdown.
Use the while loop to check if tthe counter is 1
Inside a while loop, print the value of the counter and decrement the counter.
*/
using System;

class RocketLaunch{
	
	static void Main(string[] args){
		
		Console.Write("Enter the Counter: ");
		
		int counter=Convert.ToInt32(Console.ReadLine());
		
		while(counter>0){
			Console.WriteLine(counter);
			counter--;
		}
		
	}
}