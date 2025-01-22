using System; 

    class AthleteRuns
{
        static void Main(string[] args)
	{
            // Take user input for the sides of the triangular park
            Console.WriteLine("Enter side1 (in meters): ");
            double side1 = double.Parse(Console.ReadLine()); 
			
			//taking the input from side 2
            Console.WriteLine("Enter side2 (in meters): ");
            double side2 = double.Parse(Console.ReadLine());
		
			//taking input from side 3
            Console.WriteLine("Enter side3 (in meters): ");
            double side3 = double.Parse(Console.ReadLine()); 

            // Calculate the perimeter of the triangle
            double perimeter = side1 + side2 + side3;

            // Calculate the number of rounds required to complete 5 km
            double distanceToRun = 5000; // Convert 5 km to meters
            int rounds = (int)Math.Ceiling(distanceToRun / perimeter); 

            // Display the result
            Console.WriteLine("The total number of rounds the athlete will run is " + rounds + " to complete 5 km.");
        
    }
}