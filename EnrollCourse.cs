using Microsoft.EntityFrameworkCore;
using Microsoft.VisualBasic.Devices;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsApp1
{
    public partial class EnrollCourse : Form
    {
        Context context = new Context();
        int deptid = 0;
        int cid = 0;
        public EnrollCourse()
        {
            InitializeComponent();
            content();
        }
        public void content()
        {
            var departments = context.departments.ToList();
            deptbox.DataSource = departments;
            deptbox.DisplayMember = "name";
            deptbox.ValueMember = "id";
            deptbox.SelectedIndex = -1;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void deptbox_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                var crsid = string.Empty;
                if (deptbox.SelectedIndex != -1)
                {
                    var selectedValue = deptbox.SelectedValue.ToString();
                    Int32.TryParse(selectedValue, out deptid);

                    var deptcrs = context.courses.Where(e => e.departmentid == deptid).ToList();
                    comboBox1.DataSource = deptcrs;
                    if (deptcrs.Count == 0)
                    {
                        comboBox1.SelectedIndex = -1;
                        comboBox1.DataSource = null;
                        //courseid = 0;
                    }
                    else
                    {
                        crsid = comboBox1.SelectedValue.ToString();
                        Int32.TryParse(crsid, out cid);
                        comboBox1.DisplayMember = "name";
                        comboBox1.ValueMember = "id";
                        comboBox1.SelectedIndex = -1;
                    }

                }
            }
            catch { }
        }

        private void levelBox_TextChanged(object sender, EventArgs e)
        {
        }

        private void show_Click(object sender, EventArgs e)
        {

            try
            {
                var level = levelBox.Text.ToString();
                Int32.TryParse(level, out int intlevel);
                var selectedValue = deptbox.SelectedValue.ToString();
                Int32.TryParse(selectedValue, out deptid);
                if (intlevel == 0)
                    MessageBox.Show("select level please");
                else
                {
                    var course = context.courses.Find(cid);
                    var students = context.students.Include(s=>s.courses).Where(s=>s.level==intlevel&&!s.courses.Contains(course))
                        .ToList();
                    listBox1.DataSource = students;
                    listBox1.DisplayMember = "name";
                    listBox1.ValueMember = "id";
                    if (students.Count == 0)
                    {
                        var res = MessageBox.Show("All students enrolled this course do you want to show them? ", "", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                        if (res == DialogResult.No)
                            listBox1.DataSource = null;
                        else
                        {
                            listBox1.DataSource = context.students.Where(s => s.level == intlevel).ToList();
                            listBox1.DisplayMember = "name";
                            listBox1.ValueMember = "id";
                        }

                    }
                    else
                    {

                        listBox1.DataSource = students;
                        listBox1.DisplayMember = "name";
                        listBox1.ValueMember = "id";
                    }
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }

        }

        private void Refresh_Click(object sender, EventArgs e)
        {
            listBox1.DataSource = null;
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            var crsid = string.Empty;
            if (comboBox1.SelectedValue != null)
            {
                crsid = comboBox1.SelectedValue.ToString();
                Int32.TryParse(crsid, out cid);
            }
        }

        private void enroll_Click(object sender, EventArgs e)
        {
            var course = context.courses.Find(cid);
            var student = new Student();
            List<Student> students = new List<Student>();
            int x = 0;

            try
            {
            foreach (var item in listBox1.SelectedItems)
            {

                if (!students.Contains((Student)item) && !course.students.Contains((Student)item))
                {
                    student = (Student)item;
                    student = context.students.Find(student.id);
                    students.Add(student);
                    course.students.Add(student);
                    if (!student.courses.Contains(course))
                    { student.courses.Add(course); }

                }
                else
                { MessageBox.Show("This students already enrolled the course"); break; }
                x = context.SaveChanges();
            }
            if (x != 0)
                MessageBox.Show("Added Successfully");
            else
                MessageBox.Show("can't save changes");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            students.Clear();

        }

        private void unroll_Click(object sender, EventArgs e)
        {
            var course = context.courses.Include(c => c.students).FirstOrDefault(c => c.id == cid);
            if (course == null)
            {
                MessageBox.Show("Course not found.");
                return;
            }

            try
            {

                foreach (var item in listBox1.SelectedItems)
                {
                    if (item is Student selectedStudent)
                    {
                        var student = context.students.Include(s => s.courses).FirstOrDefault(s => s.id == selectedStudent.id);
                        if (student == null)
                        {
                            MessageBox.Show("Student not found.");
                            continue;
                        }

                        if (course.students.Contains(student) && student.courses.Contains(course))
                        {
                            course.students.Remove(student);

                            student.courses.Remove(course);

                        }
                        else
                        {
                            MessageBox.Show($"{student.name} is not enrolled in the course {course.name}.");
                        }
                    }
                    else
                    {
                        MessageBox.Show("Invalid item selected.");
                    }
                }

                int result = context.SaveChanges();
                if (result > 0)
                {
                    MessageBox.Show("Removed successfully.");
                }
                else
                {
                    MessageBox.Show("No changes were made.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred: {ex.Message}");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var home = new MainForm();
            home.Show();
            this.Hide();
        }
    }
}
