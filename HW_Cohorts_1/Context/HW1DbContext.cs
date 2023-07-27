using HW_Cohorts_1.Entities;
using HW_Cohorts_1.EntityTypeConfigurations;
using Microsoft.EntityFrameworkCore;

namespace HW_Cohorts_1.Context
{
    public class HW1DbContext:DbContext
    {
        public HW1DbContext(DbContextOptions<HW1DbContext> options):base(options) 
        {
            
        }
        //dbset
        public DbSet<User> Users { get; set; }
        public DbSet<Order> Orders { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new UserConfig());
            modelBuilder.ApplyConfiguration(new OrderConfig());

            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<User>().HasData(
                new User() { Id=1, IsActive=true, Email="johndoe@gmail.com", FirstName="John", LastName="Doe" },
                new User() { Id=2, IsActive=true, Email="jeyndoe@gmail.com", FirstName="Jeyn", LastName="Doe" }
                );

            modelBuilder.Entity<Order>().HasData(
                new Order() { Id=1, IsActive=true, AddedDate=new DateTime(2020,10,05), Description="kalem", Quantity=2, UnitPrice=15, status=Enums.Status.Confirmed, ModifiedDate=new DateTime(2023,12,05), UserId=1 }
                );
        }
    }
}
