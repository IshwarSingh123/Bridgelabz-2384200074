using System;

class TotalPriceCalculator
{
    static void Main()
    {
        // Input the unit price 
        Console.Write("Enter the unit price of the item (in INR): ");
		// Taking input of unitPrice
        double unitPrice = Convert.ToDouble(Console.ReadLine());
        
		// display the message to the user to enter the quantity
        Console.Write("Enter the quantity to be bought: ");
		//Taking input the quantity
        int quantity = Convert.ToInt32(Console.ReadLine());
        
        // Calculate the total price
        double totalPrice = unitPrice * quantity;
        
        // display the result
        Console.WriteLine("The total purchase price is INR " + totalPrice +
                          " if the quantity is " + quantity + " and the unit price is INR " + unitPrice);
    }
}
//D:\c-sharp>TotalPriceCalculator
//Enter the unit price of the item (in INR): 89000
//Enter the quantity to be bought: 6
//The total purchase price is INR 534000 if the quantity is 6 and the unit price is INR 89000