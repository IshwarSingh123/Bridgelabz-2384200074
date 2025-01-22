using System;

class PensDivideEqually
{
	static void Main(string[] args)
	{
		int totalPens=14;
		
		int numberOfStudents=3;
		
		int remainingPens = totalPens % numberOfStudents;
		
		int penPerStudent = totalPens / numberOfStudents;
		
		Console.WriteLine("The Pen Per Student is " + penPerStudent + " and the remaining pen not distributed is " + remainingPens);
	}
}

/* 
D:\c-sharp>PensDivideEqually
The Pen Per Student is 4 and the remaining pen not distributed is 2
*/
