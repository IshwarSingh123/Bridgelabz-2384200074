using System;
 
class SumOfNaturalNumbers
{
	public static int CalculateSumOfNaturalNumbers(int num)
	{
		if(num==0)
		{
			return 0;
		}
		return num+CalculateSumOfNaturalNumbers(num-1);
	}
	public static int  CalculateSumOfNaturalNumbersUsingFormula(int num)
	{
		int sumUsingFormula = 0;
		sumUsingFormula = (num*(num+1))/2;
		return sumUsingFormula;
	}
	
	
	public static void Main()
	{
		Console.WriteLine("Enter a number: ");
		int number = int.Parse(Console.ReadLine());
		
		if(number<=0){
			 Console.WriteLine("It is not a Valide number");
			 Environment.Exit(0);
		}
			
		int sumUsingRecursion = CalculateSumOfNaturalNumbers(number);
		
		int sumUsingFormula = CalculateSumOfNaturalNumbersUsingFormula(number);
		
		if(sumUsingRecursion==sumUsingFormula){
			Console.WriteLine("It is Validate Sum of Natural numbers: "+sumUsingRecursion);
		}
		
		
	}
}
