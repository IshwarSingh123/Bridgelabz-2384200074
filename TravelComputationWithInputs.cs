using System; 

    class TravelComputationWithInputs
{
		
        static void Main(string[] args)
	{
            //takeing input from user 
            Console.WriteLine("Enter the traveler's name: ");
			
			// Traveler's name
            string name = Console.ReadLine(); 

            Console.WriteLine("Enter the starting city: ");
            string fromCity = Console.ReadLine(); // Starting city

            Console.WriteLine("Enter the via city: ");
            string viaCity = Console.ReadLine(); // Via city

            Console.WriteLine("Enter the destination city: ");
            string toCity = Console.ReadLine(); // Destination city

            Console.WriteLine("Enter the distance from " + fromCity + " to " + viaCity + " in miles: ");
            double distanceFromToVia = double.Parse(Console.ReadLine()); // Distance from start to via city

            Console.WriteLine("Enter the distance from " + viaCity + " to " + toCity + " in miles: ");
            double distanceViaToFinalCity = double.Parse(Console.ReadLine()); // Distance from via city to destination

            Console.WriteLine("Enter the total time taken from " + fromCity + " to " + toCity + " in minutes: ");
            int totalTime = int.Parse(Console.ReadLine()); // Total travel time in minutes

            // Compute the total distance
            double totalDistance = distanceFromToVia + distanceViaToFinalCity;

            // Convert total time into hours and minutes for better readability
            int totalHours = totalTime / 60; // Total hours
            int totalMinutes = totalTime % 60; // Remaining minutes

            // Print the travel details
            Console.WriteLine($"The results of the trip are: Traveler: {name}, Route: {fromCity} -> {viaCity} -> {toCity}, Total Distance: {totalDistance} miles, Total Time Taken: {totalHours} hours {totalMinutes} minutes");

        
    }
}