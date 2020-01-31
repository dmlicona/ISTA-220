using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cssbs_quiz02
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(TestAdd(7, 42 / 2));
        }
        static int TestAdd(int x, int y)
        {
            return x + y;
        }

        //Console.WriteLine(IsEven(7));

        //bool IsEven(int val)
        //{
        //  return val % 2 == 0;
        //}

        // Console.WriteLine("Please enter the number of integers to add: ");
        //string strNumber = Console.ReadLine();
        //int end = Int32.Parse(strNumber);
        //int start = 0;
        //int sum = 0;
        //sum = GetSums(start, end, sum);
        //Console.WriteLine($"the sum is { sum}");
    }

    //private static  int GetSums(int start, int end, int sum)
    //{
    //Console.WriteLine("The sum of " + start + " and " + end + " is " + sum);

    //start = start + 1;
    //sum = sum + start;
    //if (start < end)
    //  return (GetSums(start, end, sum));
    //else
    //  return (sum);



}
