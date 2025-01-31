using System;

class DiceRoll
{
    public int RollDice()
    {
        Random rand = new Random();
        return rand.Next(1, 7);  // Random integer between 1 and 6
    }

    public static void Main()
    {
        DiceRoll dice = new DiceRoll();
        Console.WriteLine("You rolled a: " + dice.RollDice());
    }
}
