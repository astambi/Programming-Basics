using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sales_Report
{
    class Program
    {
        class Sale
        {
            public string Town { get; set; }
            public string Product { get; set; }
            public decimal Price { get; set; }
            public decimal Quantity { get; set; }            
        }

        static void Main(string[] args)
        {
            Sale[] sales = ReadSales();

            var towns = sales
                        .Select(s => s.Town)
                        .Distinct()
                        .OrderBy(t => t);
            foreach (var town in towns)
            {
                decimal salesByTown = sales
                                    .Where(s => s.Town == town)
                                    .Select(s => s.Price * s.Quantity)
                                    .Sum();
                Console.WriteLine("{0} -> {1:f2}", town, salesByTown);
            }
        }

        static Sale ReadSale()
        {
            string[] salesInput = Console.ReadLine().Split(' ');
            Sale sale = new Sale() { Town = salesInput[0],
                                    Product = salesInput[1],
                                    Price = decimal.Parse(salesInput[2]),
                                    Quantity = decimal.Parse(salesInput[3]) };
            return sale;
        }
        static Sale[] ReadSales()
        {
            int n = int.Parse(Console.ReadLine());
            Sale[] sales = new Sale[n];
            for (int i = 0; i < n; i++)
                sales[i] = ReadSale();
            return sales;
        }
    }
}