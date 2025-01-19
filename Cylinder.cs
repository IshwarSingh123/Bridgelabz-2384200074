using System;

class Cylinder{
	
	static void Main(string[] args){
	
	Console.WriteLine("Enter the Radius of Cylinder");
	
	double radius=double.Parse(Console.ReadLine());
	
	Console.WriteLine("Enter the Height of Cylinder");
	
	double height=double.Parse(Console.ReadLine());
	
	double volume=3.14*radius*radius*height;
	
	Console.WriteLine("Volume of Cylinder is: "+ volume);
	
	}
}