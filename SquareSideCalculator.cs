using System;

class SquareSideCalculator
{
    static void Main(string[] args)
    {
        // display message to the  user for perimeter input
        Console.WriteLine("Enter the perimeter of the square: ");
		//Take input from user
        double perimeter = Convert.ToDouble(Console.ReadLine());

        // Calculate the one side length of square
        double sideLength = perimeter / 4;

        // Display the result 
        Console.WriteLine("The length of the side is " + sideLength + " whose perimeter is " + perimeter);
    }
}
//D:\c-sharp>SquareSideCalculator
//Enter the perimeter of the square:
//40
//The length of the side is 10 whose perimeter is 40