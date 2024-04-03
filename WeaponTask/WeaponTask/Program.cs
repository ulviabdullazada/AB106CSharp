using WeaponTask.Models;

namespace WeaponTask
{
    internal class Program
    {
        static void Main(string[] args)
        {
           
            Weapon weapon = new Weapon(60,30,30,true);
            bool result = false;
            int num;
            do
            {
                Console.Clear();
                Console.WriteLine("0 - İnformasiya almaq üçün\r\n1 - Shoot metodu üçün\r\n2 - Fire metodu üçün\r\n3 - GetRemainBulletCount metodu üçün\r\n4 - Reload metodu üçün\r\n5 - ChangeFireMode metodu üçün\r\n6 - Edit characteristics\r\n\n\n\n7 - Exit");
                string str=Console.ReadLine();
                result = int.TryParse(str, out num);

                if (!result) continue;

                switch (num)
                {
                    case 0:
                        Console.Clear();
                        weapon.GetInfo();
                        Console.ReadKey();
                        break;
                    case 1:
                        Console.Clear();
                        weapon.Shoot();
                        Console.ReadKey();
                        break;
                    case 2:
                        Console.Clear();
                        Console.WriteLine("Fire started");
                        weapon.Fire();
                        Console.ReadKey();
                        break;
                    case 3:
                        Console.Clear();
                        Console.WriteLine("Bullets count for fullfilling the charge:");
                        weapon.GetRemainBulletCount();
                        Console.ReadKey();
                        break ;
                    case 4:
                        Console.Clear();
                        Console.WriteLine("Successfully reloaded");
                        weapon.Reload();
                        Console.ReadKey();
                        break;
                    case 5:
                        Console.Clear();
                        weapon.ChangeMode();
                        Console.WriteLine("Mode was changed to:"+(weapon.Mode?"Auto":"Single"));
                        Console.ReadKey();
                        break;
                    case 6:
                        string choice;
                        do
                        {
                            Console.Clear();
                            Console.WriteLine("Please choose characteristics to change:\r\nT - Tutumu dəyişsin\r\nS - Güllə sayı\r\nD - Sıfırlama saniyəsi\r\n\n\nM - Main Menu");
                             choice = Console.ReadLine().ToLower();
                            switch (choice)
                            {
                                case "t":
                                    Console.Clear();
                                    Console.WriteLine("Please enter new capacity:");
                                    weapon.Capacity = int.Parse(Console.ReadLine());
                                    break;
                                case "s":
                                    Console.Clear();
                                    Console.WriteLine("Please enter current bullet count:");
                                    weapon.Bullet = int.Parse(Console.ReadLine());
                                    break;
                                case "d":
                                    Console.Clear();
                                    Console.WriteLine("Please enter time:");
                                    weapon.Time = int.Parse(Console.ReadLine());
                                    break;

                            }
                        } while (choice!="m");
                       
                        break;
                    case 7:
                        Console.WriteLine("Program bitdi");
                        break;

                }
            } while (num!=7);
            

        }
    }
}
