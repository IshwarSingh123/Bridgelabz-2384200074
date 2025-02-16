//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace StringBuliderQuestions
//{
//    internal class PerformanceTrack
//    {
//        public long PerformanceCheckStringBulider(long iterations, string str)
//        {
//            StringBuilder sb = new StringBuilder();
//            long start, end;
//            start = DateTime.Now.Ticks;
//            for (int i = 0; i < iterations; i++)
//            {
//                sb.Append(str);
//            }
//            end = DateTime.Now.Ticks;
//            return end - start;
//        }

//        public long PerformanceCheckString(long iterations, string str)
//        {
//            string newStr = "";
//            long start, end;
//            start = DateTime.Now.Ticks;
//            for (int i = 0; i < iterations; i++)
//            {
//                newStr += str;
//            }
//            end = DateTime.Now.Ticks;
//            return end - start;
//        }


//    }
//    class MyClass
//    {
//        static void Main(string[] args)
//        {
//            PerformanceTrack performanceTrack = new PerformanceTrack();
//            Console.WriteLine("Enter number of Iterations to check time: ");
//            long iterations = Convert.ToInt64(Console.ReadLine());
//            Console.WriteLine("Enter the string: ");
//            string str = Console.ReadLine();

//            long time1 = performanceTrack.PerformanceCheckStringBulider(iterations, str);
//            long time2 = performanceTrack.PerformanceCheckString(iterations, str);
//            Console.WriteLine($"Time taken By StringBuilder: {time1} ticks \nTime taken By String: {time2} ticks");
//        }
//    }
//}


