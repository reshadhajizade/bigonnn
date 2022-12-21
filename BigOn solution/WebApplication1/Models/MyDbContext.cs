using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace WebApplication1.Models
{
    public class MyDbContext:IdentityDbContext
    {
        public MyDbContext(DbContextOptions options)
            : base(options) 
        {

        }
    }
}
