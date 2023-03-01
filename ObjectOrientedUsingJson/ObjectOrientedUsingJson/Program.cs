using Newtonsoft.Json;
using ObjectOrientedUsingJson.Json;

internal class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Welcome to Object Oriented Progrmming - JSON");
        while (true)
        {
            Console.WriteLine("\n1.Inventory Data Management \n2.Inventory Management \n3.Stock Management \n4.Commercial Data Processing");
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
                case 4:
                    //Creating obj for StockManager
                    StockManager stockManager = new StockManager();
                    //getting path of json file
                    string file = @"/Users/piyushshaw/Projects/ObjectOrientedProgramming/ObjectOrientedUsingJson/ObjectOrientedUsingJson/Json/Stock.json";
                    string acc = @"/Users/piyushshaw/Projects/ObjectOrientedProgramming/ObjectOrientedUsingJson/ObjectOrientedUsingJson/Json/Account.json";
                    //DeserializeO Json file
                    StockUtility stockUtility = JsonConvert.DeserializeObject<StockUtility>(File.ReadAllText(file));

                    Console.WriteLine("-------------------------------------------------------------------------------------");
                    Console.WriteLine("                            STOCK MANAGEMENT METHODS                                 ");
                    Console.WriteLine("-------------------------------------------------------------------------------------");
                    Console.WriteLine("Enter which operation to perform on Stock Inventory\n 1-Add a stock\n 2-Remove a stock\n 3-Display Stocks");

                    AccountUtility accountUtility = JsonConvert.DeserializeObject<AccountUtility>(File.ReadAllText(acc));
                    int num = Convert.ToInt32(Console.ReadLine());
                    var fs = stockUtility.stocksList;
                    //Performing stock management functions
                    switch (num)
                    {
                        case 1:
                            stockManager.AddStock(fs);
                            File.WriteAllText(file, JsonConvert.SerializeObject(stockUtility));
                            stockManager.DisplayStocks(fs);
                            break;
                        case 2:
                            stockManager.DeleteInventory(fs);
                            File.WriteAllText(file, JsonConvert.SerializeObject(stockUtility));
                            stockManager.DisplayStocks(fs);
                            break;
                        case 3:
                            stockManager.DisplayStocks(fs);
                            break;
                    }
                    Console.WriteLine("-------------------------------------------------------------------------------------");
                    Console.WriteLine("                            STOCK ACCOUNT METHODS                                    ");
                    Console.WriteLine("-------------------------------------------------------------------------------------");
                    //Perform account management function
                    string flag = "Y";
                    while (flag == "Y")
                    {
                        Console.WriteLine("Please Enter :\n1-Display user account\n2-To buy a share\n3-To sell a share\n4-To Display Account report");
                        int ch = Convert.ToInt32(Console.ReadLine());
                        var fs1 = accountUtility.AccountList;
                        switch (ch)
                        {
                            case 1:
                                stockManager.StockAccount(acc);
                                break;
                            case 2:
                                Console.WriteLine("Enter amount: ");
                                int amount = Convert.ToInt32(Console.ReadLine());
                                Console.WriteLine("Enter company name in which you want to buy share: ");
                                string companyname = Console.ReadLine();
                                stockManager.Buy(amount, companyname);


                                break;
                            case 3:
                                Console.WriteLine("Enter amount: ");
                                int amount1 = Convert.ToInt32(Console.ReadLine());
                                Console.WriteLine("Enter company name in which you want to sell share: ");
                                string companyname1 = Console.ReadLine();
                                stockManager.Sell(amount1, companyname1);

                                break;
                            case 4:
                                stockManager.StockPurchased();
                                stockManager.StockSold();
                                stockManager.DateandTime();
                                break;


                        }
                        Console.WriteLine("\nDo you want to continue?(Y/N)");
                        flag = Console.ReadLine();
                    }
                    break;
            }
        }
    }

}