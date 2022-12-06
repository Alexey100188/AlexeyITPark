using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Start2.Weapons
{
    internal class machinegun
    {

        public int damage;
        public int rateOfFire;
        public string color;
        public double weight;
        public int clip;
        public bool canBurstShooting;

        public machinegun(int damage, int rateOfFire, string color, double weight, bool canBurstShooting)
        {
            this.damage = damage;
            this.rateOfFire = rateOfFire;
            this.color = color;
            this.weight = weight;
            clip = 35;
            this.canBurstShooting = canBurstShooting;
        }

        public void Info()
        {
            Console.WriteLine($"Weapon - machinegun. Damage {damage} Clip: {clip}");
        }
        public void Shoot()
        {
            Console.WriteLine($"Tra-ta-ta! Damage {damage}");
            clip--;
        }


        public void BurstShoot()
        {
            if (canBurstShooting)
            {
                for (int i = 0; i < 3; i++)
                {
                    Shoot();
                }
            }
            else
                Shoot();
        }
    }
}
