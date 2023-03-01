using System;
namespace ObjectOrientedUsingJson.Json
{
	public class StockUtility
	{
        public LinkedList<Stocks> stocksList = new LinkedList<Stocks>();

        public class Stocks
        {
            public string StockName { get; set; }
            public int shares { get; set; }
            public int Price { get; set; }
        }
    }
}

