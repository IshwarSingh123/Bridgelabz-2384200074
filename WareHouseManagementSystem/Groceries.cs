using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WareHouseManagementSystem
{
    internal class Groceries : WarehouseItem
    {
        public DateTime ExpiryDate { get; set; }

        public Groceries(DateTime Expiarydate, string name, int quantity, double price) : base(name, quantity, price)
        {
            this.ExpiryDate = Expiarydate;
        }
        public override void DisplayDetails()
        {
            Console.WriteLine($"Groceries - {Name} \n Price: {Price:C} \n Expiry: {ExpiryDate.ToShortDateString()} \n Quantity: {Quantity}");
        }
    }
}
