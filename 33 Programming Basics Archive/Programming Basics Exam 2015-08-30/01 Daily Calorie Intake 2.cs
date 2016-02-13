using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01_Daily_Calorie_Intake_2
{
    class _01_Daily_Calorie_Intake_2
    {
        static void Main(string[] args)
        {
            double rateLbsKg = 1 / 2.2;
            double rateInchCm = 2.54;
            double weight = int.Parse(Console.ReadLine()) * rateLbsKg; //in kg
            double height = int.Parse(Console.ReadLine()) * rateInchCm; //in cm
            int age = int.Parse(Console.ReadLine());
            string gender = Console.ReadLine().ToLower();
            int workouts = int.Parse(Console.ReadLine());
            double[] workoutsMultiplier = { 1.2, 1.375, 1.55, 1.725, 1.9 };
            int[] workoutsPerDay = { 0, 0, 3, 6, 9 };
            double BMR = 0;
            double DCI = 0;

            if (gender == "f")
                BMR = 655 + 9.563 * weight + 1.850 * height - 4.676 * age;
            else if (gender == "m")
                BMR = 66.5 + 13.75 * weight + 5.003 * height - 6.755 * age;
            
            if (workouts > 0)
                for (int i = 1; i < 5; i++)
                {
                    if (workouts > workoutsPerDay[i])
                        DCI = BMR * workoutsMultiplier[i];
                }
            else
                DCI = BMR * workoutsMultiplier[0];
            
            Console.WriteLine("{0:0}", Math.Floor(DCI));
        }
    }
}
