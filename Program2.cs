//using System;

//class Employee
//{
//    public string Name { get; set; }
//    public int Id { get; set; }
//    public double Salary { get; set; }

//    public Employee(string name, int id, double salary)
//    {
//        Name = name;
//        Id = id;
//        Salary = salary;
//    }

//    public virtual void DisplayDetails()
//    {
//        Console.WriteLine($"Name: {Name}, ID: {Id}, Salary: {Salary:C}");
//    }
//}

//// Subclass Manager
//class Manager : Employee
//{
//    public int TeamSize { get; set; }

//    public Manager(string name, int id, double salary, int teamSize)
//        : base(name, id, salary)
//    {
//        TeamSize = teamSize;
//    }

//    public override void DisplayDetails()
//    {
//        base.DisplayDetails();
//        Console.WriteLine($"Team Size: {TeamSize}");
//    }
//}

//// Subclass Developer
//class Developer : Employee
//{
//    public string ProgrammingLanguage { get; set; }

//    public Developer(string name, int id, double salary, string programmingLanguage)
//        : base(name, id, salary)
//    {
//        ProgrammingLanguage = programmingLanguage;
//    }

//    public override void DisplayDetails()
//    {
//        base.DisplayDetails();
//        Console.WriteLine($"Programming Language: {ProgrammingLanguage}");
//    }
//}

//// Subclass Intern
//class Intern : Employee
//{
//    public string InternshipDuration { get; set; }

//    public Intern(string name, int id, double salary, string internshipDuration)
//        : base(name, id, salary)
//    {
//        InternshipDuration = internshipDuration;
//    }

//    public override void DisplayDetails()
//    {
//        base.DisplayDetails();
//        Console.WriteLine($"Internship Duration: {InternshipDuration}");
//    }
//}


//class Program
//{
//    static void Main()
//    {
//        Manager manager = new Manager("Alice", 101, 90000, 5);
//        Developer developer = new Developer("Bob", 102, 70000, "C#");
//        Intern intern = new Intern("Charlie", 103, 30000, "3 months");

//        Console.WriteLine("Manager Details:");
//        manager.DisplayDetails();
//        Console.WriteLine();

//        Console.WriteLine("Developer Details:");
//        developer.DisplayDetails();
//        Console.WriteLine();

//        Console.WriteLine("Intern Details:");
//        intern.DisplayDetails();
//    }
//}
