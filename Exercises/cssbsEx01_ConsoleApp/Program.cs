using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cssbsEx01_ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter your name below: ");
            string yourName = Console.ReadLine();
            Console.WriteLine($"\nHello {yourName}, try these formulas\n");
           
            //test area
            Console.WriteLine("Enter your age now: ");
            int yourAge = Convert.ToInt32(Console.ReadLine());

            TimeSpan ageData = new TimeSpan(yourAge * 365, 0, 0, 0);
            Console.WriteLine();
            Console.WriteLine("You have been alive for: ");
            Console.WriteLine(ageData.TotalSeconds);
            Console.WriteLine(ageData.TotalMinutes);
            Console.WriteLine(ageData.TotalHours);
            Console.WriteLine(ageData.TotalDays);
            Console.WriteLine();

            Console.WriteLine("Enter your favorite colors below: ");
            char[] delimeters = { ',', ';', ' ' };
            string[] colors = Console.ReadLine().Split(delimeters);

            Console.WriteLine();
            Console.WriteLine($"You have favorite {delimeters} favorite colors.", colors.Length);
            Console.WriteLine();


            //end test area

            Console.WriteLine("Part 1: Area and Circumference of a Circle");
            Console.WriteLine("Enter a Value for the radius: ");
            string strRadius = Console.ReadLine();
            int intRadius = int.Parse(strRadius);
            double circumference = (2 * Math.PI) * intRadius;
            Console.WriteLine($"The Circumference is {circumference}");
            double area = Math.PI * intRadius * intRadius;
            Console.WriteLine($"The area is {area}\n");

            Console.WriteLine("Part 2: Volume of a hemisphere");
            Console.WriteLine("Enter a value for the radius: ");
            string strRadiusLength = Console.ReadLine();
            int intRadiusLength = int.Parse(strRadiusLength);
            double volume = ((4 * Math.PI * intRadiusLength * intRadiusLength * intRadiusLength) / 6);
            Console.WriteLine($"The volume is {volume}\n");

            Console.WriteLine("Part 3: Area of triangle given the length of the sides");
            Console.WriteLine("Enter a value for side A: ");
            string strSideA = Console.ReadLine();
            int intSideA = int.Parse(strSideA);
            Console.WriteLine("Enter a value for side B: ");
            string strSideB = Console.ReadLine();
            int intSideB = int.Parse(strSideB);
            Console.WriteLine("Enter a value for side C: ");
            string strSideC = Console.ReadLine();
            int intSideC = int.Parse(strSideC);
            double perimeter = ((intSideA + intSideB + intSideC) / 2);
            double triangleArea = Math.Sqrt(perimeter * (perimeter - intSideA) * (perimeter - intSideB) * (perimeter - intSideC));
            Console.WriteLine($"The area of the triangle is {triangleArea}\n");

            Console.WriteLine("Part 4: Solving the quadratic equation");
            Console.WriteLine("Enter the value of A: ");
            string strValueA = Console.ReadLine();
            int intValueA = int.Parse(strValueA);
            Console.WriteLine("Enter the value of B: ");
            string strValueB = Console.ReadLine();
            int intValueB = int.Parse(strValueB);
            Console.WriteLine("Enter the value of C:");
            string strValueC = Console.ReadLine();
            int intValueC = int.Parse(strValueC);
            double positiveSolution = ((-1 * intValueB) + Math.Sqrt((intValueB * intValueB) + (-4 * intValueA * intValueC))) / (2 * intValueA);
            Console.WriteLine($"The positive solution is {positiveSolution}");
            double negativeSolution = ((-1 * intValueB) - Math.Sqrt((intValueB * intValueB) + (-4 * intValueA * intValueC))) / (2 * intValueA);
            Console.WriteLine($"The negative solution is {negativeSolution}");



        }
    }
}
