using System;
using Newtonsoft.Json;

namespace ObjectOrientedUsingJson.Json
{
	public class StockManagement
	{
        public StockDetails Read(string path)
        {
            using (StreamReader file = new StreamReader(path))
            {
                try
                {
                    string json = file.ReadToEnd();

                    return JsonConvert.DeserializeObject<StockDetails>(json);

                }
                catch (Exception e)
                {
                    return null;
                }
            }
        }
    }
}

