using System;
namespace ObjectOrientedUsingJson.Json
{
	public class StockDetails
	{
        public List<StocksList> stocksList;
    }

    public class StocksList
    {
        public string StockName;
        public int Shares;
        public int Price;
    }
}

