using Microsoft.EntityFrameworkCore;
using ComputerShopDatabaseImplement.Models;

namespace ComputerShopDatabaseImplement
{
    public class ComputerShopDatabase : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (optionsBuilder.IsConfigured == false)
            {
                optionsBuilder.UseSqlServer(@"Server=localhost;Database=computershop;Trusted_Connection=True;");
            }
            base.OnConfiguring(optionsBuilder);
        }

        public virtual DbSet<Component> Components { set; get; } 

        public virtual DbSet<Computer> Computers { set; get; }

        public virtual DbSet<ComputerComponent> ComputerComponents { set; get; }

        public virtual DbSet<Order> Orders { set; get; }
    }
}
