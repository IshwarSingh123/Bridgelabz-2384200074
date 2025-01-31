using System;

class RandomNumberProgram
{
    // Method to generate an array of 4-digit random numbers
    public int[] GenerateRandomNumbers(int size)
    {
        Random random = new Random();
        int[] numbers = new int[size];

        for (int i = 0; i < size; i++)
        {
            numbers[i] = random.Next(1000, 10000); // Generate 4-digit numbers
        }

        return numbers;
    }

    // Method to find the average, min, and max of an array
    public double[] GetStats(int[] numbers)
    {
        int min = numbers[0];
        int max = numbers[0];
        int sum = 0;

        for (int i = 0; i < numbers.Length; i++)
        {
            sum += numbers[i];
            if (numbers[i] < min)
                min = numbers[i];
            if (numbers[i] > max)
                max = numbers[i];
        }

        double average = (double)sum / numbers.Length;
        return new double[] { average, min, max };
    }

    public static void Main(string[] args)
    {
        RandomNumberProgram program = new RandomNumberProgram();

        // Generate 5 random 4-digit numbers
        int[] randomNumbers = program.GenerateRandomNumbers(5);

        // Print the random numbers
        Console.WriteLine("Random Numbers:");
        for (int i = 0; i < randomNumbers.Length; i++)
        {
            Console.WriteLine(randomNumbers[i]);
        }

        // Get stats and print them
        double[] stats = program.GetStats(randomNumbers);
        Console.WriteLine("\nResults:");
        Console.WriteLine("Average: " + stats[0]);
        Console.WriteLine("Minimum: " + stats[1]);
        Console.WriteLine("Maximum: " + stats[2]);
    }
}
