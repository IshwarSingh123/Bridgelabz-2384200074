//quest 9
using System;

class RocketLaunchForLoop{
	
	static void Main(string[] args){
		
		Console.Write("Enter the Counter: ");
		
		int counter=Convert.ToInt32(Console.ReadLine());
		
		for(int i=counter;i>0;i--){
			Console.WriteLine(counter);
			counter--;
		}
		
	}
}