using System;
using System.Collections.Generic;
using System.Text;
using Frameworklab.Models;
using Microsoft.EntityFrameworkCore;

namespace Frameworklab.DbContexts
{
    internal class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext() : base() { }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=localhost\\SQLEXPRESS;Database=ApplicationDb;Trusted_Connection=True;  TrustServerCertificate=True");
            base.OnConfiguring(optionsBuilder);
        }

        public DbSet<Student> students { get; set; }
        public DbSet<Book> books { get; set; }



    }
}
