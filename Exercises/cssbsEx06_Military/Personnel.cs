// Name : Denis Licona
// File : Exercise_6_Military_Unit
// Date : February 26, 2020

using System;

namespace cssbsEx06_Military
{
    class Personnel : Unit
    {
        public void rate(string rank)
        {
            Console.WriteLine($"Your rank is: {rank}");
        }
        public void Occupation(string Specialty)
        {
            Console.WriteLine($"Your military occupation specialty is: {Specialty}");
        }
        public void jobCode(string MOS)
        {
            Console.WriteLine($"Your MOS code is: {MOS}");
        }
    }
}