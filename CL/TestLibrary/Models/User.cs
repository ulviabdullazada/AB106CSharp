namespace TestLibrary.Models
{
    public class User : Person
    {
        public string Username { get; }
        public void Test()
        {
            Person p = new Person();
            p.Name = "askjdlsdf";
            p.Surname = "asdfhadfh";
        }
    }
}
