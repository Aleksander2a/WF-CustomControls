using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

using TestApp.Data.Models;

namespace TestApp.Data
{
    public class AppContext : DbContext
    {
        public DbSet<User> Users { get; set; }
        public DbSet<Event> Events { get; set; }


        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlServer(@"Server=(localdb)\MSSQLLocalDB; database=ControlsAppDB;Integrated Security=true");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            // Define Primary Keys
            modelBuilder.Entity<User>().HasKey(u => new { u.UserName });
            modelBuilder.Entity<Event>().HasKey(e => new { e.Date, e.Time });


            // Define constraints on fields
            modelBuilder.Entity<User>()
                .Property(u => u.Password)
                .IsRequired();

            modelBuilder.Entity<Event>()
                .Property(e => e.EventName)
                .IsRequired();
            modelBuilder.Entity<Event>()
                .Property(e => e.Priority)
                .IsRequired();
            modelBuilder.Entity<Event>()
                .Property(e => e.UserName)
                .IsRequired();


            // Define relations between tables
            modelBuilder.Entity<User>()
                .HasMany<Event>(u => u.Events)
                .WithOne(e => e.User)
                .HasForeignKey(e => e.UserName)
                .OnDelete(DeleteBehavior.Cascade);
        }
    }
}
