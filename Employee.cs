//Write a program to create an Employee class with attributes name, id, and salary. Add a method to display the details.

using System;

class Employee
{
	string name;
	string id;
	int salary;
	Employee(string name,string id,int salary)
	{
		this.name=name;
		this.id=id;
		this.salary=salary;
	}
	
	public void Display()
	{
		Console.WriteLine("Name is: "+name);
		Console.WriteLine("Id is: "+id);
		Console.WriteLine("Salary: is "+salary);
	}

	
	public static void Main()
	{
		Console.WriteLine("Enter the Name of the Employee:");
		string name = Console.ReadLine();
		Console.WriteLine("Enter the Id of the Employee:");
		string id = Console.ReadLine();
		Console.WriteLine("Enter the Salary of the Employee: ");
		int salary = int.Parse(Console.ReadLine());
		
		Employee emp = new Employee(name,id,salary);
		emp.Display();
		
	}
}
