//Write a C# program to remove all duplicate characters from a given string and return the modified string. 

using System;

class RemoveDuplicatesCharacter
{
	public string RemoveDuplicateCharacters(string str)
	{
		string modifiedString="";
		
		for(int i=0;i<str.Length;i++){
			bool isDuplicate = false;
			
			for(int j=0;j<modifiedString.Length;j++){
				
				if(str[i] == modifiedString[j]){
					isDuplicate = true;
					break;
				}
			}
			
			if(!isDuplicate)
			{
				modifiedString+=str[i];
			}
		}
		return modifiedString;
	}
	
	public static void Main(){
		
		RemoveDuplicatesCharacter obj = new RemoveDuplicatesCharacter();
		Console.WriteLine("Enter a String:");
		string str = Console.ReadLine();
		
		string newString = obj.RemoveDuplicateCharacters(str);
		Console.WriteLine("updated string: "+newString);
		
		
		
	}
}