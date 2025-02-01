/*5. Palindrome Checker:
Write a program that checks if a given string is a palindrome (a word, phrase, or sequence
that reads the same backward as forward).
● Break the program into functions for input, checking the palindrome condition, and
displaying the result.*/
using System;

class PalindromeChechker
{
	
	public string Input(string msg)
	{
		Console.WriteLine(msg);
		string str = Console.ReadLine();
		return str;
	}
	public bool IsPalindromeString(string str)
	{
		bool isPalin = true;
		int j=str.Length-1;
		for(int i=0;i<str.Length;i++)
		{
			if(str[i] != str[j])
			{
				isPalin = false;
			}
			j--;
		}
		return isPalin;
	}
	public void Display()
	{
		string str = Input("Enter a string: ");
		bool isPalin = IsPalindromeString(str);
		
		if(isPalin)
			Console.WriteLine("String is Palindrome");
		else{
			Console.WriteLine("String is not Palindrome");
		}
	}
	public static void Main()
	{
		PalindromeChechker obj= new  PalindromeChechker();
		obj.Display();
	}
}