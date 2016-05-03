using MVCLoadMore.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace MVCLoadMore.DbContexts
{
    public class StudentDbContext:DbContext
    {
        public StudentDbContext()
            : base("name=Connectionstring ")
        { 
        
            
        }
        public DbSet<Student> Students { get; set; }
    }
}