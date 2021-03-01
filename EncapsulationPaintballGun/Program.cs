using System;

namespace EncapsulationPaintballGun
{
    class Program
    {
        static void Main(string[] args)
        {
            PaintballGun gun = new PaintballGun();
            while (true)
            {
                Console.WriteLine($"{gun.PaintBalls} paint balls, {gun.PaintBallsLoaded} loaded");
                if (gun.IsEmpty()) Console.WriteLine("WARNING: You are out of ammo!!!");
                Console.WriteLine("Press space bar to shoot, r to reload, + to add ammo and q to quit.");
                char key = Console.ReadKey(true).KeyChar;
                Console.WriteLine("You have pressed: " + key);
                if (key == ' ') Console.WriteLine($"Shooting returned {gun.Shoot()}");
                else if (key == 'r') gun.Reload();
                else if (key == '+') gun.PaintBalls += gun.MagazineSize;
                else if (key == 'q') return;
            }
        }
    }
}
