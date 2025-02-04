//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace Opps
//{

//class Product
//    {
//        private string productName;
//        private double price;
//        private static int totalProducts = 0; // Class variable to track total products

//        // Constructor to initialize product details and increment total count
//        public Product(string productName, double price)
//        {
//            this.productName = productName;
//            this.price = price;
//            totalProducts++; // Increment total products count when a new product is created
//        }

//        // Instance method to display product details
//        public void DisplayProductDetails()
//        {
//            Console.WriteLine("Product Name: " + productName + ", Price: $" + price);
//        }

//        // Class method to display total number of products
//        public static void DisplayTotalProducts()
//        {
//            Console.WriteLine("Total Products Created: " + totalProducts);
//        }

//        // Main method to test the class
//        public static void Main()
//        {
//            // Creating product objects
//            Product product1 = new Product("Laptop", 1200.99);
//            Product product2 = new Product("Smartphone", 699.50);
//            Product product3 = new Product("Headphones", 149.99);

//            // Display product details
//            Console.WriteLine("Product Details:");
//            product1.DisplayProductDetails();
//            product2.DisplayProductDetails();
//            product3.DisplayProductDetails();

//            // Display total products
//            Console.WriteLine("\nTotal Products:");
//            Product.DisplayTotalProducts();
//        }
//    }

//}

