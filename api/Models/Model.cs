using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;

namespace AspVue2.Models
{
    public class MyDbContext : DbContext
    {
        public MyDbContext(DbContextOptions<MyDbContext> options)
            :base(options)
        { }

        public DbSet<User> Users { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.HasSequence<int>("UserId");

            modelBuilder.Entity<User>()
                .Property(u => u.Id)
                .HasDefaultValueSql("NEXT VALUE FOR shared.UserId");
        }
    }

    public class User
    {
        public int Id { get; set; }
        public string Name { get; set; }
    }
}