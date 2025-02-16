using System;
using System.Text;

namespace StringBuilderQuestions
{
    class ReverseString
    {


        static void Main(string[] args)
        {
            StringBuilder sb = new StringBuilder("Hello");
            int i = 0;
            int j = sb.Length - 1;
            while (i < j)
            {
                char temp = sb[i];
                sb[i++] = sb[j];
                sb[j--] = temp;

            }
            Console.WriteLine(sb);

        }
    }
}
