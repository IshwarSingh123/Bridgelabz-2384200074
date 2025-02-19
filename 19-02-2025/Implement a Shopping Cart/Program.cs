using System;
using System.Collections.Generic;
using System.Linq;

class ShoppingCart
{
    private Dictionary<string, double> productPrices = new Dictionary<string, double>(); // Product price storage
    private LinkedList<KeyValuePair<string, double>> productOrder = new LinkedList<KeyValuePair<string, double>>(); // Maintain order
    private SortedDictionary<double, List<string>> sortedProducts = new SortedDictionary<double, List<string>>(); // Sort by price

    public void AddProduct(string name, double price)
    {
        productPrices[name] = price; // Store product price

        // Maintain insertion order
        productOrder.AddLast(new KeyValuePair<string, double>(name, price));

        // Maintain sorted order by price
        if (!sortedProducts.ContainsKey(price))
            sortedProducts[price] = new List<string>();

        sortedProducts[price].Add(name);
    }

    public void DisplayProducts()
    {
        Console.WriteLine("\nShopping Cart (Insertion Order):");
        foreach (var item in productOrder)
            Console.WriteLine($"{item.Key}: ${item.Value:F2}");
    }

    public void DisplaySortedProducts()
    {
        Console.WriteLine("\nShopping Cart (Sorted by Price):");
        foreach (var pair in sortedProducts)
            foreach (var product in pair.Value)
                Console.WriteLine($"{product}: ${pair.Key:F2}");
    }

    public static void Main()
    {
        ShoppingCart cart = new ShoppingCart();

        cart.AddProduct("Laptop", 1200.99);
        cart.AddProduct("Mouse", 25.50);
        cart.AddProduct("Keyboard", 49.99);
        cart.AddProduct("Monitor", 300.00);
        cart.AddProduct("Mouse Pad", 10.99);

        cart.DisplayProducts();      // Display in insertion order
        cart.DisplaySortedProducts(); // Display sorted by price
    }
}
