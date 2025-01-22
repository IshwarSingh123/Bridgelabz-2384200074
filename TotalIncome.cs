using System; 

	
    class TotalIncome
{
			static void Main(string[] args)
	{
            //taking salary as input from user
            Console.WriteLine("Enter salary of the User: ");
// Convert input to double

            double salary = Convert.ToDouble(Console.ReadLine()); 
            //taking bonus from user
            Console.WriteLine("Enter bonus: ");
            double bonus = Convert.ToDouble(Console.ReadLine()); // Convert input to double

            // Compute total income of a employee
            double totalIncome = salary + bonus;

            // Display the totalIncome
            Console.WriteLine("The salary is INR " + salary + " and bonus is INR " + bonus + ". Hence Total Income is INR " + totalIncome);
 
    }
}