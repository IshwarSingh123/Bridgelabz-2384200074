using System;
	
    class QuotientAndRemainder{
		
        static void Main(string[] args){
			
            // take input from user for the first number
            Console.WriteLine("Enter the first number: ");
			// Convert input to integer
            int number1 = Convert.ToInt32(Console.ReadLine()); 

            // display the message to user for the second number input
            Console.Write("Enter the second number: ");
			// Convert input to integer
            int number2 = Convert.ToInt32(Console.ReadLine()); 

            // Calculate quotient using division operator
            int quotient = number1 / number2;

            // Calculate remainder using modulus operator
            int remainder = number1 % number2;

            // Display the result
            Console.WriteLine("The Quotient is "+quotient+" and Remainder is "+ remainder+ " of two numbers "+number1+" and "+number2);
        }
    }
