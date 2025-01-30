//Write a C# program to remove all occurrences of a specific character from a string. 
using System;

class RemoveCharacter
{
	
	public string RemoveSpecificCharacter(string str , char character)
	{
		string newStr = "";
		foreach(char ch in str)
		{
			if(ch==character)
			{
				continue;
			}
			else
			{
				newStr += ch;
			}
		}
		return newStr;
	}
	
	public static void Main()
	{
		RemoveCharacter obj = new RemoveCharacter();
		Console.WriteLine("Enter a String: ");
		string str = Console.ReadLine();
		
		Console.WriteLine("Enter a character to remove: ");
		char character = (char)(Console.Read());
		//ConsoleKeyInfo key = Console.ReadKey();
		//char character = key.KeyChar;
		
		
		string result = obj.RemoveSpecificCharacter(str , character);
		
		Console.WriteLine("Modified String: "+result);
		
		
	}
}