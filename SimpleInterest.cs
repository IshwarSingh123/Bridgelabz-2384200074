using System;
	
    class SimpleInterest
{
		static void Main()
	{
            // Take user input for principal, rate, and time
            Console.Write("Enter the principal amount: ");
            double principal = double.Parse(Console.ReadLine()); 
			
			//display the message and reading the input from user
            Console.Write("Enter the rate of interest (in %): ");
            double rate = double.Parse(Console.ReadLine()); 
			
			//display the message and reading the input from user
            Console.Write("Enter the time (in years): ");
            double time = double.Parse(Console.ReadLine()); 

            // Compute simple interest
            double simpleInterest = (principal * rate * time) / 100;

            // Display the result
            Console.WriteLine("The Simple Interest is " + simpleInterest +" for Principal " + principal+", Rate of Interest " + rate + "%, and Time " + time + " years.");
        
    }
}