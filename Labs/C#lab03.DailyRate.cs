﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DailyRate
{
    class Program
    {
        static void Main(string[] args)
        {
            (new Program()).run();
        }

        void run()
        {
            double dailyRate = readDouble("Enter your daily rate:");
            int no0fDays = readInt("Enter the number of days: ");
            writeFee(calculateFee(dailyRate, no0fDays));
        }

        private void writeFee(double v) => Console.WriteLine($"The consultant's fee is: {v * 1.1}");
        

        private double calculateFee(double dailyRate, int no0fDays) => dailyRate * no0fDays;
        
        private int readInt(string v)
        {
            Console.Write(v);
            string line = Console.ReadLine();
            return int.Parse(line);
        }

        private double readDouble(string v)
        {
            Console.Write(v);
            string line = Console.ReadLine();
            return double.Parse(line);
        }
    }
}
