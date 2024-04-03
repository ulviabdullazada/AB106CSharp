using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WeaponTask.Models
{
    internal class Weapon
    {
        private int _capacity=1;
        private int _bullet;
        private double _time;
        private bool _mode;//true auto
        public int Capacity
        {
            get { return _capacity; }
            set
            {
                if (value>0)
                {
                    _capacity = value;
                }
            }
        }
        public int Bullet
        {
            get { return _bullet; }
            set
            {
                if (value>=0 && value<=Capacity)
                {
                    _bullet = value;
                }
            }
        }
        public double Time
        {
            get { return _time; }
            set
            {
                if (value> 0)
                {
                    _time = value;
                }
            }
        }
        public bool Mode
        {
            get { return _mode; }
            set
            {
                _mode = value;
            }
        }

        public Weapon(int cap,int bul,double time,bool mode)
        {
            Capacity = cap;
            Bullet = bul;
            Time = time;
            Mode = mode;
        }

        public void Shoot()  
        {
            if (Mode)
            {
                double num = Math.Ceiling(Capacity / Time);
                if (Bullet>=num) 
                {
                    Bullet -=Convert.ToInt32(num);
                    Console.WriteLine("pew pew pew");
                }
                else
                {
                    Console.WriteLine("Not enough bullets please reload!!!");
                }
            }
            else
            {
                if (Bullet>0) {
                    Bullet--;
                    Console.WriteLine("Pew");
                }
                else
                {
                    Console.WriteLine("Not enough bullets please reload!!!");
                }
            }
           
        }
        public void Fire()
        {
            
            double percent =Bullet*100 / Capacity;
            //double percent = (Convert.ToDouble(Bullet) / Convert.ToDouble(Capacity)) * 100;
            Bullet = 0;
            Console.WriteLine($"{Time*percent/100} seconds was spent");
        }

        public void GetRemainBulletCount()
        {
            Console.WriteLine(Capacity-Bullet);
        }
        public void Reload()
        {
            Bullet = Capacity;
        }
        public void ChangeMode()
        {
            if (Mode)
            {
                Mode = false;
            }
            else
            {
                Mode = true;
            }
        }

        public void GetInfo()
        {
            Console.WriteLine($"Capacity:{Capacity}\nBullet:{Bullet}\nTime:{Time}s\nMode:"+(Mode? "Auto":"Single"));
        }
    }
}

