using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WareHouseManagementSystem
{
    class Storage<T> where T : WarehouseItem
    {
        private List<T> items = new List<T>();

        // Add item to storage
        public void AddItem(T item)
        {
            items.Add(item);
            Console.WriteLine($"Added: {item.Name} to storage.");
        }

        // Display all stored items
        public void DisplayAllItems()
        {
            Console.WriteLine("\n--- Warehouse Inventory ---");
            if (items.Count == 0)
            {
                Console.WriteLine("No items in storage.");
                return;
            }

            foreach (var item in items)
            {
                item.DisplayDetails();
            }
        }
    }
}
