using System;

class BMICalculator
{
    // Method to calculate BMI
    public static double CalculateBMI(double weight, double heightCm)
    {
        double heightMeters = heightCm / 100; // Convert height from cm to meters
        return weight / (heightMeters * heightMeters); // BMI formula
    }

    // Method to determine BMI status
    public static string DetermineBMIStatus(double bmi)
    {
        if (bmi < 18.5)
            return "Underweight";
        else if (bmi >= 18.5 && bmi < 24.9)
            return "Normal weight";
        else if (bmi >= 25 && bmi < 29.9)
            return "Overweight";
        else
            return "Obesity";
    }

    public static void Main(string[] args)
    {
        // 2D array to store weight, height, and BMI for 10 team members
        double[,] teamData = new double[10, 3];
        string[] bmiStatuses = new string[10];

        // Input weight and height for each person
        for (int i = 0; i < 10; i++)
        {
            Console.WriteLine("Enter details for person " + (i + 1) + ":");

            Console.Write("Weight (kg): ");
            teamData[i, 0] = Convert.ToDouble(Console.ReadLine());

            Console.Write("Height (cm): ");
            teamData[i, 1] = Convert.ToDouble(Console.ReadLine());

            // Calculate BMI and store in the array
            teamData[i, 2] = CalculateBMI(teamData[i, 0], teamData[i, 1]);

            // Determine BMI status
            bmiStatuses[i] = DetermineBMIStatus(teamData[i, 2]);
        }

        // Display results
        Console.WriteLine("\nTeam BMI Report:");
        Console.WriteLine("Person\tWeight (kg)\tHeight (cm)\tBMI\t\tStatus");
        for (int i = 0; i < 10; i++)
        {
            Console.WriteLine((i + 1) + "\t" + teamData[i, 0] + "\t\t" + teamData[i, 1] + "\t\t" +
                              Math.Round(teamData[i, 2], 2) + "\t\t" + bmiStatuses[i]);
        }
    }
}
