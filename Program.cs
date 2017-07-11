using System;
using System.Collections.Generic;

namespace dictionaries
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, string> stocks = new Dictionary<string, string>();
                stocks.Add("GM", "General Motors");
                stocks.Add("CAT", "Caterpillar");
                stocks.Add("APL", "Apple");
                stocks.Add("BRD", "Bard");
            
            List<(string ticker, int shares, double price)> purchases = new List<(string, int, double)>();
            purchases.Add((ticker: "APL", shares: 120, price: 25.00));
            purchases.Add((ticker: "APL", shares: 30, price: 32.56));
            purchases.Add((ticker: "BRD", shares: 45, price: 50.78));
            purchases.Add((ticker: "BRD", shares: 6, price: 27.85));

            /* 
                Define a new Dictionary to hold the aggregated purchase information.
                - The key should be a string that is the full company name.
                - The value will be the valuation of each stock (price*amount)

                {
                    "General Electric": 35900,
                    "AAPL": 8445,
                    ...
                }
            */

            Dictionary<string, double> StockReport = new Dictionary<string, double>();

            // Iterate over the purchases and 
            foreach ((string ticker, int shares, double price) purchase in purchases)
            {
                if (StockReport.ContainsKey(stocks[purchase.ticker]))
                    {
                        double value = (purchase.shares*purchase.price);
                        StockReport[stocks[purchase.ticker]] += value;
                        Console.WriteLine($"{stocks[purchase.ticker]}: {value}");
                    }
                else 
                    {
                        double value = purchase.shares*purchase.price;
                        StockReport.Add(stocks[purchase.ticker], value);
                        Console.WriteLine($"this was added to Stock Report {stocks[purchase.ticker]}");
                    }
            }
        }
    }
}
