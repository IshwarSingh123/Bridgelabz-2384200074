/*
7. Write a Program to compute the volume of Earth in km^3 and miles^3
Hint: Volume of a Sphere is (4/3) * pi * r^3 and radius of earth is 6378 km
O/P => The volume of earth in cubic kilometers is ____ and cubic miles is ____

*/

using System;

class VolumeOfEarth
{
	static void Main(string[] args)
	{
		double radiusOfEarth = 6378;//create a vriable for storing radius of earth3963.105
		
		double toMiles=3963.105;//convert the kilometers 6378km into 3963.105 Miles
		
		//compute the volume of earth by using the formula
		double volumeOfEarth=(4.0/3.0)*(Math.PI)*(Math.Pow(radiusOfEarth,3));
		// compute the volume of earth in cubic miles
		double volumeOfEarthViaMiles= (4.0/3.0)*(Math.PI)*(Math.Pow(toMiles,3));
		
		Console.WriteLine("The volume of earth in cubic kilometers is " + volumeOfEarth +" and cubic miles is "+ volumeOfEarthViaMiles);
	}
}

//output
//D:\c-sharp>VolumeOfEarth
//The volume of earth in cubic kilometers is 1086781292542.89 and cubic miles is 260732606268.564