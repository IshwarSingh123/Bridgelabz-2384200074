using System;
public class Vehicle
{
   //static variable to store the common Registration Fee
   public static double registrationFee = 100.00;

   //instance variables for vehicle details
   private string ownerName;
   private string vehicleType;
   private readonly string registrationNumber;

   //to get registration fee
   public double GetRegistrationFee()
   {
       return registrationFee;
   }

   //to get owner name
   public string GetOwnerName()
   {
       return ownerName;
   }

   //to get vehicle type
   public string GetVehicleType()
   {
       return vehicleType;
   }

   //to get registration number
   public string GetRegistrationNo()
   {
       return registrationNumber;
   }

   //constructor to initialize vehicle details 
   public Vehicle(string ownerName, string vehicleType, string registrationNumber)
   {
       this.ownerName = ownerName;
       this.vehicleType = vehicleType;
       this.registrationNumber = registrationNumber;
   }

   //static method to update the Registration Fee for all vehicles
   public static void UpdateRegistrationFee(double newFee)
   {
       registrationFee = newFee;
       Console.WriteLine("Updated Registration Fee: " + registrationFee);
   }

   //method to display vehicle registration details
   public void DisplayRegistrationDetails()
   {
       if (this is Vehicle)
       {
           Console.WriteLine("Vehicle Registration Details:\nOwner Name: {0}\nVehicle Type: {1}\nRegistration Number: {2}\nRegistration Fee: {3}\n", GetOwnerName(), GetVehicleType(), GetRegistrationNo(), GetRegistrationFee());
       }
       else Console.WriteLine("Invalid Vehicle Object!");
   }
}

class Program6
{
   static void Main(string[] args)
   {
       //creating vehicle objects
       Vehicle vehicle1 = new Vehicle("Akash", "Car", "CZ1234");
       //displaying details of vehicle using 'DisplayRegistrationDetails()' method
       vehicle1.DisplayRegistrationDetails();

       Vehicle vehicle2 = new Vehicle("Achal", "Bike", "BN456");
       vehicle2.DisplayRegistrationDetails();

       //updating the Registration Fee
       Vehicle.UpdateRegistrationFee(200.00); //new Registration Fee

       //displaying details of the vehicles after updating the fee
       Console.WriteLine("Details of vehicles after updating the fee:");
       vehicle1.DisplayRegistrationDetails();
       vehicle2.DisplayRegistrationDetails();
   }
}