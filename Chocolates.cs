using System;

class Chocolates
{
	
	public static int[] FindRemainderAndQuotient(int numberOfchocolates, int numberOfChildren) 
		{
			
			int getChocolates=numberOfchocolates/numberOfChildren;
			int remainingChocolates=numberOfchocolates%numberOfChildren;
			return new int[]{getChocolates,remainingChocolates};
		}
	public static void Main(string [] args)
	{
		
		
		
		
		Console.WriteLine("Enter the number of chocolates: ");
		int numberOfchocolates =Convert.ToInt32(Console.ReadLine());
		
		Console.WriteLine("Enter the number of childrens: ");
		int numberOfChildren= Convert.ToInt32(Console.ReadLine());
		
		int [] result=FindRemainderAndQuotient(numberOfchocolates,numberOfChildren);
		
		
		
		Console.WriteLine("The each child get Chocolates is: "+result[0]);
		Console.WriteLine("The Remaining chocolates is: "+result[1]);
		
		
		
		
		
	}
}