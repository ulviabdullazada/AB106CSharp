namespace GenericTypes.Models
{
    class Group
    {
        static int _count = 1;
        public int Id { get; }
        public string Name { get; set; }
        public Group(string name)
        {
            Id = _count++;
            Name = name;
        }
    }
}
