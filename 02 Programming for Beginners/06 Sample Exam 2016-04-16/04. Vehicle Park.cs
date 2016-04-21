using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.Vehicle_Park
{
    class Vehicle_Park
    {
        static void Main(string[] args)
        {
            List<string> vehiclesForSale = Console.ReadLine().Split(' ').ToList();  

            List<string> unsoldVehicles = new List<string>(vehiclesForSale);
            string inputOver = "End of customers!";
            string input = "";
            int countSales = 0;

            // get sales requests
            while ((input = Console.ReadLine()) != inputOver)
            {
                string[] inputDetails = input.ToLower().Split(' '); // {Vehicle Type} with {Amount of seats} seats  
                char type = inputDetails[0][0];                     // vehicle's first letter
                int seats = int.Parse(inputDetails[2]);             // vehicle's seats
                string vehicleRequest = string.Empty + type + seats;

                // match sale request to list of unsold vehicles
                bool isSold = false;
                for (int i = 0; i < unsoldVehicles.Count; i++)
                {
                    if (unsoldVehicles[i] == vehicleRequest)
                    {
                        isSold = true;
                        countSales++;
                        unsoldVehicles.RemoveAt(i);

                        int price = type * seats;
                        Console.WriteLine("Yes, sold for {0}$", price);

                        break;
                    }
                }
                if (!isSold)
                    Console.WriteLine("No");
            }
            // print list of unsold vehicles and number of sales
            Console.WriteLine("Vehicles left: {0}", string.Join(", ", unsoldVehicles));
            Console.WriteLine("Vehicles sold: {0}", countSales);
        }
    }
}
