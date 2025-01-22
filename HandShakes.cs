using System;

class HandShakes
{
    static void Main()
    {
        // Display message to the user to enter number of students
        Console.Write("Enter the number of students: ");
		//taking input the number of students
        int numberOfStudents = Convert.ToInt32(Console.ReadLine());

        // Calculate the maximum number of handshakes using the formula: (n * (n - 1)) / 2
		// here n represents the number of students
        int handShakes = (numberOfStudents * (numberOfStudents - 1)) / 2;

        // Output the result
        Console.WriteLine("The maximum number of possible handshakes is: " + handShakes);
    }
}
