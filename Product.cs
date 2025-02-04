using System;
public class Product
{
   //static variable to store the name of the company
   public static double discount = 5;

   //instance variables for product details
   public readonly string productId;
   public string productName;
   public double price;
   public double quantity;

   //to get discount
   public double GetDiscount()
   {
       return discount;
   }

   //to get product Id
   public string GetProductId()
   {
       return productId;
   }

   //to get product name 
   public string GetProductName()
   {
       return productName;
   }

   //to get product price
   public double GetPrice()
   {
       return price;
   }

   //to get quantity 
   public double GetQuantity()
   {
       return quantity;
   }

   //constructor to initialize product details
   public Product(string productId, string productName, double price, double quantity)
   {
       this.productId = productId;
       this.productName = productName;
       this.price = price;
       this.quantity = quantity;
   }

   //method to update the discount
   public static void UpdateDiscount(double newDiscount)
   {
       discount = newDiscount;
   }

   //method to calculate the total price before discount
   public double GetTotalPriceBeforeDiscount()
   {
       return price * quantity;
   }

   //method to calculate the total price after applying the discount
   public double GetTotalPriceAfterDiscount()
   {
       double totalPrice = GetTotalPriceBeforeDiscount();
       double totalDiscount = totalPrice * (discount / 100);
       return totalPrice - totalDiscount;
   }

   //method to display product details
   public void DisplayProductDetails()
   {
       if (this is Product)
       {
           Console.WriteLine("Product Id: {0}\nProduct Name: {1}\nPrice: {2}\nQuantity: {3}", GetProductId(), GetProductName(), GetPrice(), GetQuantity());
           Console.WriteLine("Total Price Before Discount: " + GetTotalPriceBeforeDiscount());
           Console.WriteLine("Total Price After Discount: " + GetTotalPriceAfterDiscount() + "\n");
       }
       else
           Console.WriteLine("Invalid product!");
   }
}

class Program4
{
   static void Main(string[] args)
   {
       //creating product object
       Product product1 = new Product("P101", "Diary", 150, 4);
       //displaying product details using 'DisplayProductDetails()' method
       product1.DisplayProductDetails();

       //creating product object and displaying details using 'DisplayProductDetails' method
       Product product2 = new Product("P500", "Chocolate", 80, 3);
       product2.DisplayProductDetails();

       //updating discount
       Product.UpdateDiscount(30);

       //details after updating discount
       Console.WriteLine("Product details after updating discount:\n");
       product1.DisplayProductDetails();
       product2.DisplayProductDetails();
   }
}