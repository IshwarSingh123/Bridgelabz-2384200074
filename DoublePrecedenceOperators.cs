using System;
	
    class DoublePrecedenceOperators
{
		
        static void Main(string[] args)
	{
            // take input from user
            Console.WriteLine("Enter value for a: ");
			// Convert input to double
            double a = Convert.ToDouble(Console.ReadLine()); 
			
			// Display message for input the value variable
            Console.WriteLine("Enter value for b: ");
			// Convert input to double
            double b = Convert.ToDouble(Console.ReadLine()); 

            Console.WriteLine("Enter value for c: ");
            double c = Convert.ToDouble(Console.ReadLine()); // Convert input to double

            // Perform double operations based on precedence
			// Multiplication first, then addition
            double result1 = a + b * c; 
			// Multiplication first, then addition
            double result2 = a * b + c;
			// Division first, then addition
            double result3 = c + a / b; 
		    // Modulus first, then addition
            double result4 = a % b + c; 

            // Display the results
            Console.WriteLine("The results of Int Operations are " + result1 + ", " + result2 + ", " + result3 + ", and " + result4);
        
    }
}

