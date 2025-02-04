using System;
public class Employee
{
   //static variable to store the name of the company
   private static string companyName = "Capgemini";

   //static variable to count the total number of employees
   private static int totalEmployees = 0;

   //instance variables for employee details
   private string name;
   private readonly string Id;
   private string designation;

   //to get company name 
   public string GetCompanyName()
   {
       return companyName;
   }

   //to get employee name 
   public string GetEmployeeName()
   {
       return name;
   }

   //to get employee ID 
   public string GetEmployeeId()
   {
       return Id;
   }

   //to get designation
   public string GetDesignation()
   {
       return designation;
   }

   //constructor to initialize employee details
   public Employee(string name, string Id, string designation)
   {
       this.name = name;
       this.Id = Id;
       this.designation = designation;
       totalEmployees++;
   }

   //method to get the total number of employees
   public static void DisplayTotalEmployees()
   {
       Console.WriteLine("Total Employees: {0}", totalEmployees);
   }

   //method to display employee details
   public void DisplayEmployeeDetails()
   {
       if (this is Employee)
       {
           Console.WriteLine("Employee Name: {0}\nID: {1}\nDesignation: {2}\n", GetEmployeeName(), GetEmployeeId(), GetDesignation());
       }
       else
           Console.WriteLine("Invalid employee!");
   }
}

class Program3
{
   static void Main(string[] args)
   {
       //creating employee object
       Employee emp1 = new Employee("Akash", "CG126", "Software Developer");
       //displaying account details using 'DisplayEmployeeDetails()' method
       emp1.DisplayEmployeeDetails();

       //creating employee object and displaying details using 'DisplayEmployeeDetails' method
       Employee emp2 = new Employee("Chetan", "CG101", "DevOps Engineer");
       emp2.DisplayEmployeeDetails();

       //displaying total employees
       Employee.DisplayTotalEmployees();
   }
}