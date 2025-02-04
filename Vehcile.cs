//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace Opps
//{
//    using System;

//    class Vehicle
//    {
//        private string ownerName;
//        private string vehicleType;
//        private static double registrationFee = 500.0; // Fixed registration fee for all vehicles

//        // Constructor to initialize vehicle details
//        public Vehicle(string ownerName, string vehicleType)
//        {
//            this.ownerName = ownerName;
//            this.vehicleType = vehicleType;
//        }

//        // Instance method to display vehicle details
//        public void DisplayVehicleDetails()
//        {
//            Console.WriteLine("Owner: " + ownerName +
//                              ", Vehicle Type: " + vehicleType +
//                              ", Registration Fee: $" + registrationFee);
//        }

//        // Class method to update registration fee
//        public static void UpdateRegistrationFee(double newFee)
//        {
//            registrationFee = newFee;
//            Console.WriteLine("Registration fee updated to: $" + registrationFee);
//        }

//        // Main method to test the class
//        public static void Main()
//        {
//            // Creating vehicle objects
//            Vehicle vehicle1 = new Vehicle("Ishwar singh", "Car");
//            Vehicle vehicle2 = new Vehicle("Bob Smith", "Motorcycle");

//            // Display initial vehicle details
//            Console.WriteLine("Initial Vehicle Details:");
//            vehicle1.DisplayVehicleDetails();
//            vehicle2.DisplayVehicleDetails();

//            // Update registration fee
//            Console.WriteLine("\nUpdating Registration Fee...");
//            Vehicle.UpdateRegistrationFee(600.0);

//            // Display updated vehicle details
//            Console.WriteLine("\nUpdated Vehicle Details:");
//            vehicle1.DisplayVehicleDetails();
//            vehicle2.DisplayVehicleDetails();
//        }
//    }

//}
