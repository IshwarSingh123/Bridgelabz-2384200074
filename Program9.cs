//using System;

//class Person
//{
//    public string Name { get; set; }
//    public int Age { get; set; }

//    public Person(string name, int age)
//    {
//        Name = name;
//        Age = age;
//    }

//    public virtual void DisplayRole()
//    {
//        Console.WriteLine("General Person");
//    }
//}

//class Teacher : Person
//{
//    public string Subject { get; set; }

//    public Teacher(string name, int age, string subject)
//        : base(name, age)
//    {
//        Subject = subject;
//    }

//    public override void DisplayRole()
//    {
//        Console.WriteLine($"Teacher - Subject: {Subject}");
//    }
//}

//class Student : Person
//{
//    public string Grade { get; set; }

//    public Student(string name, int age, string grade)
//        : base(name, age)
//    {
//        Grade = grade;
//    }

//    public override void DisplayRole()
//    {
//        Console.WriteLine($"Student - Grade: {Grade}");
//    }
//}

//class Staff : Person
//{
//    public string Department { get; set; }

//    public Staff(string name, int age, string department)
//        : base(name, age)
//    {
//        Department = department;
//    }

//    public override void DisplayRole()
//    {
//        Console.WriteLine($"Staff - Department: {Department}");
//    }
//}

//class Program
//{
//    static void Main()
//    {
//        Person teacher = new Teacher("Alice", 40, "Mathematics");
//        teacher.DisplayRole();

//        Person student = new Student("Bob", 16, "10th Grade");
//        student.DisplayRole();

//        Person staff = new Staff("Charlie", 35, "Administration");
//        staff.DisplayRole();
//    }
//}
