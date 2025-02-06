using System;
using System.Collections.Generic;

// Course class (Independent Entity)
class Course
{
    public string CourseName { get; }
    private List<Student> students; // Many-to-Many Relationship

    public Course(string courseName)
    {
        CourseName = courseName;
        students = new List<Student>();
    }

    public void EnrollStudent(Student student)
    {
        if (!students.Contains(student))
        {
            students.Add(student);
            student.AddCourse(this); // Ensures bidirectional relationship
        }
    }

    public void ShowEnrolledStudents()
    {
        Console.WriteLine($"Students enrolled in {CourseName}:");
        foreach (var student in students)
        {
            Console.WriteLine($"- {student.Name}");
        }
    }
}

// Student class (Independent Entity)
class Student
{
    public string Name { get; }
    private List<Course> courses; // Many-to-Many Relationship

    public Student(string name)
    {
        Name = name;
        courses = new List<Course>();
    }

    public void AddCourse(Course course)
    {
        if (!courses.Contains(course))
        {
            courses.Add(course);
        }
    }

    public void ShowEnrolledCourses()
    {
        Console.WriteLine($"{Name} is enrolled in:");
        foreach (var course in courses)
        {
            Console.WriteLine($"- {course.CourseName}");
        }
    }
}

// School class (Aggregates Students)
class School
{
    public string SchoolName { get; }
    private List<Student> students; // Aggregation Relationship

    public School(string schoolName)
    {
        SchoolName = schoolName;
        students = new List<Student>();
    }

    public void AddStudent(Student student)
    {
        students.Add(student);
    }

    public void ShowStudents()
    {
        Console.WriteLine($"Students in {SchoolName}:");
        foreach (var student in students)
        {
            Console.WriteLine($"- {student.Name}");
        }
    }
}

// Main Program
class Program
{
    static void Main()
    {
        // Create School
        School school = new School("Greenwood High");

        // Create Students
        Student s1 = new Student("Alice");
        Student s2 = new Student("Bob");

        // Add students to the school (Aggregation)
        school.AddStudent(s1);
        school.AddStudent(s2);

        // Create Courses
        Course c1 = new Course("Mathematics");
        Course c2 = new Course("Science");

        // Enroll Students in Courses (Many-to-Many)
        c1.EnrollStudent(s1);
        c1.EnrollStudent(s2);
        c2.EnrollStudent(s2);

        // Display School and Students
        school.ShowStudents();
        Console.WriteLine();

        // Display Students' Courses
        s1.ShowEnrolledCourses();
        s2.ShowEnrolledCourses();
        Console.WriteLine();

        // Display Courses' Enrolled Students
        c1.ShowEnrolledStudents();
        c2.ShowEnrolledStudents();
    }
}
