using System;

class GcdAndLcm
{
	
	public int Gcd(int num1, int num2)
	{
		int min = Math.Min(num1,num2);
		//int[] array = new int[min];
		if(num1==num2)
			return num1;
		else if(num1==0)
			return num2;
		else if(num2==0)
			return num1;
		
		int gcd=1;
		for(int i=1;i<=min;i++)
		{
			if(num1%i == 0 && num2%i==0)
			{
				gcd=i;
			}
			
		}

		return gcd;
		
		
	}
	
	public int Lcm(int num1,int num2)
	{
		int lcm =1;
		int max = Math.Max(num1,num2);
		for(int i=1;i<=num1*num2;i++)
		{
			if(i%num1 == 0 && i%num2==0)
			{
				lcm = i;
			}
		}
		return lcm;
	}
	
	public int Input(string msg)
	{
		Console.WriteLine(msg);
		int num = int.Parse(Console.ReadLine());
		return num;
		
	}
	public void Display()
	{
		int num1 = Input("Enter first Number: ");//call input method
		int num2 = Input("Enter Second Number: ");//call input method
		int gcd = Gcd(num1,num2);
		Console.WriteLine("GCD is "+gcd);
		
		int lcm = Lcm(num1,num2);
		Console.WriteLine("Lcm is "+lcm);
	}
	public static void Main()
	{
		GcdAndLcm obj =new GcdAndLcm();
		obj.Display();
	}
}