using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormsApp1
{
    internal class Course:CRUD<Course>
    {
        
        public  int id { get; set; }
        public string name { get; set; }
        public int hour { get; set; }

        public int departmentid { get; set; }
        public Department Department { get; set; }
        public ICollection<CourseStudent> CourseStudent { get; set; } = new List<CourseStudent>();
        public ICollection<Student> students { get; set; } = new List<Student>();
        public int Add(Course course,Context context)
        {
            context.Add(course);
            return context.SaveChanges();
        }
        public int update(Course course, Context context)
        {
            context.Update(course);
            return context.SaveChanges();
        }
        public int Delete(Course course, Context context)
        {
            context.Remove(course);
            return context.SaveChanges();
        }
    }
}
