//using System;

//class Person
//{
//    public string Name { get; set; }
//    public int Id { get; set; }

//    public Person(string name, int id)
//    {
//        Name = name;
//        Id = id;
//    }

//    public virtual void DisplayRole()
//    {
//        Console.WriteLine("General Person");
//    }
//}

//interface Worker
//{
//    void PerformDuties();
//}

//class Chef : Person, Worker
//{
//    public string Specialty { get; set; }

//    public Chef(string name, int id, string specialty)
//        : base(name, id)
//    {
//        Specialty = specialty;
//    }

//    public override void DisplayRole()
//    {
//        Console.WriteLine($"Chef - Specialty: {Specialty}");
//    }

//    public void PerformDuties()
//    {
//        Console.WriteLine("Preparing and cooking meals.");
//    }
//}

//class Waiter : Person, Worker
//{
//    public int TablesAssigned { get; set; }

//    public Waiter(string name, int id, int tablesAssigned)
//        : base(name, id)
//    {
//        TablesAssigned = tablesAssigned;
//    }

//    public override void DisplayRole()
//    {
//        Console.WriteLine($"Waiter - Tables Assigned: {TablesAssigned}");
//    }

//    public void PerformDuties()
//    {
//        Console.WriteLine("Taking orders and serving food.");
//    }
//}

//class Program
//{
//    static void Main()
//    {
//        Worker chef = new Chef("Akash", 101, "Dosa");
//        chef.PerformDuties();
//        ((Person)chef).DisplayRole();

//        Worker waiter = new Waiter("Bijendra", 102, 5);
//        waiter.PerformDuties();
//        ((Person)waiter).DisplayRole();
//    }
//}
