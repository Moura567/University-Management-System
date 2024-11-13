using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormsApp1
{
    internal class CourseStudent
    {
        public int studentid { set; get; }
        public Student Student { set; get; }
        public int courseid { set; get; }
        public Course Course { set; get; }

    }
}
