using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EF_Core_test.Model
{

    public class DataBaseContext : Microsoft.EntityFrameworkCore.DbContext
    {

        public DataBaseContext()
        {
        }
        public DataBaseContext(DbContextOptions _options) //: base(options)
        {
        }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Data Source=DESKTOP-QFGNJ9B;Initial Catalog=EFTest;Integrated Security=True");
        }
        public virtual DbSet<Student> Student { get; set; }
        public virtual DbSet<CardStudent> CardStudent { get; set; }
        public virtual DbSet<Department> Department { get; set; }
        public virtual DbSet<Subject> Subject { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<StudentSubject>().HasKey(x => new {x.SubjectId,x.StudentId});
            base.OnModelCreating(modelBuilder);
        }
        //public virtual DbSet<StudentSubject> StudentSubject { get; set; }


    }
}
