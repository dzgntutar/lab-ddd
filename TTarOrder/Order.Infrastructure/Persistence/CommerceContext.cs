using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Order.Infrastructure.Persistence
{
    public  class CommerceContext : DbContext
    {
        public CommerceContext(DbContextOptions<CommerceContext> options) :base(options)
        {

        }

        public DbSet<Domain.AggregateModels.OrderModels.Order> Orders { get; set; }    
        public DbSet<Domain.AggregateModels.OrderModels.OrderItem> OrderItems { get; set; }
        public DbSet<Domain.AggregateModels.OrderModels.Address> Addresses{ get; set; }


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseInMemoryDatabase("TestDB");
            base.OnConfiguring(optionsBuilder);
        }
    }
}
