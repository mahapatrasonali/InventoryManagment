using Newtonsoft.Json;


namespace Inventory
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
            InventoryManager inventoryManager = new InventoryManager();
            while (true)
            {
                Console.WriteLine("Enter: \n1 for Adding\n2 for Printing inventory");
                int input = int.Parse(Console.ReadLine());
                switch (input)
                {
                    case 1:
                        inventoryManager.Add();
                        Console.WriteLine(JsonConvert.SerializeObject(inventoryManager.inventory, Formatting.Indented));
                        break;
                    case 2:
                        inventoryManager.PrintInventory();
                        break;
                    default:
                        Console.WriteLine("Invalid Entry");
                        break;
                }
            }
            //List<string> list = new List<string>()
            //{
            //    "sdgfjsd",
            //    "sjdfjsdf",
            //    "shgdfhgs",
            //};
            //foreach(string item in list)
            //{
            //    Console.WriteLine(item);
            //}

        }
    }
}
