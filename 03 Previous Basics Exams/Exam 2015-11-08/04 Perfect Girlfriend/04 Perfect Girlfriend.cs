using System;
using System.Linq;

class Perfect_Girlfriend
{
    static void Main()
    {
        string inputOver = "Enough dates!";
        string input = "";
        int perfectCount = 0;
        while ((input = Console.ReadLine()) != inputOver)
        {
            string[] inputDetails = input.Split('\\').ToArray(); // "weekday\phonenumber\braSize\name"
            string weekday = inputDetails[0];
            ulong phoneNumber = ulong.Parse(inputDetails[1]);
            string bra = inputDetails[2];
            string name = inputDetails[3];

            int score = DayOfWeekCalc(weekday)
                        + PhoneNumberCalc(phoneNumber)
                        + BraCalc(bra)
                        - NameCalc(name);
            if (score >= 6000)
            {
                perfectCount++;
                Console.WriteLine($"{name} is perfect for you.");
            }
            else Console.WriteLine($"Keep searching, {name} is not for you.");
        }
        Console.WriteLine(perfectCount);
    }

    static int NameCalc(string name)
    {
        int firstLetterCode = name[0];  // first letter ASCII code
        int nameLength = name.Length;
        return firstLetterCode * nameLength;
    }

    static int BraCalc(string bra)
    {
        // "{size}{cup size}"
        int cupSizeCode = bra[bra.Length - 1]; // cup size ASCII code
        int braSize = int.Parse(bra.Substring(0, bra.Length - 1));  // bra string less last char
        return braSize * cupSizeCode;
    }

    static int PhoneNumberCalc(ulong phoneNumber)
    {
        int sumDigits = 0;
        while (phoneNumber > 0)
        {
            sumDigits += (int)(phoneNumber % 10);
            phoneNumber /= 10;
        }
        return sumDigits;
    }

    static int DayOfWeekCalc(string weekday)
    {
        string[] weekdays = new string[] { "Monday", "Tuesday", "Wednesday", "Thursday", "Friday", "Saturday", "Sunday" };
        for (int i = 0; i < weekdays.Length; i++)
        {
            if (weekday == weekdays[i])
                return i + 1;
        }
        return 0;
    }
}