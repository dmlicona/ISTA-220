// Name : Denis Licona
// File : Exercise_6_Military_Unit
// Date : February 26, 2020

using System;

namespace cssbsEx06_Military
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("This is Denis Licona's exercise 6");
            Personnel me = new Personnel();
            me.rate("Captain");
            me.Occupation("Communications");
            me.jobCode("0602");
            me.UnitCode("12345");
            me.CompanyCode("C");
            me.PltCode("Comm");
            Weapons W1 = new Weapons();
            W1.GetType();
            W1.getWeight();
            W1.Shoot();
            Vehicles LAV = new Vehicles();
            LAV.type("LAV");
            LAV.TerrainType("Land and Sea");
            LAV.carriertype("Weapons and troops");
            
            
        }
    }
}
