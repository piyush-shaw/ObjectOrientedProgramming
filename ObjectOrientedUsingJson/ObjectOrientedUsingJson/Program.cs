using ObjectOrientedUsingJson.Json;

internal class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Welcome to Object Oriented Progrmming - JSON");

        Console.WriteLine("Welcome to the Inventory Management \n");
        InventoryManagement json = new InventoryManagement();
        json.Convert(@"/Users/piyushshaw/Projects/ObjectOrientedProgramming/ObjectOrientedUsingJson/ObjectOrientedUsingJson/Json/Inventory.json");
    }
}