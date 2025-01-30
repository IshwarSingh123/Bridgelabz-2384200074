//Write a C# program to check if a given string is a palindrome (a string that reads the same forward and backward). 
using System;

class Palindrome
{
	public bool IsPalindrome(string str)
	{
		bool palindrone = true;
		int j= str.Length-1;
		int i=0;
		while(i<j)
		{
			if(str[i]!=str[j])
			{
				palindrome = false;
			}
			i++;
			j--;
				
		}
		return palindrome;
	}
	
	public static void Main(){
		
		Palindrome obj = new Palindrome();
		Console.WriteLine("Enter a String:");
		string str = Console.ReadLine();
		
		bool isPalindrome =obj.IsPalindrome(str);
		
		if(isPalindrome)
		{
			Console.WriteLine("String is Pailndrome: ");
		}
		else{
			Console.WriteLine("String is not Pailndrome: ");
		}
		
	}
}