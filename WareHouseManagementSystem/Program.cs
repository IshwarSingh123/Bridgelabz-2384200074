using WareHouseManagementSystem;

namespace WareHouseManagementSystem
{
    class Program
    {
        static void Main()
        {
            // Create storage for different types of warehouse items
            Storage<Electronics> electronicsStorage = new Storage<Electronics>();
            Storage<Groceries> groceriesStorage = new Storage<Groceries>();
            Storage<Furniture> furnitureStorage = new Storage<Furniture>();

            // Add items to storage
            electronicsStorage.AddItem(new Electronics("Laptop", 10, 1200.50, "Dell", 24));
            electronicsStorage.AddItem(new Electronics("Smartphone", 15, 899.99, "Samsung", 12));

            groceriesStorage.AddItem(new Groceries(DateTime.Now.AddDays(7),"Apple", 50, 1.99));
            groceriesStorage.AddItem(new Groceries(DateTime.Now.AddDays(5),"Milk", 20, 3.49));

            furnitureStorage.AddItem(new Furniture("Office Chair", 5, 199.99, "Leather"));
            furnitureStorage.AddItem(new Furniture("Wooden Table", 3, 499.99, "Wood"));

            // Display stored items
            electronicsStorage.DisplayAllItems();
            groceriesStorage.DisplayAllItems();
            furnitureStorage.DisplayAllItems();

            
        }
    }
}
