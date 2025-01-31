using System;

class TriangularPark
{
	//method calculate the number of rounds
	public double CalculateNumberOfRounds(double firstSide,double secondSide,double thirdSide)
		{
			
			double perimeter=firstSide+secondSide+thirdSide;//perimeter of the trangle
			double rounds=5000/perimeter;//5km=5000meters
			return rounds;
			
			
			
		}
	static void Main(string [] args)
	{
		
		
		TriangularPark park =new TriangularPark();
		
		Console.WriteLine("Enter the first side of traingle in meteres: ");
		double firstSide=Convert.ToDouble(Console.ReadLine());
		
		Console.WriteLine("Enter the second of traingle in meteres: ");
		double secondSide=Convert.ToDouble(Console.ReadLine());
		
		Console.WriteLine("Enter the third side of traingle in meteres: ");
		double thirdSide=Convert.ToDouble(Console.ReadLine());
		
		double result = park.CalculateNumberOfRounds(firstSide,secondSide,thirdSide);
		Console.WriteLine("Total Number Of Rounds: "+result);
		
		
	}
}