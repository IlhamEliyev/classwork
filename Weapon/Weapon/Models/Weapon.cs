using System;
using System.Collections.Generic;
using System.Text;

namespace Weapon.Models
{
    class WeaponC
    {
        private int _bulletCapacity;
        private int _bulletCount;
        private double _bulletDischargSec;
        public int BulletCapacity { 
            get 
            {
                return _bulletCapacity;
            } 
            set 
            {
                if (value>0 && value <= 200)
                {
                    _bulletCapacity = value;
                }
                else
                {
                    Console.WriteLine("Wrong input");
                }
            }
        }
        public int BulletCount { 
            get 
            {
                return _bulletCount;
            } 
            set 
            {
                if (value >= 0 && value <= _bulletCapacity)
                {
                    _bulletCount = value;
                }
            } 
        }
        public double BulletDischargSec {
            get 
            {
                return _bulletDischargSec;
            }
            set 
            {
                if (value > 0)
                {
                    _bulletDischargSec = value;
                }
            }
        }
        public WeaponC(int capacity, int count, double discharg)
        {
            BulletCapacity = capacity;
            BulletCount = count;
            BulletDischargSec = discharg;
        }
        public void Shoot() 
        {
            if (BulletCount == 0)
            {
                Console.WriteLine("Please use Reload method");
            }
            else
            {
                Console.WriteLine("Shooted 1 time");
            }
            BulletCount--;
        }
        public void Fire() 
        {
            double n = BulletCount / (BulletCapacity / BulletDischargSec);
            BulletCount = 0;
            Console.WriteLine(n);
        }
        public int GetBulletInfo() 
        {
            return BulletCount;
        }
        public void Reload() 
        {
            if (BulletCount >= 0 && BulletCount < BulletCapacity)
            {
                BulletCount = BulletCapacity;
                Console.WriteLine("Reloaded");
            }
            else
            {
                Console.WriteLine("Ammo is full");
            }
        }
    }
}
