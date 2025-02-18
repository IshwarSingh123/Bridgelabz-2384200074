using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WareHouseManagementSystem
{
    class Furniture : WarehouseItem
    {
        public string Material { get; set; }

        public Furniture(string name, int quantity, double price, string material)
            : base(name, quantity, price)
        {
            Material = material;
        }

        public override void DisplayDetails()
        {
            Console.WriteLine($"Furniture - {Name} \n Material: {Material} \n Price: {Price:C} \n Quantity: {Quantity}");
        }
    }
}
