using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inventory
{
    public class InventoryManager
    {
        public Inventory inventory;
        public InventoryManager()
        {
            inventory = new Inventory();
        }
        public void Add()
        {
            Console.WriteLine("What needs to be added: \nR for Rice, \nP for pulse, \nW for Wheat");
            string input = Console.ReadLine(); // "Ashok" [1,2,3,4,5]
            char firstChar = input[0];// Q
            switch (firstChar)
            {
                case 'R':
                    var seeds = TakeUserInput();
                    inventory.Rice.Add(seeds);
                    break;
                case 'P':
                    inventory.Pulses.Add(TakeUserInput());
                    break;
                case 'W':
                    inventory.Wheat.Add(TakeUserInput());
                    break;
                default:
                    Console.WriteLine("Invalid Entry");
                    break;
            }
        }
        public void PrintInventory()
        {
            Console.WriteLine(inventory.ToString());
        }
        private Seeds TakeUserInput()
        {
            Console.WriteLine("Enter Brand Name:");
            string BrandName = Console.ReadLine();
            Console.WriteLine("Enter Weight:");
            string WeightStr = Console.ReadLine();
            Console.WriteLine("Enter Price Per Kg:");
            string PriceStr = Console.ReadLine();
            Seeds s = new Seeds();
            s.Brand = BrandName;
            s.weight = int.Parse(WeightStr);
            s.PricePerKg = int.Parse(PriceStr);
            Console.WriteLine("Successully added..");
            return s;
        }
    }
}
