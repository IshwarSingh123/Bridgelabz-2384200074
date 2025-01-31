using System;

class Quadratic
{
    // Method to find the roots of the quadratic equation
    public static double[] FindRoots(double a, double b, double c)
    {
        double delta = Math.Pow(b, 2) - (4 * a * c); // Calculate delta (discriminant)

        if (delta > 0) // Two real and distinct roots
        {
            double root1 = (-b + Math.Sqrt(delta)) / (2 * a);
            double root2 = (-b - Math.Sqrt(delta)) / (2 * a);
            return new double[] { root1, root2 };
        }
        else if (delta == 0) // One real and repeated root
        {
            double root = -b / (2 * a);
            return new double[] { root };
        }
        else // No real roots (complex roots)
        {
            return new double[0]; // Return an empty array
        }
    }

    public static void Main(string[] args)
    {
        // Take inputs for coefficients a, b, and c
        Console.Write("Enter the coefficient a: ");
        double a = Convert.ToDouble(Console.ReadLine());

        Console.Write("Enter the coefficient b: ");
        double b = Convert.ToDouble(Console.ReadLine());

        Console.Write("Enter the coefficient c: ");
        double c = Convert.ToDouble(Console.ReadLine());

        // Validate that a is not zero (not a quadratic equation otherwise)
        if (a == 0)
        {
            Console.WriteLine("The coefficient 'a' cannot be zero. This is not a quadratic equation.");
            return;
        }

        // Call the FindRoots method and display the results
        double[] roots = FindRoots(a, b, c);

        if (roots.Length == 2)
        {
            Console.WriteLine("The equation has two roots:");
            Console.WriteLine("Root 1: " + roots[0]);
            Console.WriteLine("Root 2: " + roots[1]);
        }
        else if (roots.Length == 1)
        {
            Console.WriteLine("The equation has one root:");
            Console.WriteLine("Root: " + roots[0]);
        }
        else
        {
            Console.WriteLine("The equation has no real roots.");
        }
    }
}
