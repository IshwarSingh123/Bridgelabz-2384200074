using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SinglyLinkedList
{
    internal class Student
    {
        public int rollNumber {  get; set; }
        public int age {  get; set; }
        public string name { get; set; }
        public  char grade {  get; set; }

        public Student next;
        public Student(int rollNumber,int age,string name,char grade)
        { 
            this.rollNumber = rollNumber;
            this.age = age;
            this.name = name;
            this.grade = grade;
            this.next = null;
        }
       

    }
}
