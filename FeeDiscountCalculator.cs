using System;

class FeeDiscountCalculator
{
    static void Main(string[] args)
    {
        // display message to the user for fee input
        Console.Write("Enter the student fee amount in INR: ");
		// Taking the fee as  input from user
        double fee = Convert.ToDouble(Console.ReadLine());

        // display message to the user for discount percentage
        Console.Write("Enter the university discount percentage: ");
		// Taking the fee as  input from user
        double discountPercent = Convert.ToDouble(Console.ReadLine());

        // Compute discount amount
        double discount = (discountPercent / 100) * fee;

        // Compute final fee after discount
        double finalFee = fee - discount;

        // Display the results
        Console.WriteLine("The discount amount is INR "+discount+ " and the final discounted fee is INR "+finalFee);
    }
}


//D:\c-sharp>FeeDiscountCalculator
//Enter the student fee amount in INR: 10000
//Enter the university discount percentage: 10
//The discount amount is INR 1000 and the final discounted fee is INR 9000