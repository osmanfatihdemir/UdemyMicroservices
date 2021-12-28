using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FreeCourseServices.OrderInfrastructure
{
   public class OrderDbContext:DbContext
    {
        public const string DEFAULT_SCHEMA = "ordering";

        public OrderDbContext(DbContextOptions<OrderDbContext> options) : base(options)
        {

        }

        public override int SaveChanges()
        {

            return base.SaveChanges();
        }

        public DbSet<OrderDomain.OderAggregate.Order> Orders { get; set; }

        public DbSet<OrderDomain.OderAggregate.Order> OrderItems { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<OrderDomain.OderAggregate.Order>().ToTable("Orders", DEFAULT_SCHEMA);
            modelBuilder.Entity<OrderDomain.OderAggregate.OrderItem>().ToTable("OrderItems", DEFAULT_SCHEMA);

            modelBuilder.Entity<OrderDomain.OderAggregate.OrderItem>().Property(x => x.Price).HasColumnType("decimal(18,2)");

            modelBuilder.Entity<OrderDomain.OderAggregate.Order>().OwnsOne(o => o.Address).WithOwner();



            base.OnModelCreating(modelBuilder);
        }

    }
}
