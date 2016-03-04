using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01_Daily_Calorie_Intake
{
    class _01_Daily_Calorie_Intak
    {
        static void Main(string[] args)
        {
            double rateLbsKg = 1 / 2.2;
            double rateInchCm = 2.54;
            double weight = int.Parse(Console.ReadLine()) * rateLbsKg;  // kg
            double height = int.Parse(Console.ReadLine()) * rateInchCm; // cm
            int age =       int.Parse(Console.ReadLine());
            string gender = Console.ReadLine().ToLower();
            int workouts =  int.Parse(Console.ReadLine());
            double BMR = 0;
            double DCI = 0;

            if (gender == "f")
                BMR = 655 + 9.563 * weight + 1.850 * height - 4.676 * age;
            else if (gender == "m")
                BMR = 66.5 + 13.75 * weight + 5.003 * height - 6.755 * age;

            if (workouts <= 0)
                DCI = BMR * 1.2;
            else if (workouts <= 3)
                DCI = BMR * 1.375;
            else if (workouts <= 6)
                DCI = BMR * 1.55;
            else if (workouts <= 9)
                DCI = BMR * 1.725;
            else
                DCI = BMR * 1.9;
            
            Console.WriteLine("{0:0}", Math.Floor(DCI));
        }
    }
}
