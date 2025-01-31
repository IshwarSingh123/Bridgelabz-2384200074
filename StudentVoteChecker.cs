using System;

public class StudentVoteChecker
{
    public static bool CanStudentVote(int age)
    {
        if (age < 0)
        {
            Console.WriteLine("Invalid age entered. Age cannot be negative.");
            return false;
        }

        return age >= 18;
    }

    public static void Main(string[] args)
    {
        int[] studentAges = new int[10];

        for (int i = 0; i < studentAges.Length; i++)
        {
            Console.WriteLine("Enter the age of student " + (i + 1) + ": ");
            studentAges[i] = Convert.ToInt32(Console.ReadLine());
        }

        Console.WriteLine("Voting eligibility results:");
        
        // Check voting eligibility for each student
        for (int i = 0; i < studentAges.Length; i++)
        {
            bool canVote = CanStudentVote(studentAges[i]);

            if (canVote)
            {
                Console.WriteLine("Student " + (i + 1) + " Age: " + studentAges[i] + ": Can vote");
            }
            else
            {
                Console.WriteLine("Student " + (i + 1) + " Age: " + studentAges[i] + ": Cannot vote");
            }
        }
    }
}
