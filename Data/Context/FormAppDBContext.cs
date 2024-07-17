using Entity.Concrete;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DB.Context
{
    public class FormAppDBContext : DbContext
    {
        //public FormAppDBContext(DbContextOptions<FormAppDBContext> options) : base(options)
        //{
        //}
        //public FormAppDBContext()
        //{

        //}


        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("server=(localdb)\\MSSQLLocalDB;DataBase=FormAppDB;Trusted_connection=true;");
        }

        //public FormAppDBContext()
        //{

        //}
        //public FormAppDBContext(DbContextOptions<FormAppDBContext> options) : base(options)
        //{

        //}

        //protected override void OnModelCreating(ModelBuilder builder)
        //{
        //    base.OnModelCreating(builder);
        //}

        public DbSet<User> Users { get; set; }
        public DbSet<Post> Posts { get; set; }
    }
}
