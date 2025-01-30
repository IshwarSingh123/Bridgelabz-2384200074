//Write a C# program to find the most frequent character in a string. 
//success
using System;

class FrequentCharacter
{
	
	public char MostFrequentCharacter(string str)
	{
		char[] charArray = str.ToCharArray();
		
		int[] frequency = new int[256];
		
		for(int i =0;i<str.Length;i++)
		{
			frequency[str[i]]++;
		}
		
		
		char mostFrequentChar = str[0];
		int mostCount = frequency[str[0]];
		
		for(int i =1;i<str.Length;i++)
		{
			if(frequency[str[i]]>mostCount)
			{
				mostCount = frequency[str[i]];
				mostFrequentChar = str[i];
			}
		}
		return mostFrequentChar;
	}
	
	public static void Main()
	{
		FrequentCharacter freq =new FrequentCharacter();
		Console.WriteLine("Enter a String: ");
		string str = Console.ReadLine();
		
		char frequentCharacter = freq.MostFrequentCharacter(str);
		
		Console.WriteLine("Most Frequent Character is: "+frequentCharacter);
		
		
	}
}