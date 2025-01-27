using System;

class CalculateAgeOfTenStudents
{
    static void Main(string[] args)
    {
        int[] ages = new int[10];//declare an array of 10 students

        Console.WriteLine("Enter the ages of 10 students:");

        // Take user input for ages
        for (int i = 0; i < ages.Length; i++)//i means initial value
        {
            Console.WriteLine("Enter age for student " + (i + 1));
            ages[i] = int.Parse(Console.ReadLine());
        }

        Console.WriteLine("Voting Eligibility Results:");

        // Check each student's age and determine eligibility
        for (int i = 0; i < ages.Length; i++)
        {
            if (ages[i] < 0)//if user enter any negative age
            {
                Console.WriteLine("Invalid age entered for student " + (i + 1));
            }
            else if (ages[i] >= 18)//user can vote with 18+
            {
                Console.WriteLine("The student with the age " + ages[i] + " can vote.");
            }
            else
            {
                Console.WriteLine("The student with the age " + ages[i] + " cannot vote.");
            }
        }
    }
}
