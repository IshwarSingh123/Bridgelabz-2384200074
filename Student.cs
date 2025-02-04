using System;
public class Student
{
   //static variable to store the name of the university
   public static string universityName = "GLA University";

   //static variable to count the total number of students
   private static int totalStudents = 0;

   //instance variables for student details
   public string name;
   public readonly int rollNumber;
   public string grade;

   //to get university name
   public string GetUniversityName()
   {
       return universityName;
   }

   //to get student name
   public string GetStudentName()
   {
       return name;
   }

   //to get roll number
   public int GetRollNo()
   {
       return rollNumber;
   }

   //to get grade
   public string GetGrade()
   {
       return grade;
   }

   //constructor to initialize student details
   public Student(string name, int rollNumber, string grade)
   {
       this.name = name;
       this.rollNumber = rollNumber;
       this.grade = grade;
       totalStudents++;
   }

   //method to get the total number of students
   public static void DisplayTotalStudents()
   {
       Console.WriteLine("Total Students: {0}", totalStudents);
   }

   //method to display student details
   public void DisplayStudentDetails()
   {
       if (this is Student)
       {
           Console.WriteLine("Student Name: {0}\nRoll Number: {1}\nGrade: {2}\n", GetStudentName(), GetRollNo(), GetGrade());
       }
       else
           Console.WriteLine("Invalid student!");
   }
}

class Program5s
{
   static void Main(string[] args)
   {
       //creating student object
       Student student1 = new Student("Prabhat Kumar", 1669, "O");
       //displaying student details using 'DisplayStudentDetails()' method
       student1.DisplayStudentDetails();

       //creating student object and displaying details using 'DisplayStudentDetails' method
       Student student2 = new Student("Ramshankar Sharma", 1400, "D");
       //displaying student details using 'DisplayStudentDetails()' method
       student2.DisplayStudentDetails();

       //displaying total employees
       Student.DisplayTotalStudents();
   }
}