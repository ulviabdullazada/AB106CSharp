namespace GenericTypes.Models
{
    class Student
    {
        static int _count = 1;
        public int Id { get; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public int Age { get; set; }
        public int Credits { get; set; }
        public Group Group { get; set; }
        public Student(string name, string surname, int age, int credits, Group group)
        {
            Id = _count++;
            Name = name;
            Surname = surname;
            Age = age;
            Credits = credits;
            Group = group;
        }
    }
}
