using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using ContosoUni.Models;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;

namespace ContosoUni.DAL
{
    public class SchoolContext:DbContext
    {
        public SchoolContext():base("SchoolContext")
        {

        }
        public DbSet<Student> Students { get; set; }
        public DbSet<Enrollment> Enrollments { get; set; }
        public DbSet<Course> Courses { get; set; }
        
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            /*table names is pluralized or singular form, it can be whichever form
             you prefer by including or omitting this line of code*/
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
            base.OnModelCreating(modelBuilder);
        }
    }
} 