//7.Write a C# program to toggle the case of each character in a given string. Convert uppercase letters to lowercase and vice versa.

using System;

class Toggle
{
	
	public string ChangeCaseViceVersa(string str)
	{
		string newStr = "";
		foreach(int ch in str)
		{
			if(ch >= 97 && ch <= 122)
			{
			newStr += (char)(ch -32);
			}
			else if(ch>=65 && ch <=90)
			{
				newStr += (char)(ch+32);
			}
			else
			{
				newStr += (char)ch;
			}
			
		}
		return newStr;
		
	}
	
	
	public static void Main()
	{
		Toggle obj =new Toggle();
		Console.WriteLine("Enter a String: ");
		string str = Console.ReadLine();
		
		string strg = obj.ChangeCaseViceVersa(str);
		
		Console.WriteLine("new string is : "+strg);
		
		
	}
}