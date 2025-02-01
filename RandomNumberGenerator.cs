using System;

class RandomNumberGenerator
{
    
    public void GenerateRandomNumbers()
    {
        
        Random rand = new Random();
        
        
        int randomInteger = rand.Next();
        Console.WriteLine("Random Integer: " + randomInteger);
        
        
        int randomIntInRange = rand.Next(1, 101);  // Generates a number between 1 and 100
        Console.WriteLine("Random Integer in range 1 to 100: " + randomIntInRange);
        
        
        double randomDouble = rand.NextDouble();
        Console.WriteLine("Random Floating-Point Number 0 to 1: " + randomDouble);
        
        double randomCustomDouble = rand.NextDouble() * 100;  
        Console.WriteLine("Random Floating-Point Number 0 to 100: " + randomCustomDouble);
    }

    // Main method to execute the program
    public static void Main()
    {
        RandomNumberGenerator rng = new RandomNumberGenerator();
        rng.GenerateRandomNumbers();
    }
}
