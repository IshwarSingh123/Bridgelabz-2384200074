/*Write a program to find the sum of numbers until the user enters 0
Hint => 
Create a variable total of type double initialize to 0.0. Also, create a variable to store the double value the user enters
Use the while loop to check if the user entered is 0
If the user entered value is not 0 then inside the while block add user entered value to the total and ask the user to input again
The loop will continue till the user enters zero and outside the loop display the total value
*/

using System;

class SumOfNumbersUntil{
	
	static void Main(string[] args){
		 double numberInDouble=1;//initialize number by 1
		 double total=0.0;
		 
		 while(numberInDouble!=0){
			 Console.WriteLine("Enter a number in Double Value: ");//print message
			 numberInDouble=Convert.ToDouble(Console.ReadLine());//take input in double
			 total+=numberInDouble;//compute the sum
			 
		 }
		 Console.WriteLine("Total sum of numbers"+total);
		
	}
}
