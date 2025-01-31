using System;

class SimpleInterest
{
	
	public double CalculateSimpleInterest(int p,double r,float t)
		{
			double interest = (p*r*t)/100;
			return interest;
			
		}
	static void Main(string [] args)
	{
		
		
		SimpleInterest si=new SimpleInterest();
		
		Console.WriteLine("Enter principle Amount: ");
		int principle=Convert.ToInt32(Console.ReadLine());
		
		Console.WriteLine("Enter the Rate: ");
		double rate=Convert.ToDouble(Console.ReadLine());
		
		Console.WriteLine("Enter Time: ");
		float time=Convert.ToSingle(Console.ReadLine());
		
		double result = si.CalculateSimpleInterest(principle,rate,time);
		Console.WriteLine("The Simple Interest is "+result+" for Principal "+principle+" , Rate of Interest "+rate+" and Time "+time);
		
		
	}
}