An organization took up an exercise to find the Body Mass Index (BMI) of all the persons in the team. For this create a program to find the BMI and display the height, weight, BMI and status of each individual
Hint => 
Take input for a number of persons
Create arrays to store the weight, height, BMI, and weight status of the persons
Take input for the weight and height of the persons
Calculate the BMI of all the persons and store them in an array and also find the weight status of the persons
Display the height, weight, BMI, and weight status of each person
Use the table to determine the weight status of the person


using System;

namespace ArrayLevel2
{
    class BMICalculator
    {
        static void Main()
        {
            // Take input for the number of persons
            Console.Write("Enter the number of persons: ");
            int n = int.Parse(Console.ReadLine());

            // Initialize arrays to store height, weight, BMI, and status
            double[] height = new double[n];
            double[] weight = new double[n];
            double[] bmi = new double[n];
            string[] status = new string[n];

            // Take input for the weight and height of the persons
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine($"\nPerson {i + 1}:");
                Console.Write("Enter height (in meters): ");
                height[i] = double.Parse(Console.ReadLine());

                Console.Write("Enter weight (in kilograms): ");
                weight[i] = double.Parse(Console.ReadLine());
            }

            // Calculate BMI and determine weight status
            for (int i = 0; i < n; i++)
            {
                bmi[i] = weight[i] / (height[i] * height[i]); // BMI formula

                // Determine weight status based on BMI
                if (bmi[i] < 18.5)
                {
                    status[i] = "Underweight";
                }
                else if (bmi[i] >= 18.5 && bmi[i] < 24.9)
                {
                    status[i] = "Normal weight";
                }
                else if (bmi[i] >= 25 && bmi[i] < 29.9)
                {
                    status[i] = "Overweight";
                }
                else
                {
                    status[i] = "Obese";
                }
            }

            // Display the height, weight, BMI, and weight status of each person
            
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine($"person {i + 1} height {height[i]:F2} Weight {weight[i]:F2} BMI {bmi[i]:F2} Status {status[i]}");
            }
        }
    }
}
