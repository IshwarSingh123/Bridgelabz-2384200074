using System;

class Fibonacci
{
	 
		public int Input(string msg)
	{
		Console.WriteLine(msg);
		int number = int.Parse(Console.ReadLine());
		return number;
		
	}
	
    public int FibonacciSeries(int num)
    {
        
        if (num == 0) return 0;
        if (num == 1) return 1;

        
        return FibonacciSeries(num - 1) + FibonacciSeries(num - 2);
    }
	public void Display()
	{
		int number = Input("Enter a number");
		//fib.FibonacciSeries(number);
		for (int i = 0; i < number; i++)
        {
            Console.Write(FibonacciSeries(i) + " ");
        }
	}

    public static void Main()
    {
		Fibonacci fib = new Fibonacci();
        fib.Display();
    }
}
