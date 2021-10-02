using CoreWebApplication1.Models;
using Microsoft.EntityFrameworkCore;

namespace CoreWebApplication1
{
    public class EFDataContext : DbContext
    {
        public DbSet<User> Users { get; set; }


        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            //optionsBuilder.UseSqlServer(@"data source=serverName; initial catalog=TestDB;persist security info=True;user id=sa");
            optionsBuilder.UseSqlServer(@"data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\viren\OneDrive\Documents\TestNew.mdf;Integrated Security=True;Connect Timeout=30");
        }
    }
}
