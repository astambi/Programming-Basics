using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01_Four_Factors
{
    class Four_Factors
    {
        static void Main(string[] args)
        {
            double FG =     double.Parse(Console.ReadLine());
            double FGA =    double.Parse(Console.ReadLine());
            double threeP = double.Parse(Console.ReadLine());
            double TOV =    double.Parse(Console.ReadLine());
            double ORB =    double.Parse(Console.ReadLine());
            double oppDRB = double.Parse(Console.ReadLine());
            double FT =     double.Parse(Console.ReadLine());
            double FTA =    double.Parse(Console.ReadLine());

            double resultEFG = (FG + 0.5 * threeP) / FGA;
            double resultTOV = TOV / (FGA + 0.44 * FTA + TOV);
            double resultORB = ORB / (ORB + oppDRB);
            double resultFT = FT / FGA;

            Console.WriteLine("eFG% {0:0.000}", resultEFG);
            Console.WriteLine("TOV% {0:0.000}", resultTOV);
            Console.WriteLine("ORB% {0:0.000}", resultORB);
            Console.WriteLine("FT% {0:0.000}", resultFT);
        }
    }
}
