using System;
 
class Factors
{
	public static int[] FindFactors(int num)
	{
		int count =0;
		for(int i=1;i<num/2+1;i++)
		{
			if(num%i==0)
			{
				count++;
			}
		}
		int[] factorArray = new int[count];
		int k=0;
		for(int i=1;i<num/2+1;i++)
		{
			if(num%i==0)
			{
				factorArray[k] = i;
				k++;
			}
		}
		return factorArray;
	}
	
	public static int FindSum(int[] factorArray)
	{
		int sum=0;
		for(int i=0;i<factorArray.Length;i++)
		{
			
			sum += factorArray[i];
		}
		return sum;
	}
	
	public static int FindProduct(int[] factorArray)
	{
		int product=1;
		for(int i=0;i<factorArray.Length;i++)
		{
			
			product *= factorArray[i];
		}
		return product;
	}
	
	public static double SumOfSquare(int[] factorArray)
	{
		double sumOfSquare=0.0;
		for(int i=0;i<factorArray.Length;i++)
		{
			
			sumOfSquare += Math.Pow(factorArray[i],2);
		}
		return sumOfSquare;
	}
	
	public static void Main()
	{
		Console.WriteLine("Enter a number: ");
		int number = int.Parse(Console.ReadLine());
		
		int[] result = FindFactors(number);
		
		int sum = FindSum(result);
		
		int product= FindProduct(result);
		
		double sumSquare= SumOfSquare(result);
		
		Console.WriteLine("Factors of number");
		for(int i=0;i<result.Length;i++){
			Console.WriteLine(result[i]);
		}
		Console.WriteLine("Sum of Factors: "+sum);
		Console.WriteLine("Product of Factors: "+product);
		Console.WriteLine("Sum of Square Factors: "+sumSquare);
		
	}
}
