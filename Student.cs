//using System;

//class Student
//{
//    public int rollNumber; // Public: Accessible from anywhere
//    protected string name; // Protected: Accessible in derived classes
//    private double CGPA; // Private: Only accessible within this class

//    // Constructor
//    public Student(int rollNumber, string name, double CGPA)
//    {
//        this.rollNumber = rollNumber;
//        this.name = name;
//        this.CGPA = CGPA;
//    }

//    // Public method to get CGPA
//    public double GetCGPA()
//    {
//        return CGPA;
//    }

//    // Public method to set CGPA
//    public void SetCGPA(double newCGPA)
//    {
//        if (newCGPA >= 0.0 && newCGPA <= 10.0) // Validating CGPA range
//        {
//            CGPA = newCGPA;
//        }
//        else
//        {
//            Console.WriteLine("Invalid CGPA. Please enter a value between 0.0 and 10.0.");
//        }
//    }

//    // Display student details
//    public virtual void DisplayStudentDetails()
//    {
//        Console.WriteLine("Roll Number: " + rollNumber + ", Name: " + name + ", CGPA: " + GetCGPA());
//    }
//}

//// Subclass demonstrating use of protected member
//class PostgraduateStudent : Student
//{
//    private string specialization;

//    // Constructor
//    public PostgraduateStudent(int rollNumber, string name, double CGPA, string specialization)
//        : base(rollNumber, name, CGPA)
//    {
//        this.specialization = specialization;
//    }

//    // Override method to display postgraduate details
//    public override void DisplayStudentDetails()
//    {
//        Console.WriteLine("Roll Number: " + rollNumber + ", Name: " + name + ", CGPA: " + GetCGPA() + ", Specialization: " + specialization);
//    }
//}

//// Main method to test the classes
//class Program
//{
//    public static void Main()
//    {
//        // Creating a Student object
//        Student student1 = new Student(101, "Ishwar Singh", 8.5);
//        student1.DisplayStudentDetails();

//        // Modifying CGPA
//        Console.WriteLine("\nUpdating CGPA...");
//        student1.SetCGPA(9.2);
//        student1.DisplayStudentDetails();

//        // Creating a PostgraduateStudent object
//        PostgraduateStudent pgStudent = new PostgraduateStudent(201, "Bob Johnson", 9.0, "Machine Learning");
//        Console.WriteLine("\nPostgraduate Student Details:");
//        pgStudent.DisplayStudentDetails();
//    }
//}
