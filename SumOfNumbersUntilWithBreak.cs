/*Rewrite the program 10 to find the sum until the user enters 0 or a negative number using while loop and break statement
Hint => 
Use infinite while loop as in while (true)
Take the user entry and check if the user entered 0 or a negative number to break the loop using break;*/

using System;

//Q11
using System;

class SumOfNumbersUntilWithBreak{
	
	static void Main(string[] args){
	
	
		double total = 0.0;//initialize the total variable
		Console.WriteLine("Enter a Double Value: ");
		
		double numberInDouble=Convert.ToDouble(Console.ReadLine());
		
		
			while(numberInDouble!=0){
				if(numberInDouble==0){
					break;
				}
				else{
					total+=numberInDouble;
					numberInDouble=Convert.ToDouble(Console.ReadLine());
				
				
				}
				
			}
			Console.WriteLine(total);
			
		}
		
	}