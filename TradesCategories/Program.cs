using System;
using System.Collections.Generic;
using TradesCategories.Models.Domain;
using TradesCategories.Models.Interfaces;
using TradesCategories.Models.Strategy;

namespace TradesCategories
{
    class Program
    {
        static void Main(string[] args)
        {
            List<ITrade> portifolio = new List<ITrade>()
            {
                new Trade(value: 2_000_000, clienteSector: "Private"),
                new Trade(value: 4_00_000, clienteSector: "Public"),
                new Trade(value: 5_00_000, clienteSector: "Public"),
                new Trade(value: 3_000_000, clienteSector: "Public")
            };

            List<string> tradeCategories = new PortifolioStrategy().TradeCategoryResolver(portifolio);
            PrintOutput(tradeCategories);

            Console.ReadKey();
        }

        public static void PrintOutput(List<string> tradeCategories)
        {
            foreach (var categories in tradeCategories)
            {
                Console.WriteLine($"{categories}");
            }
        }
    }
}
