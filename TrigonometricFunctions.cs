using System;

class TrigonometricFunctions
{
	
		public double[] calculateTrigonometricFunctions(double angle) 
		{
			double angleInRadians = angle*(3.14/180);
			
			double sin = Math.Sin(angleInRadians);
			double cos = Math.Cos(angleInRadians);
			double tangent = Math.Tan(angleInRadians);
			
			return new double[] {sin,cos,tangent};
			
		}
	public static void Main(string [] args)
	{
		
		
		TrigonometricFunctions obj = new TrigonometricFunctions();
		
		Console.WriteLine("Enter the angle in degree: ");
		double angle = Convert.ToDouble(Console.ReadLine());
		double[] result=obj.calculateTrigonometricFunctions(angle);
		
		
		
		Console.WriteLine("The value of sine is: "+result[0]);
		Console.WriteLine("The value of Cosine is: "+result[1]);
		
		Console.WriteLine("The value of Tangent is: "+result[2]);
		
	}
}