using System; 

	class SwapingTwoNumbers
{
		static void Main()
    {
            // enter the first number from user
            Console.WriteLine("Enter first number: ");
			//Reading the value number1
            int number1 = Convert.ToInt32(Console.ReadLine()); 

            //enter the second number from user
            Console.WriteLine("Enter second number: ");
			
			//Reading the value of number2
            int number2 = Convert.ToInt32(Console.ReadLine()); 

            // Swap numbers using a temporary variable
            int temp = number1;
            number1 = number2;
            number2 = temp;

            // Display the swapped numbers
            Console.WriteLine("The swapped numbers are " + number1 + " and " + number2);
        
    }
}

