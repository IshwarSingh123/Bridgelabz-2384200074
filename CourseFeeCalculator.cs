using System;

class CourseFeeCalculator
{
    static void Main(string[] args)
    {
        // creating the variables the course fee and discount percentage
        double fee = 125000;
        double discountPercent = 10;

        // Calculate the discount amount for course
        double discount = (fee * discountPercent) / 100;

        // Calculate the final discounted fee
        double discountedFee = fee - discount;

        // Print the result
        Console.WriteLine("The discount amount is INR " + discount + " and final discounted fee is INR " + discountedFee);
    }
}

/*
D:\c-sharp>CourseFeeCalculator
The discount amount is INR 12500 and final discounted fee is INR 112500
*/