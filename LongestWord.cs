using System;

class LongestWord
{
	
	public string FindLongestWord(string str)
	{
		 // if (string.IsNullOrEmpty(str)) // Handle null or empty input
            // return "";
			
		string currentWord = "";
		
		int k=0;
		
		string [] newStr = new string[str.Length];
		
		for(int i=0;i<str.Length;i++)
		{
			if(str[i]== ' ')
			{
				
				if(currentWord!="")
				{
					newStr[k++] += currentWord;
					currentWord = "";
				}
				
				
				
			}
			else
			{
				
				currentWord += str[i];
				
			}
			
			
		}
		  if (currentWord != "")
		  {
            newStr[k++] = currentWord;
          }

        // If no words were found, return empty
        if (k == 0)
            return "";
		
		
		string longestWord = newStr[0];
		int countLength =longestWord.Length ;
		
		for(int i=1;i<k;i++)
		{
			if(countLength < newStr[i].Length)
			{
				countLength = newStr[i].Length;
				longestWord = newStr[i];
			}
		}
		//string a = countLength.ToString();
		//return new string [] {longestWord,a};
		return longestWord;
	}
	
	public static void Main()
	{
		LongestWord word =new LongestWord();
		Console.WriteLine("Enter a String: ");
		string str = Console.ReadLine();
		
		//string[] longestWord = word.FindLongestWord(str);
		string longestWord = word.FindLongestWord(str);
		
		Console.WriteLine("Longest word is: "+longestWord);
		
		//Console.WriteLine("Longest word is: "+longestWord[0]);
		//Console.WriteLine("Length is: "+longestWord[1]);
		
		
	}
}