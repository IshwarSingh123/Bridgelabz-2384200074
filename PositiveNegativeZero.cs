using System;

class PositiveNegativeZero
{
	
	public int SeperationOfPositiveNegativeZero(int n){//n represents the number
		if(n>0)
		{
			return 1;
		}
		else if(n<0)
		{
			return -1;
		}
		else
		{
			return 0;
		}
	}
	//main method
	static void Main(string[] args){
		PositiveNegativeZero obj=new PositiveNegativeZero();//create object of class
		
		Console.WriteLine("Enter the Number: ");
		int number=Convert.ToInt32(Console.ReadLine());
		
		
		int result = obj.SeperationOfPositiveNegativeZero(number);
		
		 if (result == 1)
		 {
            Console.WriteLine("The number is positive.");
         }
        else if (result == -1)
        {
            Console.WriteLine("The number is negative.");
        }
        else
        {
            Console.WriteLine("The number is zero.");
        }
		
	}
	
}
