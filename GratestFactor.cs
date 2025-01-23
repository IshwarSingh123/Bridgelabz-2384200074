// Create a program to print the greatest factor of a number beside itself using a loop.
// Hint => 
// Get an integer input and assign it to the number variable. As well as define a greatestFactor variable and assign it to 1
// Create a for loop that runs from last but one till 1 as in i = number - 1 to i = 1.
// Inside the loop, check if the number is perfectly divisible by i then assign i to greatestFactor variable and break the loop.
// Display the greatestFactor variable outside the loop
// Create a program to find the power of a number.

using System;

class GreatestFactor {
    static void Main() {
        // Get the input number
        Console.Write("Enter a number: ");
        int number = Convert.ToInt32(Console.ReadLine());

        // Initialize the greatest factor variable
        int greatestFactor = 1;

        // Loop from number - 1 down to 1
        for (int i = number - 1; i >= 1; i--) {
            // Check if the number is perfectly divisible by i
            if (number % i == 0) {
                greatestFactor = i;
                break; // Exit the loop as we found the greatest factor
            }
        }

        // Display the greatest factor
        Console.WriteLine("The greatest factor of {0} (besides itself) is: {1}", number, greatestFactor);
    }
}
