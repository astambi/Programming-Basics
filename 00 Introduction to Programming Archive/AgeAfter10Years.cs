﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AgeAfter10Years
{
    class AgeAfter10Years
    {
        static void Main(string[] args)
        {
            DateTime birthdate = DateTime.Parse(Console.ReadLine());
            DateTime now = new DateTime(2015,11,1); 
            TimeSpan span = now.Subtract(birthdate); 
            var age = Math.Truncate(span.TotalDays / 365);

            Console.WriteLine("Now: {0}", age);
            Console.WriteLine("After 10 years: {0}", age+10); 
        }
    }
}
