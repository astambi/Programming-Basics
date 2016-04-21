using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sales_Report
{
    class Sales_Report
    {
        class Sale
        {
            public string Town { get; set; }
            public string Product { get; set; }
            public decimal Price { get; set; }
            public decimal Quantity { get; set; }

            public decimal SalesAmount
            {
                get
                {
                    return Price * Quantity;
                }
            }
        }
        static void Main(string[] args)
        {
            Sale[] sales = GetSales();

            string[] towns = sales
                            .Select(s => s.Town)
                            .OrderBy(t => t)
                            .Distinct()
                            .ToArray();

            foreach (var town in towns)
            {
                decimal salesByTown = sales
                                    .Where(s => s.Town == town)
                                    .Select(s => s.SalesAmount)
                                    .Sum();
                Console.WriteLine("{0} -> {1:f2}", town, salesByTown);
            }
        }

        static Sale[] GetSales()
        {
            int n = int.Parse(Console.ReadLine());
            Sale[] sales = new Sale[n];
            for (int i = 0; i < n; i++)
            {
                sales[i] = ReadSale();
            }
            return sales;
        }

        static Sale ReadSale()
        {
            string[] data = Console.ReadLine().Split(' ').ToArray();
            Sale sale = new Sale() { Town = data[0],
                                    Product = data[1],
                                    Price = decimal.Parse(data[2]),
                                    Quantity = decimal.Parse(data[3]) };
            return sale;
        }
    }
}
