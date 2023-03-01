using System;
using Newtonsoft.Json;

namespace ObjectOrientedUsingJson.Json
{
    public class InventoryManagement
    {
        // InventoryModel model = new InventoryModel();
        public void convert(string jFilePath)
        {
            FactoryModel model = new FactoryModel();
            List<InventoryModel> Rice;
            List<InventoryModel> Wheat;
            List<InventoryModel> Pulses;

            using (StreamReader file = new StreamReader(jFilePath))
            {
                var json = file.ReadToEnd();
                FactoryModel item = JsonConvert.DeserializeObject<FactoryModel>(json);
                Rice = item.Rice;
                Wheat = item.Wheat;
                Pulses = item.Pulses;
                Console.WriteLine("Check:\n1.Rice\n2.Wheat\n3.Pulses");
                int choice = Convert.ToInt32(Console.ReadLine());

                switch (choice)
                {
                    case 1:
                        foreach (var contact in Rice)
                            Console.WriteLine(contact.Name + "-" + contact.Weight + "-" + contact.PricePerKg);
                        break;
                    case 2:
                        foreach (var contact in Wheat)
                            Console.WriteLine(contact.Name + "-" + contact.Weight + "-" + contact.PricePerKg);
                        break;
                    case 3:
                        foreach (var contact in Pulses)
                            Console.WriteLine(contact.Name + "-" + contact.Weight + "-" + contact.PricePerKg);
                        break;
                }

            }
        }
    }
}

