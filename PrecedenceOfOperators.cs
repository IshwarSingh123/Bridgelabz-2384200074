using System; 

	class PrecedenceOfOperators
{
		
        static void Main(String[] args)
	{
			
            // Display message to the user 
            Console.Write("Enter value for a: ");
			// Taking input in a variable and  Convert input to integer
            int a = Convert.ToInt32(Console.ReadLine()); 
			
			// display message to the user
            Console.Write("Enter value for b: ");
			//read the input from user
            int b = Convert.ToInt32(Console.ReadLine()); 

            Console.Write("Enter value for c: ");
            int c = Convert.ToInt32(Console.ReadLine()); 

            // Perform integer operations based on precedence
            int result1 = a + b * c; // Multiplication has higher precedence than addition
            int result2 = a * b + c; // Multiplication first, then addition
            int result3 = c + a / b; // Division first, then addition
            int result4 = a % b + c; // Modulus first, then addition

            // Display the results using concatenation
            Console.WriteLine("The results of Int Operations are " + result1 + ", " + result2 + ", " + result3 + ", and " + result4);
        
    }
}

