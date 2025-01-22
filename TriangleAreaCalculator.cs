using System;

class TriangleAreaCalculator
{
    static void Main()
    {
        // Display message to the  user for base  input in centimeters
        Console.Write("Enter the base of the triangle in centimeters: ");
		// Taking input in centimeters
        double baseInCentimeters = Convert.ToDouble(Console.ReadLine());

		// Display message to the  user for heigth input in centimeters
        Console.Write("Enter the height of the triangle in centimeters: ");
		//Taking input of height in Centimeters
        double heightInCentimeters = Convert.ToDouble(Console.ReadLine());

        // Compute the area in square centimeters
        double areaInCentimetersSquare = 0.5 * baseInCentimeters * heightInCentimeters;

        // Convert to square inches (1 cm = 0.393701 inches)
        double baseInches = baseInCentimeters * 0.393701;
        double heightInches = heightInCentimeters * 0.393701;
        double areaInInches = 0.5 * baseInches * heightInches;

        // Display the results
        Console.WriteLine("Your area in cm square is "+areaInCentimetersSquare+" while in inches square "+areaInInches);
    }
}


//D:\c-sharp>TriangleAreaCalculator
//Enter the base of the triangle in centimeters: 5
//Enter the height of the triangle in centimeters: 6
//Your area in cm square is 15 while in inches square 2.325007161015