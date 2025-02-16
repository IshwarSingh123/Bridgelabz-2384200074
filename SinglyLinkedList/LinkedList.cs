using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Transactions;
using System.Xml.Linq;

namespace SinglyLinkedList
{
    internal class LinkedList
    {
        int count = 0;
        Student head;
        public void GetStudentDetails(out int rollNumber, out int age, out string name, out char grade)
        {
            Console.WriteLine("Enter the student rollno:");
            rollNumber = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter the student age:");
            age = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter the name of the student:");
            name = Console.ReadLine();
            Console.WriteLine("enter the grade of the student");
            grade = Console.ReadLine()[0];


        }
        public void AddAtBegnning()
        {
            int rollNumber;
            int age;
            string name;
            char grade;
            GetStudentDetails(out rollNumber, out age, out name, out grade);
            Student newstudent = new Student(rollNumber, age, name, grade);
            if (head == null)
            {
                head = newstudent;
                return;
            }
            else
            {
                newstudent.next = head;
                head = newstudent;
            }
            count++;
        }

        public void AddStudentAtTheEnd()
        {
            int rollNumber;
            int age;
            string name;
            char grade;
            GetStudentDetails(out rollNumber, out age, out name, out grade);
            Student newstudent = new Student(rollNumber, age, name, grade);

            if (head == null)
            {
                head = newstudent;
                count++;
                return;
            }
            Student temp = head;
            while (temp.next != null)
            {
                temp = temp.next;

            }
            temp.next = newstudent;
            count++;

        }

        public void AddAtSpecificPosition()
        {
            Student temp = head;
            Console.WriteLine("Enter the Position You want:");
            int position = int.Parse(Console.ReadLine());

            if (position < 1 || position > count + 1)  // Check for invalid positions
            {
                Console.WriteLine("Invalid position! Please enter a valid position between 1 and " + (count + 1));
                return;
            }

            if (position == 1)
            {
                AddAtBegnning();
                return;

            }
            if (position == count + 1)//count means total no of nodes 
            {
                AddStudentAtTheEnd();
                return;
            }
            int current = 1;

            int rollNumber;
            int age;
            string name;
            char grade;
            GetStudentDetails(out rollNumber, out age, out name, out grade);
            Student newstudent = new Student(rollNumber, age, name, grade);
            while (current < position - 1)
            {
                temp = temp.next;
                current++;
            }
            newstudent.next = temp.next;
            temp.next = newstudent;
            count += 1;


        }

        public void DeleteStudent(int rollNumber)
        {
            Student temp = head;
            Student prev=null;

            if (head == null)
            {
                Console.WriteLine("List is Empty");
            }
            if(rollNumber == temp.rollNumber)
            {
                head = temp.next;
                Console.WriteLine("Student deleted successfully");
                count--;
                return;
            }
            while (temp != null && rollNumber!=temp.rollNumber)
            {
                prev= temp;
                temp = temp.next;
            }
            if (temp == null)
            {
                Console.WriteLine("Stuent does not exist");
            }
            else
            {
                prev.next = temp.next;
                Console.WriteLine("Student deleted successfully");
                count--;

            }
            
            
        }

        public void SearchStudent(int rollNumber)
        {
            Student temp= head;
            if (head == null)
            {
                Console.WriteLine("List is Empty");
            }
            if(rollNumber == temp.rollNumber)
            {
                Console.WriteLine("Student Found! ");

                Console.WriteLine($"Student roll number is: {temp.rollNumber}");
                Console.WriteLine($"Student age is: {temp.age}");
                Console.WriteLine($"Student name  is: {temp.name}");
                Console.WriteLine($"Student grade  is: {temp.grade}");
            }
           

            while (temp != null && temp.rollNumber != rollNumber)
            {
                temp = temp.next;
            }

            if (temp == null)
            {
                Console.WriteLine("Stuent does not exist");
            }
            else
            {
                Console.WriteLine("Student Found! ");
                Console.WriteLine($"Student roll number is: {temp.rollNumber}");
                Console.WriteLine($"Student age is: {temp.age}");
                Console.WriteLine($"Student name  is: {temp.name}");
                Console.WriteLine($"Student grade  is: {temp.grade}");
            }
               
        }

        public void UpdateGrade(int rollNumber,char newGrade)
        {
            Student temp = head;

            if(head == null)
            {
                Console.WriteLine("List is Empty");
            }
            if (rollNumber == temp.rollNumber)
            {
               
                temp.grade = newGrade;
                Console.WriteLine("Grade update successfully!");
            }

            while(temp!=null && temp.rollNumber != rollNumber)
            {
                temp = temp.next;
            }
            if(temp == null)
            {
                Console.WriteLine("Student Does not exist:");
            }
            else
            {
                temp.grade = newGrade;
                Console.WriteLine("Grade update successfully!");
            }
        }
    

        public void DisplayDetails()
        {
            Student temp = head;
            if (temp == null)
            {
                Console.WriteLine("List is empty");
            }
            else
            {
                while (temp != null)
                {
                    Console.WriteLine($"Student roll number is: {temp.rollNumber}");
                    Console.WriteLine($"Student age is: {temp.age}");
                    Console.WriteLine($"Student name  is: {temp.name}");
                    Console.WriteLine($"Student grade  is: {temp.grade}");
                    temp = temp.next;
                    Console.WriteLine();
                }
            }
            
           
        }

        public void Run()
        {
            while(true)
            {
                Console.WriteLine(" Choose the operation: ");
                Console.WriteLine(" 1.Add student at the beginning. \n 2.Add student at the End. \n " +
                    "3.Add At the Specific Position. \n 4.Display details. \n 5.Delete the student. \n 6.Student Search. \n " +
                    "7.Upgrade the grade of the student. \n 8.Exit.");
                int choice = int.Parse(Console.ReadLine());
                switch (choice)
                {
                    case 1:
                        AddAtBegnning();
                        break;
                    case 2:
                        AddStudentAtTheEnd();
                        break;
                    case 3:
                        AddAtSpecificPosition();
                        break;
                    case 4:
                        DisplayDetails();
                        break;
                    case 5:
                        Console.WriteLine("Enter the Roll Number to be deleted: ");
                        int rollno = int.Parse(Console.ReadLine());
                        DeleteStudent(rollno);
                        break;
                    case 6:
                        Console.WriteLine("Enter the roll number for searching:");
                        rollno = int.Parse(Console.ReadLine());
                        SearchStudent(rollno);
                        break;
                    case 7:
                        Console.WriteLine("Enter the student Roll Number for upgrading the Grade of the student");
                        rollno = int.Parse(Console.ReadLine());
                        Console.WriteLine("Enter the new grade  Grade of the student");
                        char newGrade = Console.ReadLine()[0];
                        UpdateGrade(rollno,newGrade);

                        break;


                    case 8:
                        return;
                    default:
                        Console.WriteLine("Enter valid choice!");
                        break;
                   
                }
            }

        }

    }
}
