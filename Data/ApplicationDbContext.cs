using EVP.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace EVP.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        

        public DbSet<Booking> Bookings { get; set; }

        public DbSet<Address> Addresses { get; set; }

        public DbSet<Payment> Payments{ get; set; }

       

        public DbSet<Venue> Venues{ get; set; }

        public DbSet<Event> Event { get; set; }
        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
            builder.Entity<User>().ToTable("Users");

            builder.Entity<Role>().ToTable("Roles");

            builder.Entity<Event>().ToTable("Events");

        }
       
        public DbSet<User> User { get; set; }

        public DbSet<Role> Role { get; set; }
    } 
}
