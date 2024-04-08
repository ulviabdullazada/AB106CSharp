namespace Static
{
    class Student
    {
        public string Name { get; set; }
        public static float Pi { get; }
        static Student()
        {
            Console.WriteLine("Static ctor");
        }
        //public Student()
        //{
        //    Console.WriteLine("Normal ctor");
        //}
        public static void SayHi()
        {
            Console.WriteLine("Salam ");
        }
    }
    //static class Person : Student
    //{
        
    //}
}
