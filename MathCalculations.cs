using System;

class MathCalculations
{
    
    public double Add(double num1, double num2)
    {
        return num1 + num2;
    }

    public double Subtract(double num1, double num2)
    {
        return num1 - num2;
    }

    public double Multiply(double num1, double num2)
    {
        return num1 * num2;
    }

    public double Divide(double num1, double num2)
    {
        if (num2 == 0)
        {
            Console.WriteLine("Division by zero is not allowed.");
            return double.NaN; // Return "Not a Number" if division by zero
        }
        return num1 / num2;
    }
	public int Input(string msg)
	{
		Console.WriteLine(msg);
		int num = int.Parse(Console.ReadLine());
		return num;
		
	}
	public void Display()
	{
		double num1 = Input("Enter the first Number: ");//call input method
		double num2 = Input("Enter the second number: ");//call input method
		double addittion = Add(num1,num2);
		Console.WriteLine("Addition is "+addittion);
		
		double sub = Subtract(num1,num2);
		Console.WriteLine("Substraction  is "+sub);
		
		double mul = Multiply(num1,num2);
		Console.WriteLine("Multiplication is "+mul);
		
		double div = Divide(num1,num2);
		Console.WriteLine("Division is "+div);
		
		
	}
	public static void Main()
	{
		MathCalculations obj = new MathCalculations();
		obj.Display();
	}
}