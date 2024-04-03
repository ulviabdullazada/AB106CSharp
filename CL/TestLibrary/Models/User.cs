namespace TestLibrary.Models
{
    public class User : Person
    {
        public string Username { get; }
        private protected int Num { get; set; }
        public void Test()
        {
            Name = "jksfhjksdhf";
            Person p = new Person();
            //p.Name = "askjdlsdf";
            p.Surname = "asdfhadfh";
        }
    }
}
