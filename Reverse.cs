//Write a C# program to reverse a given string without using any built-in reverse functions.
using System;

class Reverse
{
	public string ReverseString(string str)
	{
		string newString= "";
		for(int i=str.Length-1;i>=0;i--)
		{
			newString+=str[i];
		}
		return newString;
	}
	public static void  Main(){
		
		Reverse res = new Reverse();
		Console.Write("Enter a string: ");
		string str = Console.ReadLine();
		string newString = res.ReverseString(str);
		Console.WriteLine("The reversed String is: " +newString);
		
	}
}