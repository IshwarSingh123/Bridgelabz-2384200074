using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringBuliderQuestions
{
    internal class StringConcatenate
    {
        public string ConcatenateStrings(string[] str)
        {
            StringBuilder sb = new StringBuilder();
            foreach (string str2 in str)
            {
                sb.Append(str2).Append(" ");
            }
            return sb.ToString().Trim();
        }
    }


    class MyClass
    {

        static void Main(string[] args)
        {
            StringConcatenate stringConcatenat = new StringConcatenate();
            Console.WriteLine("Enter number of Strings: ");
            int size = int.Parse(Console.ReadLine());
            string[] strings = new string[size];

            for (int i = 0; i < size; i++)
            {
                Console.Write($"Enter string {i + 1}: ");
                strings[i] = Console.ReadLine();
            }
            string result = stringConcatenat.ConcatenateStrings(strings);
            Console.WriteLine("Concatenated String: " + result);

        }
    }
}
