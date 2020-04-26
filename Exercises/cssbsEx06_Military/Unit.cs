// Name : Denis Licona
// File : Exercise_6_Military_Unit
// Date : February 26, 2020

using System;

namespace cssbsEx06_Military
{
    class Unit
    {
        public void UnitCode(String UIC)
        {
            Console.WriteLine($"Your unit code: {UIC}");
        }
        public void CompanyCode(String company)
        {
            Console.WriteLine($"You company code: {company}");
        }
        public void PltCode(string platoon)
        {
            Console.WriteLine($"Your platoon code: {platoon}");
        }
    }
}