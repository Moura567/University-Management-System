using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormsApp1
{
    internal class Context : DbContext
    {
        public Context() : base()
        {

        }
        public DbSet<staff> staff { set; get; }
        public DbSet<Department> departments { set; get; }
        public DbSet<Course> courses { set; get; }
        public DbSet<Student> students { set; get; }
        public DbSet<CourseStudent> CourseStudents { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Data source = LIONEL_MOURA; Initial catalog = StudentAffairs; integrated security = true");

        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<staff>()
                .Property(s => s.password)
                .HasDefaultValue("12345678");
            modelBuilder.Entity<Student>()
                .Property(s => s.hours)
                .HasDefaultValue(18);



            modelBuilder.Entity<Student>()
               .HasMany(s => s.courses).
               WithMany(c => c.students).
               UsingEntity<CourseStudent>
               (
                j => j.HasOne(p => p.Course).WithMany(p => p.CourseStudent).HasForeignKey(p => p.courseid),

                j => j.HasOne(p => p.Student).WithMany(p => p.CourseStudent).HasForeignKey(p => p.studentid),
                j => j.HasKey(k => new {k.studentid,k.courseid})
                );
            modelBuilder.Entity<Student>().Property(s => s.BirthDate).HasDefaultValue(DateTime.Now);
            modelBuilder.Entity<Student>().Property(s => s.departmentId).HasDefaultValue(8);
            modelBuilder.Entity<Student>().Property(s => s.level).HasDefaultValue(1);
            modelBuilder.Entity<Student>().Property(s => s.gpa).HasDefaultValue(0.0);
            modelBuilder.Entity<Student>()
               .Property(s => s.dept)
               .HasDefaultValue("General");
            base.OnModelCreating(modelBuilder);

        }

    }
}
