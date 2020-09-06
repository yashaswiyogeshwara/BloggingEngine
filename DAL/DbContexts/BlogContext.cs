using DAL.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Text;

namespace DAL.DbContexts
{
    public class BlogContext : DbContext
    {
        private IConfiguration configuration;
        public BlogContext() : base()
        {

        }
        public BlogContext(IConfiguration configuration) : base(){ 
        
        }
        
        public BlogContext(DbContextOptionsBuilder optionsBuilder) : base(optionsBuilder.Options) { 
        }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Blog> Blogs { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder) {
            optionsBuilder.UseSqlServer("Server=YOGESHWAR\\SQLDEV; Database=Blog; Trusted_Connection=True; MultipleActiveResultSets=true");
        }
    }
}
