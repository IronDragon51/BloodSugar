

using BloodSugar010.Models;
using Microsoft.EntityFrameworkCore;

namespace BloodSugar010.Data
{
    public class MyDBContext : DbContext
    {
        public MyDBContext(DbContextOptions<MyDBContext> opt) : base(opt)
        {

        }
        public DbSet<User> users { get; set; }
    }
}
