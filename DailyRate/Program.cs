﻿#region Using directives

using System;
using System.Collections.Generic;
using System.Text;

#endregion

namespace DailyRate
{
    class Program
    {
        static void Main(string[] args)
        {
            (new Program()).run();
        }

        public void run()
        {
            double dailyRate = readDouble("Enter your daily rate:");
            int noOfDays = readInt("Enter the number of days:");
            writeFee(calculateFee(dailyRate, noOfDays));

        }

        private void writeFee(double v)
        {
            Console.WriteLine("The consultant's fee is {0}", v * 1.1);
        }

        private double calculateFee(double dailyRate, int noOfDays)
        {
         return dailyRate * noOfDays;

        }

        private int readInt(string v)
        {
            Console.WriteLine(v);
            string line = Console.ReadLine();
            return int.Parse(line);
        }

        private double readDouble(string v)
        {
            Console.Write(v);
            string line = Console.ReadLine();
            return Double.Parse(line);
        }
    }
}
