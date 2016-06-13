using System;

class Prospect_In_Hospitality
{
    static void Main(string[] args)
    {
        decimal[] salaries = { 1500.04m, 2102.10m, 1465.46m, 2053.33m, 3010.98m, 0m, 0m };
        long[] personnel = new long[salaries.Length];
        for (int i = 0; i < salaries.Length - 2; i++)  
            personnel[i] = long.Parse(Console.ReadLine());
        personnel[5] = personnel[6] = 1;
        salaries[5] = decimal.Parse(Console.ReadLine()) * decimal.Parse(Console.ReadLine()); // salaryUSD * FXusd
        salaries[6] = decimal.Parse(Console.ReadLine());
        decimal budget = decimal.Parse(Console.ReadLine());
        decimal expenses = 0m;
        for (int i = 0; i < salaries.Length; i++)
            expenses += salaries[i] * personnel[i];
        decimal budgetDiff = Math.Abs(budget - expenses);
        Console.WriteLine("The amount is: {0:f2} lv.", expenses);
        if (budget >= expenses)
            Console.WriteLine("YES \\ Left: {0:f2} lv.", budgetDiff);
        else
            Console.WriteLine("NO \\ Need more: {0:f2} lv.", budgetDiff);
    }
}