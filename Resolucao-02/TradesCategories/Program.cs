using System;
using System.Collections.Generic;
using TradesCategories.Model2.Strategy;
using TradesCategories.Models2.Interfaces;

namespace TradesCategories
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Trade> portifolio = new List<Trade>()
            {
                new Trade(value: 2_000_000, clientSector: "Private"),
                new Trade(value: 4_00_000, clientSector: "Public"),
                new Trade(value: 5_00_000, clientSector: "Public"),
                new Trade(value: 3_000_000, clientSector: "Public")

            };

            PrintPortifolio(portifolio);
            Console.ReadKey();
        }

        public static void PrintPortifolio(List<Trade> portifolio)
        {
            foreach (var category in portifolio)
            {
                Console.WriteLine($"{category.GetClientCategoty()}");
            }
        }
    }
}
