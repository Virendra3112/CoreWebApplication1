using CoreWebApplication1.Models;
using Microsoft.EntityFrameworkCore;

namespace CoreWebApplication1
{
    public class EFDataContext : DbContext
    {
        public DbSet<User> Users { get; set; }


        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"data source=serverName; initial catalog=TestDB;persist security info=True;user id=sa");
        }
    }
}
