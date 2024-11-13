using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormsApp1
{
    internal class Department : CRUD<Department>
    {
       // Context context = new Context();
        public int id{ get; set; }
        public string name { get; set; }

        public int capacity { get; set; }

        public ICollection<Student> students { get; set; }
                    public ICollection<Course> courses{ get; set; }


        public int Add(Department department,Context context)
        {
            
            context.departments.Add(department);
            return context.SaveChanges();
        }
        public int update(Department department,Context context)
        {
             context.Update(department);
            return context.SaveChanges();
        }
        public int Delete(Department department,Context context)
        {
            context.departments.Remove(department); return context.SaveChanges();
        }
    }
}
