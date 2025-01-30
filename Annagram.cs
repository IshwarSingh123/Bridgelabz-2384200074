//Write a C# program that accepts two strings from the user and checks if the two strings are anagrams of each other (i.e., whether they contain the same characters in any order). 
using System;

class Annagram
{
	
	public bool IsAnnagram(string str1, string str2)
	{
		if (str1.Length != str2.Length)
            return false;
		
		int[] countArray1 = new int[256];
		int[] countArray2 = new int[256];
		
		for(int i=0;i<str1.Length;i++)
		{
			countArray1[str1[i]]++;
			countArray2[str1[i]]++;
		}
		for (int i = 0; i < 256; i++)
        {
            if (countArray1[i] != countArray2[i])
                return false;
        }
		return true;
	}
	
	public static void Main()
	{
		Annagram obj =new Annagram();
		Console.WriteLine("Enter first String: ");
		string str1 = Console.ReadLine();
		
		Console.WriteLine("Enter second String: ");
		string str2 = Console.ReadLine();
		
		bool isAnnagram = obj.IsAnnagram(str1,str2);
		
		if(isAnnagram)
		{
		Console.WriteLine("String is Annagram");
		}
		else
		{
			Console.WriteLine("String is not Annagram");
		}
	
		
		
	}
}