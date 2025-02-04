//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace Opps
//{
//    class CarRental
//    {
//        private string customerName;
//        private string carModel;
//        private int rentalDays;
//        private const double dailyRate = 50.0; // Fixed rate per day

//        // Default Constructor
//        public CarRental()
//        {
//            customerName = "Unknown";
//            carModel = "Standard Car";
//            rentalDays = 1;
//        }

//        // Parameterized Constructor
//        public CarRental(string customerName, string carModel, int rentalDays)
//        {
//            this.customerName = customerName;
//            this.carModel = carModel;
//            this.rentalDays = rentalDays;
//        }

//        // Copy Constructor
//        public CarRental(CarRental existingRental)
//        {
//            this.customerName = existingRental.customerName;
//            this.carModel = existingRental.carModel;
//            this.rentalDays = existingRental.rentalDays;
//        }

//        // Method to calculate total cost
//        public double CalculateTotalCost()
//        {
//            return rentalDays * dailyRate;
//        }

//        // Method to display rental details
//        public void DisplayRentalDetails()
//        {
//            Console.WriteLine("Customer Name: " + customerName +
//                              ", Car Model: " + carModel +
//                              ", Rental Days: " + rentalDays +
//                              ", Total Cost: $" + CalculateTotalCost());
//        }

//        // Main method to test the class
//        public static void Main()
//        {
//            // Using Default Constructor
//            CarRental rental1 = new CarRental();
//            Console.WriteLine("Default Rental:");
//            rental1.DisplayRentalDetails();

//            // Using Parameterized Constructor
//            CarRental rental2 = new CarRental("Ishwar singh", "swift", 5);
//            Console.WriteLine("\nParameterized Rental:");
//            rental2.DisplayRentalDetails();

//            // Using Copy Constructor
//            CarRental rental3 = new CarRental(rental2);
//            Console.WriteLine("\nCopied Rental:");
//            rental3.DisplayRentalDetails();
//        }
//    }
//}
