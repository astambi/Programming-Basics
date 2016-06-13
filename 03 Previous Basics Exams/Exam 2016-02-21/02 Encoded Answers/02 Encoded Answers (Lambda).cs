using System;
using System.Linq;

class Encoded_Answers
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());  // number of test questions
        char[] answers = "abcd".ToCharArray();  // test answers: a, b, c, d 
        char[] testAnswers = new char[n];
        for (int testQuestion = 0; testQuestion < n; testQuestion++)
        {
            long number = long.Parse(Console.ReadLine());
            int remainder = (int)(number % 4);
            testAnswers[testQuestion] = answers[remainder]; 
        }
        Console.WriteLine(string.Join(" ", testAnswers));
        for (int i = 0; i < 4; i++)
        {
            Console.WriteLine("Answer {0}: {1}", 
                            answers[i].ToString().ToUpper(),
                            testAnswers.Where(ch => ch == answers[i]).Count());
        }
    }
}