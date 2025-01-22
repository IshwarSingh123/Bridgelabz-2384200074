using System;

class SamMarks
{
	
	static void Main(string[] args)
	{
		//definfe the variables name marksInMath,marksInPhysics,marksInChemistry
		int marksInMath=94;
		int marksInPhysics=95;
		int marksInChemistry=96;
		// adding all variables
		int totalMarkInPcm=marksInMath+marksInPhysics+marksInChemistry;
		
		double averageMarksInPcm= totalMarkInPcm/3.0;//3.0 for decimal values occurs in averageMarksInPcm
		
		Console.WriteLine("Sam’s average mark in PCM is "+averageMarksInPcm);
		
		
	}
}

/*
D:\c-sharp>SamMarks
Sam's average mark in PCM is 95
*/