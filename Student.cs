using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormsApp1
{
    internal class Student : CRUD<Student>
    {


        public int id { get; set; }

        public string name { get; set; }

        public double gpa{ get; set; }

        public DateTime BirthDate{ get; set; }

        public string address { get; set; }

        public int level { get; set; }

        public string phone { get; set; }
        public string NID { get; set; }
        [ForeignKey("department")]
        public int departmentId { get; set; }

        [Column("Department")]
        public string dept { get; set; }

        [DefaultValue(18)]
        public int hours { get; set; }
        public Department department { get; set; }
        public ICollection<CourseStudent> CourseStudent { get; set; } = new List<CourseStudent>();
        public ICollection<Course> courses { get; set; } = new List<Course>();

        public int Delete(Student student,Context context)
        {
            context.Remove(student);
            return context.SaveChanges();
        }
        public int Add(Student student, Context context)
        {
            context.Add(student);
            return context.SaveChanges();
        }
        public int update(Student student, Context context)
        {
            context.Update(student);
            return context.SaveChanges();
        }
    }
}
