using System;
using Weapon.Models;

namespace Weapon
{
    class Program
    {
        static void Main(string[] args)
        {
            WeaponC weapon = new WeaponC(22,10,5);
            int input = 0;
            while (input < 5 && input >= 0)
            {
                input = int.Parse(Console.ReadLine());
                switch (input)
                {
                    case 1:
                        weapon.Shoot();
                        break;
                    case 2:
                        weapon.Fire();
                        break;
                    case 3:
                        weapon.Reload();
                        break;
                    case 4:
                        Console.WriteLine(weapon.GetBulletInfo());
                        break;
                    case 0:
                        Console.WriteLine("1- Shoot, 2- Fire, 3- Reload, 4-GetBulletInfo");
                        break;
                }
            }
        }
    }
}
