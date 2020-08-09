using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;
using User.Domain.Models;

namespace User.Data.Context
{
    public class UserContext : DbContext
    {
        public UserContext(DbContextOptions<UserContext> options) : base(options)
        {

        }

        public DbSet<TDDUser> Users { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<TDDUser>(e =>
            {
                e.ToTable("user").HasKey(k => k.Id);
                e.Property(p => p.Id).ValueGeneratedOnAdd();
            });
        }
    }
}
