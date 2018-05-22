using System;
using System.IO;

namespace Lab10
{
    class Program
    {
        static void Main(string[] args)
        {
            DaysInYear yearConverter = new DaysInYear();
            string year;
            using (StreamReader reader = File.OpenText("input.txt"))
            {
                year = reader.ReadLine();
            }
            int days= yearConverter.NumberOfDaysInYear(year);
            using (StreamWriter writer = File.CreateText("ouput.txt"))
            {
                writer.WriteLine($"Число дней в {year} году равно {days}");
            }
        }
    }

 }
