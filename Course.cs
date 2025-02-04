//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace Opps
//{
//     class Course
//    {

//        private string courseName;
//        private int duration; // Duration in weeks
//        private double fee;
//        private static string instituteName = "Gla University"; // Class variable shared among all courses

//        // Constructor to initialize course details
//        public Course(string courseName, int duration, double fee)
//        {
//            this.courseName = courseName;
//            this.duration = duration;
//            this.fee = fee;
//        }

//        // Instance method to display course details
//        public void DisplayCourseDetails()
//        {
//            Console.WriteLine("Institute: " + instituteName +
//                              ", Course Name: " + courseName +
//                              ", Duration: " + duration + " weeks" +
//                              ", Fee: $" + fee);
//        }

//        // Class method to update the institute name
//        public static void UpdateInstituteName(string newName)
//        {
//            instituteName = newName;
//            Console.WriteLine("Institute name updated to: " + instituteName);
//        }

//        // Main method to test the class
//        public static void Main()
//        {
//            // Creating course objects
//            Course course1 = new Course("Web Development", 12, 500.0);
//            Course course2 = new Course("Data Science", 16, 750.0);

//            // Display initial course details
//            Console.WriteLine("Initial Course Details:");
//            course1.DisplayCourseDetails();
//            course2.DisplayCourseDetails();

//            // Update institute name
//            Console.WriteLine("\nUpdating Institute Name...");
//            Course.UpdateInstituteName("XYZ Academy");

//            // Display updated course details
//            Console.WriteLine("\nUpdated Course Details:");
//            course1.DisplayCourseDetails();
//            course2.DisplayCourseDetails();
//        }
//    }

//}

