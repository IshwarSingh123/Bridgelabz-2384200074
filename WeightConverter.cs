using System; 
	
    class WeightConverter
{
		static void Main(string[] args)
	{
            // display the message to the user ande take user input for weight in pounds
            Console.Write("Enter weight in pounds: ");
            double pounds = Convert.ToDouble(Console.ReadLine()); 

            // Converting pounds to kilograms
            double kilograms = pounds / 2.2; // 1 pound = 2.2 kg

            // Display the result
            Console.WriteLine("The weight of the person in pounds is " + pounds +" and in kilograms is " + kilograms + ".");
        
    }
}