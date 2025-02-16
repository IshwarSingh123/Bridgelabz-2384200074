//using System;
//using System.IO;

//class ConsoleToFile
//{
//    static void Main()
//    {
//        string filePath = "C:\\Users\\frinds system\\Desktop\\WrittenFile.txt"; // File where input will be stored

//        try
//        {
//            Console.WriteLine("Enter text to save to file (type 'exit' to stop):");

//            using (StreamWriter writer = new StreamWriter(filePath))
//            {
//                while (true)
//                {
//                    string input = Console.ReadLine();
//                    if (input.ToLower() == "exit") // Stop when user types 'exit'
//                        break;

//                    writer.WriteLine(input); // Write input to file
//                }
//            }

//            Console.WriteLine($"Your input has been saved to {filePath}");
//        }
//        catch (IOException e)
//        {
//            Console.WriteLine("Error writing to file: " + e.Message);
//        }
//    }
//}
