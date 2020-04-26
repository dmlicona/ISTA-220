using System;
using System.Collections.Generic;
using System.Text;

namespace cssbsEx06_Military
{
    class Weapons : Unit
    {
        protected int weight;
        public int getWeight()
        {
            return weight;
        }
        public void SetWeight()
        {
            weight = 0;
        }
        public void Aim()
        {
            Console.WriteLine("Aim");
        }
        public virtual void Shoot()
        {
            Console.WriteLine("Shoot Bullets");
        }
        class Weapon1 : Weapons
        {
            public new void SetWeight()
            {
                weight = 20;
            }
            public void SetWeight(int wweight)
            {
                weight = wweight;
            }
            public override void Shoot()
            {
                Console.WriteLine("Shoot W1's Bullets");
            }
        }
    }
}
