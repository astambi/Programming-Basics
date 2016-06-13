using System;
using System.Collections.Generic;

class _04_Phone_Processes
{
    static void Main(string[] args)
    {
        string batteryInput = Console.ReadLine();
        int batteryState = int.Parse(batteryInput.Remove(batteryInput.Length - 1)); // remove last '%' char
        string endOfInput = "end";
        string input = "";
        //List<string> apps = new List<string>();
        List<int> appRequirements = new List<int>(); // app battery requirement

        while ((input = Console.ReadLine().ToLower()) != endOfInput)
        {
            //string app = input.Substring(0,input.Length - 4);
            //apps.Add(app);
            int battery = int.Parse(input.Substring(input.Length - 3, 2));
            appRequirements.Add(battery);
        }
        int currentIndex = 0;
        while (currentIndex <= appRequirements.Count) // [0, count - 1]
        {
            bool phoneOff = batteryState <= 0;
            bool needsRecharge = batteryState <= 15;
            bool insideRange = currentIndex < appRequirements.Count;
            if (phoneOff)
            {
                Console.WriteLine("Phone Off"); break;
            }
            else if (currentIndex >= appRequirements.Count && !needsRecharge)
                Console.WriteLine("Successful complete -> {0}%", batteryState);
            else if (needsRecharge)
            {
                Console.WriteLine("Connect charger -> {0}%", batteryState);
                Console.WriteLine("Programs left -> {0}", appRequirements.Count - currentIndex);
                break;
            }
            else if (insideRange)
                batteryState -= appRequirements[currentIndex];

            currentIndex++;
        }
    }
}