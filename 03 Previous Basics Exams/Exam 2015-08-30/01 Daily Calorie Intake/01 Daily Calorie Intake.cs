using System;

class Daily_Calorie_Intake
{
    static void Main(string[] args)
    {
        double weightKg = int.Parse(Console.ReadLine()) / 2.2;
        double heightCm = int.Parse(Console.ReadLine()) * 2.54;
        int age = int.Parse(Console.ReadLine());
        string gender = Console.ReadLine().ToLower();
        int workouts = int.Parse(Console.ReadLine());

        double BMR = 0;
        if (gender == "f")      BMR = 655 + 9.563 * weightKg + 1.850 * heightCm - 4.676 * age;
        else if (gender == "m") BMR = 66.5 + 13.75 * weightKg + 5.003 * heightCm - 6.755 * age;

        double DCI = 0;
        if (workouts <= 0)          DCI = BMR * 1.2;
        else if (workouts <= 3)     DCI = BMR * 1.375;
        else if (workouts <= 6)     DCI = BMR * 1.55;
        else if (workouts <= 9)     DCI = BMR * 1.725;
        else                        DCI = BMR * 1.9; 

        Console.WriteLine("{0:0}", Math.Floor(DCI));
    }
}