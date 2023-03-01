using ObjectOrientedUsingJson.Json;

internal class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Welcome to Object Oriented Progrmming - JSON");
        while (true)
        {
            Console.WriteLine("\n1.Inventory Data Management \n2.Inventory Management \n3.Stock Management");
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
                case 3:
                    string path = "/Users/piyushshaw/Projects/ObjectOrientedProgramming/ObjectOrientedUsingJson/ObjectOrientedUsingJson/Json/Stock.json";
                    StockManagement readData = new StockManagement();
                    var Data = readData.Read(path);
                    Console.WriteLine("Types of Stocks");
                    Console.WriteLine("-------------------");
                    for (int i = 0; i < Data.stocksList.Count; i++)
                    {
                        Console.WriteLine(Data.stocksList[i].StockName);
                        Console.WriteLine(Data.stocksList[i].Shares);
                        Console.WriteLine(Data.stocksList[i].Price);
                        Console.WriteLine("-------------------");
                        int val = Data.stocksList[i].Shares * Data.stocksList[i].Price;
                        Console.WriteLine("The Price for " + Data.stocksList[i].Shares + "Shares is " + val);
                        Console.WriteLine("-------------------");
                    }
                    break;
            }
        }
    }

}