using System;

class QuotientRemainder
{
	
	public static int[] FindRemainderAndQuotient(int number, int divisor)
		{
			
			int quotient=number/divisor;
			int remainder=number%divisor;
			return new int[]{quotient,remainder};
		}
	public static void Main(string [] args)
	{
		
		
		
		
		Console.WriteLine("Enter the number: ");
		int number=Convert.ToInt32(Console.ReadLine());
		
		Console.WriteLine("Enter the divisior: ");
		int divisor= Convert.ToInt32(Console.ReadLine());
		
		int [] result=FindRemainderAndQuotient(number,divisor);
		
		
		
		Console.WriteLine("The Quotient is: "+result[0]);
		Console.WriteLine("The Remainder is: "+result[1]);
		
		
		
		
		
	}
}