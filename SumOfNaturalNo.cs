//Write a program to find the sum of n natural numbers using while loop.
//compare the result with the formulae n*(n+1)/2 and show the result from both computations was correct.

using System;
	
	 class SumOfNaturalNo{
		 
		  static void Main(string[] args){
			  
			  int sum = 0;
			  
			// take input as the number for where we want sum
			  Console.WriteLine("Enter the number: ");
			  int number = Convert.ToInt32(Console.ReadLine());
			  int result = (number*(number+1))/2;
			  
			  if(number >0){
				  // using while loop to calculate the sum of natural numbers
				  while(number>0){
					  sum += number;
					  number--;
				  }
				  
			  }else{
				  Console.WriteLine("Given number is not natural number. ");
			  }
			  if(result == sum){
				  Console.WriteLine("Sum of given natural number is "+sum);
			  }
			  
		}
	}
