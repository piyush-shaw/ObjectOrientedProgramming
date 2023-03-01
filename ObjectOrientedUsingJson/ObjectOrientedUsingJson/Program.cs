using ObjectOrientedUsingJson.Json;

internal class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Welcome to Object Oriented Progrmming - JSON");
        while (true)
        {
            Console.WriteLine("\n1.Inventory Data Management \n2.Inventory Management");
            int choice = Convert.ToInt32(Console.ReadLine());
            switch (choice)
            {
                case 1:
                    Console.WriteLine("Welcome to the Inventory Data Management \n");
                    InventoryManagement json = new InventoryManagement();
                    json.convert(@"/Users/piyushshaw/Projects/ObjectOrientedProgramming/ObjectOrientedUsingJson/ObjectOrientedUsingJson/Json/Inventory.json");
                    break;
                case 2:
                    Console.WriteLine("Welcome to the Inventory Data Management \n");
                    InventoryManagement json1 = new InventoryManagement();
                    json1.convert(@"/Users/piyushshaw/Projects/ObjectOrientedProgramming/ObjectOrientedUsingJson/ObjectOrientedUsingJson/Json/Inventory.json");
                    break;
            }
        }
    }

}