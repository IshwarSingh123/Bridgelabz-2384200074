using System;

class PerimeterOfRectangle{
	
	static void Main(string[] args){
		
		Console.WriteLine("Enter the Length of a Rectangle: ");
		int length=Convert.ToInt32(Console.ReadLine());
		
		Console.WriteLine("Enter the Breadth of a Rectangle: ");
		int breadth=Convert.ToInt32(Console.ReadLine());
		
		int perimeter=2*(length+breadth);
		Console.WriteLine("Perimeter Of Rectangle " +perimeter);
	}
}