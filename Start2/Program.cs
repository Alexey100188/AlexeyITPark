using Start2.Weapons;
using System;
using static System.Net.Mime.MediaTypeNames;
using System.Drawing;
using System.Security.Cryptography;

namespace Start2
{
    class Program
    {
        static void Main()
        {
            Pistol pistol = new Pistol(20, 5, "BlackMetal", 0.7, false);
            pistol.Info();
            pistol.BurstShoot();
            pistol.Info();




             Random rnd = new Random();
            machinegun machinegun = new (rnd.Next(0, 100), 5, "Pink", 3.5, true);
            Random rnd2 = new Random();
            machinegun machinegun2 = new(rnd.Next(0, 100), 5, "Pink", 3.5, true);
            Random rnd3 = new Random();
            machinegun machinegun3 = new(rnd.Next(0, 100), 5, "Pink", 3.5, true);

            machinegun.Info();
            machinegun.BurstShoot();
            machinegun.Info();



            }
    }


}

