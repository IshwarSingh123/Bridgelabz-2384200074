using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WareHouseManagementSystem
{
    internal class Electronics:WarehouseItem
    {
        public string Brand { get; set; }
        public int WarrantyPeriod { get; set; }

        public Electronics(string name, int quantity, double price, string brand, int warrantyPeriod):base(name, quantity, price)
        {
            this.Brand = brand;
            this.WarrantyPeriod = quantity;
        }

        public override void DisplayDetails()
        {
            Console.WriteLine($"Electronics - {Name} | Brand: {Brand} | Price: {Price:C} | Warranty: {WarrantyPeriod} months | Quantity: {Quantity}");
        }
    }
}
