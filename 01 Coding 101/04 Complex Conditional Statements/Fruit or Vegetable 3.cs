using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fruit_or_Vegetable_3
{
    class Program
    {
        static void Main(string[] args)
        {
            string product = Console.ReadLine().ToLower();

            string productType = "unknown";
            var fruit =     product == "banana" || product == "apple" || product == "kiwi" || product == "cherry" || product == "lemon" || product == "grapes";
            var vegetable = product == "tomato" || product == "cucumber" || product == "pepper" || product == "carrot";

            if (fruit)
                productType = "fruit";
            else if (vegetable)
                productType = "vegetable";

            Console.WriteLine(productType);
        }
    }
}