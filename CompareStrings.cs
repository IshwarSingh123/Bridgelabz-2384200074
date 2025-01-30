//Write a C# program to compare two strings lexicographically (dictionary order) without using built-in compare methods. 

using System;

class Lexicographically
{
	
	public string[] CompareStrings(string str1 , string str2 )
	{
		int n=0;//n represents the length of the string
		if(str1.Length<str2.Length)
		{
			
			n =str1.Length;
		}
		else
		{
			n=str2.Length;
		}
		int j=0;
		for(int i=0;i<n;i++)
		{
			if(str1[i]>str2[j])
			{
				return new string[] {str2,str1}; 
			
			}
			else if (str1[i]<str2[j])
			{
				return new string[] {str1,str2};
			}
			
		}
		return new string[] {str1,str2};
	}	
	
	
	public static void Main()
	{
		Lexicographically obj =new Lexicographically();
		Console.WriteLine("Enter first String: ");
		string str1 = Console.ReadLine();
		Console.WriteLine("Enter second String: ");
		string str2 = Console.ReadLine();
		string[] strArray = obj.CompareStrings(str1,str2);
		
		Console.WriteLine("output:"+strArray[0]);
		Console.WriteLine("output:"+strArray[1]);
		
		
	}

}