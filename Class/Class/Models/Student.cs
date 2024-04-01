namespace Class.Models
{
    class Student
    {
        //field
        public byte Age;
        public string GroupName = "AB106";
        public bool IsActive;

        //constructor
        public Student()
        {
            IsActive = true;
        }
        /// <summary>
        /// Student yaratmaq uchun lazim olan ctor
        /// </summary>
        /// <param name="ad">Bura adi daxil edin</param>
        /// <param name="soyad">Bura soyadi daxil edin</param>
        /// <param name="age">Bura yashi daxil edin</param>
        //public Student(string ad, string soyad, byte age) : this(ad, soyad)
        //{
        //    Age = age;
        //}
        //public Student(string name, string surname) : this(name)
        //{
        //    Surname = surname;
        //}
        //public Student(string name)
        //{
        //    Name = name;
        //}
        //method
        //public void PrintInfo()
        //{
        //    Console.WriteLine($"{GroupName} - {Name} {Surname} {Age}");
        //}
    }
}
