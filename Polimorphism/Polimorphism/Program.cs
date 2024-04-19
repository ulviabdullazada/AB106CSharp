using Polimorphism.Interfaces;
using Polimorphism.Models;
using System.Data.Common;

namespace Polimorphism
{
    class Program
    {
        static void Main()
        {
            #region Polimorphism
            //Shark akula = new Shark("Akula");
            //Eagle qartal = new Eagle("Shahin");
            //Cat mestan = new("Şahin");
            //Animal[] animals = { akula, qartal, mestan, new Chicken("asd") };
            //Animal a = new Shark("Akula");
            //a.Eat();
            //foreach (var animal in animals)
            //{
            //    animal.Eat();
            //}
            //ISwim dog = new Dog("Toplan");
            //ISwim fish = new Shark("Akula");
            //ISwim[] swimmers = new ISwim[] { fish, dog };
            //foreach (var swimmer in swimmers)
            //{
            //    swimmer.Swim();
            //}
            //IDivide c = new Calculate();
            //Console.WriteLine(c.Divide(1, 5));
            #endregion

            #region Upcasting, Downcasting
            //Shark akula = new Shark("Akula");
            //Eagle qartal = new Eagle("Shahin");
            //Cat mestan = new("Şahin");
            ////upcasting
            //Animal a = new Shark("Akula");
            //Animal[] animals = { akula, qartal, mestan, new Chicken("asd"), a };
            //foreach (var animal in animals) 
            //{
            //    //Cat cat = (Cat)animal;
            //    //Cat cat = animal as Cat;
            //    //if (cat != null)
            //    //{
            //    //    cat.Risofkalanmaq();
            //    //}
            //    //cat.Risofkalanmaq();
            //    if (animal is Cat cat)
            //    {
            //        //downcasting
            //        //Cat cat = (Cat)animal;
            //        cat.Risofkalanmaq();
            //    }
            //    else if (animal is Eagle)
            //    {
            //        Eagle eagle = (Eagle)animal;
            //        eagle.Hunt();
            //    }
            //    else if (animal is Shark)
            //    {
            //        Shark s = (Shark)animal;
            //        s.Sniff();
            //    }
            //}
            #endregion

            #region Boxing, Unboxing
            //Boxing => Value type-i reference type-a cevirmek
            //Unboxing => Reference type-i value type-a cevirmek
            string text = 5.ToString(); //boxing
            int num = Convert.ToInt32(text); //unboxing
            #endregion

            #region operator overload
            //Person anar = new()
            //{
            //    Name = "Anar",
            //    Surname = "Gasimzada",
            //    Age = 21
            //};
            //Person orxan = new()
            //{
            //    Name = "Orxan",
            //    Surname = "Gurbanli",
            //    Age = 20
            //};
            //Person orxan2 = new()
            //{
            //    Name = "Orxan",
            //    Surname = "Gurbanli",
            //    Age = 20
            //};
            //var a = orxan2 != orxan;
            //Console.WriteLine(a);
            #endregion

            //Heyvan<Eagle> park = new(new Eagle[] {
            //    new Eagle("Shahin"),
            //    new Eagle("Qartal")
            //});
            //Heyvan<Bird> park2 = new(new Bird[] {
            //    new Eagle("Shahin"),
            //    new Eagle("Qartal")
            //});
            //Heyvan<Dog> park3 = new(new Dog[] {
            //    new Dog("Alabay"),
            //    new Dog("Toplan")
            //});
            //Heyvan<Shark> park4 = new(new Shark[] {
            //    new Shark("Alabay"),
            //    new Shark("Toplan")
            //});
            //Heyvan<int> nums = new Heyvan<int>(new int[] { 1, 2, 3, 4 });
        }
    }
    class Heyvan<T> where T : Animal,ISwim, new()
    {
        public T[] Animals { get; private set; }
        public Heyvan(T[] arr)
        {
            Animals = arr;
        }
    }
    class Person
    {
        public string Name { get; set; }
        public string Surname { get; set; }
        public int Age { get; set; }
        public int WorkingExperience { get; set; }

        public static bool operator >(Person left, Person right)
        {
            return left.Age > right.Age;
        }
        public static bool operator <(Person left, Person right)
        {
            return left.Age < right.Age;
        }
        public static bool operator ==(Person left, Person right)
        {
            if (left.Name != right.Name ||
                left.Surname != right.Surname ||
                left.Age != right.Age) return false;
            return true;
        }
        public static bool operator !=(Person left, Person right)
        {
            return !(left == right);
        }
    }
}
