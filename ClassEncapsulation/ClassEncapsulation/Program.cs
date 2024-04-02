using ClassEncapsulation.Models;

namespace ClassEncapsulation
{
    internal class Program
    {
        static void Main(string[] args)
        {
           User user = new User("saBir   ","   guLiEv","Sabir123");
            user.ChangePassword("Sabir123", "uliyev123");
           
           Console.WriteLine(user.UserName);
        }
    }
}
