//Write a C# program to count the number of vowels and consonants in a given string. 
using System;

class CountVowelsAndConsonents{
	
	public static void Main(){
		Console.WriteLine("Enter a string : ");
		string text=Console.ReadLine();
		char[] charArray=text.ToCharArray();
		int countVowels = 0;
		int countConsonents = 0;
		foreach(char chr in charArray)
		{
			if(chr == 'a' || chr == 'A' || chr == 'e' || chr == 'E' || chr == 'i' || chr == 'I' || chr == 'o' || chr == 'O' || chr == 'u' || chr == 'U'){
				
				countVowels++;
			}
			
			else{
				countConsonents++;
			    if(chr == ' ')
				{
				countConsonents--;
				}
			}
				
		}
		Console.WriteLine("Number of Vowels "+countVowels);
		Console.WriteLine("Number of Consonents "+countConsonents);
	}
}