using System; 
	class DivideChocolatesInChildrens
{
        static void Main(string [] args)
   {
            // Take user input for number of chocolates and children
            Console.WriteLine("Enter the total number of chocolates: ");
			
			//Taking the input
            int numberOfChocolates = Convert.ToInt32(Console.ReadLine()); 
			
			
			//display the message to the user
            Console.WriteLine("Enter the number of children: ");
			//reading the value
            int numberOfChildren = Convert.ToInt32(Console.ReadLine()); 

            // Calculate chocolates each child gets and the remaining chocolates
            int chocolatesPerChild = numberOfChocolates / numberOfChildren;
            int remainingChocolates = numberOfChocolates % numberOfChildren;

            // Display the result
            Console.WriteLine("The number of chocolates each child gets is " + chocolatesPerChild +" and the number of remaining chocolates is " + remainingChocolates + ".");
        
    }
}