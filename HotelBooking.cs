//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace Opps
//{
//    public class HotelBooking
//    {
        
//        private string guestName;
//        private string roomType;
//        private int nights;

//        // Default Constructor
//        public HotelBooking()
//        {
//            guestName = "Ishwar";
//            roomType = "Standard";
//            nights = 1;
//        }

//        // Parameterized Constructor
//        public HotelBooking(string guestName, string roomType, int nights)
//        {
//            this.guestName = guestName;
//            this.roomType = roomType;
//            this.nights = nights;
//        }

//        // Copy Constructor
//        public HotelBooking(HotelBooking existingBooking)
//        {
//            this.guestName = existingBooking.guestName;
//            this.roomType = existingBooking.roomType;
//            this.nights = existingBooking.nights;
//        }

//        // Method to display booking details
//        public void Display()
//        {
//            Console.WriteLine("Guest Name: " + guestName + ", Room Type: " + roomType + ", Nights: " + nights);
//        }

//        // Main method to test the class
//        public static void Main()
//        {
//            // Using Default Constructor
//            HotelBooking book1 = new HotelBooking();
//            Console.WriteLine("Default Booking:");
//            book1.Display();

//            // Using Parameterized Constructor
//            HotelBooking book2 = new HotelBooking("Ishwar", "Deluxe", 3);
//            Console.WriteLine("\nParameterized Booking:");
//            book2.Display();

//            // Using Copy Constructor
//            HotelBooking book3 = new HotelBooking(book2);
//            Console.WriteLine("\nCopied Booking:");
//            book3.Display();
//        }
//    }

//}

