using LoginRegister.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace LoginRegister.DAL
{
    public class LoginDbContext : IdentityDbContext<AppUser>
    {
        public LoginDbContext(DbContextOptions options) : base(options)
        {
        }
    }
}
