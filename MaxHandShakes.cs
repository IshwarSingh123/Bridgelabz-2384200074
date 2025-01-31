using System;

class MaxHandShakes
{
	// this method calculate the number of handshakes
	public int CalculateMaxHandShakes(int n){
		int result=(n*(n-1))/2;
		return result;
	}
	//main method
	static void Main(string[] args){
		MaxHandShakes shakes=new MaxHandShakes();//create object of of class MaxHandShakes
		
		Console.WriteLine("Enter the Number of Students: ");
		int numberOfStudents=Convert.ToInt32(Console.ReadLine());
		
		
		double result = shakes.CalculateMaxHandShakes(numberOfStudents);
		Console.WriteLine("The Number of Handshakes is "+result);
		
	}
	
}
