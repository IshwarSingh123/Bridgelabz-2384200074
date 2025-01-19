using System;

class AreaOfCircle{
	
	static void Main(string[] args){
	
	Console.WriteLine("Enter the Radius");
	
	double radius=double.Parse(Console.ReadLine());
	
	double area=3.14*radius*radius;
	
	Console.WriteLine("Area of Circle is: "+area);
	
	}
}