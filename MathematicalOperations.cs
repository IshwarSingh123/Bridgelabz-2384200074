using System;

class MathematicalOperations
{
    public int FindAbsoluteValue(int number)
    {
        return Math.Abs(number); 
    }
	
    public double CalculateSquareRoot(double number)
    {
        if (number < 0)
        {
            Console.WriteLine("Square root is not defined for negative numbers.");
            return -1;
        }
        return Math.Sqrt(number);
    }
    
    public double CalculatePower(double baseNumber, double exponent)
    {
        return Math.Pow(baseNumber, exponent);  
    }

    public static void Main()
    {
        MathematicalOperations mathOps = new MathematicalOperations();
        
        Console.WriteLine("Enter a number to find its absolute value:");
        int number = Convert.ToInt32(Console.ReadLine());
        int absoluteValue = mathOps.FindAbsoluteValue(number);
        Console.WriteLine("The absolute value of " + number + " is: " + absoluteValue);
        
        Console.WriteLine("Enter a number to find its square root:");
        double numberForSqrt = Convert.ToDouble(Console.ReadLine());
        double side = mathOps.CalculateSquareRoot(numberForSqrt); 
        if (side != -1)
        {
            Console.WriteLine("The square root of " + numberForSqrt + " is: " + side);
        }

        Console.WriteLine("Enter the base number:");
        double baseNumber = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("Enter the exponent:");
        double exponent = Convert.ToDouble(Console.ReadLine());
        double result = mathOps.CalculatePower(baseNumber, exponent);
        Console.WriteLine(baseNumber + " raised to the power of " + exponent + " is: " + result);
    }
}
