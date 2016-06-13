using System;

class Bai_Ivan_Adventures
{
    static void Main(string[] args)
    {
        int day = int.Parse(Console.ReadLine());                    // [0, 6] [Mon, Sun] 
        decimal money = decimal.Parse(Console.ReadLine());
        decimal alcoholRequirements = decimal.Parse(Console.ReadLine());
        decimal[] prices = { 25m, 21m, 14m, 17m, 45m, 59m, 42m};    // prices [Mon, Sun]
        decimal priceAlcohol = 0;
        string condition = "";
        for (int i = 0; i <= 6; i++)
        {
            if (day == i)
            {
                priceAlcohol = prices[i];
                break;
            }
        }
        decimal alcoholdDrank = money / priceAlcohol;
        decimal alcoholDiff = alcoholdDrank - alcoholRequirements;

        if (alcoholdDrank > 1.5m)
            condition = "very drunk";
        else if (alcoholdDrank >= 1m)
            condition = "drunk";
        else                                                        // less than 1.0l
            condition = "sober";

        if (alcoholDiff > 0)
            Console.WriteLine("Bai Ivan is {0} and very happy and he shared {1:0.00} l. of alcohol with his friends", condition,alcoholDiff);            
        else if (alcoholDiff == 0)
            Console.WriteLine("Bai Ivan is {0} and happy. He is as drunk as he wanted", condition);
        else
            Console.WriteLine("Bai Ivan is {0} and quite sad. He wanted to drink another {1:0.00} l. of alcohol", condition, -alcoholDiff);
    }
}

