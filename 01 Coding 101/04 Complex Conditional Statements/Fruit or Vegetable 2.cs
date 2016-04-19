using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fruit_or_Vegetable_2
{
    class Program
    {
        static void Main(string[] args)
        {
            string product = Console.ReadLine().ToLower();
            string productType = "unknown";

            string[] fruits = new string[]      { "banana", "apple", "kiwi", "cherry", "lemon", "grapes" };
            string[] vegetables = new string[]  { "tomato", "cucumber", "pepper", "carrot", "carrot", "carrot" };

            for (int i = 0; i < 6; i++)
            {
                if (product == fruits[i])
                    productType = "fruit";
                else if (product == vegetables[i])
                    productType = "vegetable";
            }
            Console.WriteLine(productType);
        }
    }
}