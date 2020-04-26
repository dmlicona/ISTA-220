using System;
using System.Collections.Generic;
using System.Text;

namespace cssbsEx06_Military
{
    class Vehicles : Unit
    {
        public void carriertype(string carries)
        {
            Console.WriteLine($"Carries: {carries}");
        }
        public void TerrainType(String drivesonthisterrain)
        {
            Console.WriteLine($"Drives on: {drivesonthisterrain}");
        }
        public void type(string vehicletype)
        {
            Console.WriteLine($"Vehicle type is: {vehicletype}");
        }
    }
}
