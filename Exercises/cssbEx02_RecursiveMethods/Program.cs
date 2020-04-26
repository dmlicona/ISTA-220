using System;

namespace RecursivePractice
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Part 1: Enter a numeric grade to assign a letter grade:");
            string userInput = Console.ReadLine();
            double numbGrade = double.Parse(userInput);
            char letterGrade = getGrade(numbGrade);
            Console.WriteLine($"The letter grade is {letterGrade}");
            Console.WriteLine("Press ENTER to continue");
            Console.ReadLine();

            Console.WriteLine("Part 2: Enter ten Test scores to compute the average numerical grade:");
            double start = 1;
            double end = 10;
            double sum = 0;
            double dAverage = getAverage(start, end, sum);
            Console.WriteLine($"The average grade is {dAverage}");
            char newLetterGrade = getGrade(dAverage);
            Console.WriteLine($"The letter grade is {newLetterGrade}");
            Console.WriteLine("Press ENTER to continue");
            Console.ReadLine();

            Console.WriteLine("Part 3: Enter total number of test");
            string strtestTotal = Console.ReadLine();
            int testTotal = Int32.Parse(strtestTotal);
            double p3Start = 1;
            double p3End = testTotal;
            double p3Sum = 0;
            double p3Average = getAverage(p3Start, p3End, p3Sum);
            Console.WriteLine($"The average grade is {p3Average}");
            char p3LetterGrade = getGrade(p3Average);
            Console.WriteLine($"The letter grade is {p3LetterGrade}");
            Console.WriteLine("Press ENTER to continue");
            Console.ReadLine();

            Console.WriteLine("Part 4: Enter a number of test scores to find the average");
            double p4Start = 0;
            int p4End = -1;
            double p4Sum = 0;
            double p4Average = getP4Average(p4Start, p4End, p4Sum);
            Console.WriteLine($"The average grade is {p4Average}");
            char p4LetterGrade = getGrade(p4Average);
            Console.WriteLine($"The letter grade is {p4LetterGrade}");
            Console.WriteLine("Press ENTER to continue");
            Console.ReadLine();

            Console.WriteLine("Part 5: Fibonacci series. Press enter to begin");
            Console.ReadLine();
            long fStart = 0;
            long fEnd = 9;
            long fSum = 0;
            long fibNumb = getFibonacci(fStart, fEnd, fSum);
            Console.WriteLine($"The {fEnd}th Fibonacci number is {fibNumb}");
  
        }
        static char getGrade(double numbGrade)
        {
            if (numbGrade >= 90)
            {
                return 'A';
            }
            else if (numbGrade < 90 && numbGrade >= 80)
            {
                return 'B';
            }
            else if (numbGrade < 80 && numbGrade >= 70)
            {
                return 'C';
            }
            else if (numbGrade < 70 && numbGrade >= 60)
            {
                return 'D';
            }
            else
            {
                return 'F';
            }
        }
        static double getAverage(double start, double end, double sum)
        {
            if (start <= end)
            {
                Console.WriteLine("Enter numeric test score:");
                string stringScore = Console.ReadLine();
                double numScore = double.Parse(stringScore);
                return getAverage(start + 1, end, numScore + sum);
            }
            else
                return sum / end;
        }
        static double getP4Average(double p4Start, int p4End, double p4Sum)
        {
            Console.WriteLine("Enter numeric test score or enter (-1) to stop and evaluate:");
            string stringP3Scores = Console.ReadLine();
            double p3Scores = double.Parse(stringP3Scores);
            p4End = -1;
            if (p3Scores != -1)
            {
                return getP4Average(p4Start + 1, p4End, p3Scores + p4Sum);
            }
            else
                return p4Sum / p4Start;
        }
    }
}
