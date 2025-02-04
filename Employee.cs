//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace Opps
//{

//    class Employee
//    {
//        public int employeeID; // Public: Accessible from anywhere
//        protected string department; // Protected: Accessible in derived classes
//        private double salary; // Private: Only accessible within this class

//        // Constructor
//        public Employee(int employeeID, string department, double salary)
//        {
//            this.employeeID = employeeID;
//            this.department = department;
//            this.salary = salary;
//        }

//        // Public method to get salary
//        public double GetSalary()
//        {
//            return salary;
//        }

//        // Public method to modify salary
//        public void SetSalary(double newSalary)
//        {
//            if (newSalary >= 30000) // Ensuring a minimum salary threshold
//            {
//                salary = newSalary;
//            }
//            else
//            {
//                Console.WriteLine("Invalid salary. Minimum salary should be 30,000.");
//            }
//        }

//        // Display employee details
//        public virtual void DisplayEmployeeDetails()
//        {
//            Console.WriteLine("Employee ID: " + employeeID + ", Department: " + department + ", Salary: $" + GetSalary());
//        }
//    }

//    // Subclass demonstrating use of protected member
//    class Manager : Employee
//    {
//        private string teamName;

//        // Constructor
//        public Manager(int employeeID, string department, double salary, string teamName)
//            : base(employeeID, department, salary)
//        {
//            this.teamName = teamName;
//        }

//        // Override method to display manager details
//        public override void DisplayEmployeeDetails()
//        {
//            Console.WriteLine("Manager ID: " + employeeID + ", Department: " + department + ", Salary: $" + GetSalary() + ", Team: " + teamName);
//        }
//    }

//    // Main method to test the classes
//    class Program
//    {
//        public static void Main()
//        {
//            // Creating an Employee object
//            Employee emp1 = new Employee(101, "IT", 50000);
//            emp1.DisplayEmployeeDetails();

//            // Modifying Salary
//            Console.WriteLine("\nUpdating Salary...");
//            emp1.SetSalary(55000);
//            emp1.DisplayEmployeeDetails();

//            // Creating a Manager object
//            Manager mgr = new Manager(201, "HR", 70000, "Recruitment Team");
//            Console.WriteLine("\nManager Details:");
//            mgr.DisplayEmployeeDetails();
//        }
//    }

//}
