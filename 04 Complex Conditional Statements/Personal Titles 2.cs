using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Personal_Titles
{
    class Program
    {
        static void Main(string[] args)
        {
            double age = double.Parse(Console.ReadLine());
            string gender = Console.ReadLine().ToLower();
            string title = "";

            string[] genders = new string[]             {"m", "f"};
            string[] salutationFormal = new string[]    {"Mr.", "Ms."};
            string[] salutationTeen = new string[]      {"Master", "Miss"};

            for (int i = 0; i < 2; i++)
            {
                if (gender == genders[i])
                    if (age >= 16)
                        title = salutationFormal[i];
                    else
                        title = salutationTeen[i];
            }
            Console.WriteLine(title);
        }
    }
}