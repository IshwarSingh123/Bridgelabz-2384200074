using System;

class CalculateProfitAndLoss
{
    static void Main(string[] args)
    {
        // creating variables name cost price and selling price
        double costPrice = 129;
        double sellingPrice = 191;

        // Calculate profit and loss
        double profit = sellingPrice-costPrice;
        double profitPercentage = (profit/costPrice)*100;

        // for single line we use \n for new line
        Console.WriteLine("The Cost Price is INR " + costPrice + " and Selling Price is INR " + 
		sellingPrice +"\n" + "The Profit is INR " + profit + " and the Profit Percentage is " + profitPercentage);
    }
}

/* D:\c-sharp>CalculateProfitAndLoss
The Cost Price is INR 129 and Selling Price is INR 191
The Profit is INR 62 and the Profit Percentage is 48.062015503876 */