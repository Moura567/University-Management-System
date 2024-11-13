using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace WinFormsApp1
{
    public partial class ManageStudent : Form
    {
        Context context = new Context();
        int id = 0;
        int indexRow = 0;
        public ManageStudent()
        {
            InitializeComponent();
            content();
        }
        public void content()
        {
            var studentData = context.students
                .Include(s => s.department)
                .Include(s => s.CourseStudent)
                .Select(s => new
                {
                    id = s.id,
                    name = s.name,
                    gpa = s.gpa,
                    birthdate = s.BirthDate,
                    address = s.address,
                    level = s.level,
                    phone = s.phone,
                    nid = s.NID,
                    department = s.department.name,
                    hours = s.hours,
                    NumberOfCourses = s.CourseStudent.Count
                })
                .ToList();

            dataGridView1.DataSource = studentData;


        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void DeleteBtn_Click(object sender, EventArgs e)
        {
            var student = context.students.Find(id);
            student.Delete(student, context);
            content();
            clear();
        }

        private void clear()
        {
            namebox.Clear();
            gpaBox.Clear();
            birthBox.Clear();
            levelBox.Clear();
            NidBox.Clear();
            deptBox.Clear();
            AddressBox.Clear();
            PhoneBox.Clear();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            indexRow = e.RowIndex;
            DataGridViewRow row = dataGridView1.Rows[indexRow];

            namebox.Text = row.Cells[1].Value?.ToString() ?? string.Empty;
            gpaBox.Text = row.Cells[2].Value?.ToString() ?? string.Empty;
            id = Convert.ToInt32(row.Cells[0].Value);
            birthBox.Text = row.Cells[3].Value?.ToString() ?? string.Empty;
            AddressBox.Text = row.Cells[4].Value?.ToString() ?? string.Empty;
            levelBox.Text = row.Cells[5].Value?.ToString() ?? string.Empty;
            PhoneBox.Text = row.Cells[6].Value?.ToString() ?? string.Empty;
            NidBox.Text = row.Cells[7].Value?.ToString() ?? string.Empty;
            deptBox.Text = (row.Cells[8].Value?.ToString());

            var studentData = context.students.Where(s => s.id == id)
                .Include(s => s.department)
                .Include(s => s.CourseStudent)
                .Select(s => new
                {
                    id = s.id,
                    name = s.name,
                    gpa = s.gpa,
                    birthdate = s.BirthDate,
                    address = s.address,
                    level = s.level,
                    phone = s.phone,
                    nid = s.NID,
                    department = s.department.name,
                    hours = s.hours,
                    NumberOfCourses = s.CourseStudent.Count
                })
                .ToList();

            dataGridView1.DataSource = studentData;
        }

        private void AddBtn_Click(object sender, EventArgs e)
        {
            try
            {
                var stud = new Student();
                stud.name = namebox.Text;

                if (!string.IsNullOrWhiteSpace(gpaBox.Text))
                {
                    stud.gpa = Convert.ToDouble(gpaBox.Text);
                }

                stud.phone = PhoneBox.Text;
                stud.address = AddressBox.Text;

                if (!string.IsNullOrWhiteSpace(birthBox.Text))
                {
                    stud.BirthDate = Convert.ToDateTime(birthBox.Text);
                }

                if (!string.IsNullOrWhiteSpace(levelBox.Text))
                {
                    stud.level = Convert.ToInt32(levelBox.Text);
                }

                if (!string.IsNullOrWhiteSpace(deptBox.Text))
                {
                    stud.dept = deptBox.Text;
                }

                if (!string.IsNullOrWhiteSpace(deptBox.Text))
                {
                    stud.departmentId = context.departments
                        .Where(x => x.name.ToLower() == deptBox.Text.ToLower())
                        .Select(x => x.id)
                        .FirstOrDefault();
                }
                stud.NID = NidBox.Text;
                if (stud.Add(stud, context) == 1)
                    MessageBox.Show("Added Successfully");
                else
                    wrong();
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
            content();
            clear();

        }

        public void wrong()
        {
            MessageBox.Show("Try again there is something wrong");

        }

        private void EditBtn_Click(object sender, EventArgs e)
        {
            try
            {


                var stud = context.students.Find(id);

                stud.name = namebox.Text;
                stud.gpa = Convert.ToDouble(gpaBox.Text);
                stud.phone = PhoneBox.Text;

                stud.BirthDate = Convert.ToDateTime(birthBox.Text);
                stud.address = AddressBox.Text;
                stud.level = Convert.ToInt32(levelBox.Text);
                stud.phone = PhoneBox.Text;
                stud.NID = NidBox.Text;
                stud.dept = deptBox.Text;
                stud.departmentId = context.departments.Where(d => d.name == stud.dept).Select(d => d.id).Single();

                if (1 == stud.update(stud, context))
                    MessageBox.Show("Updated Successfully");
                else
                    wrong();
            }
            catch (Exception)
            {

                wrong();
            }

            content();
            clear();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            var home = new MainForm();
            home.Show();
            this.Hide();
        }

        private void Refresh_Click(object sender, EventArgs e)
        {
            content();
            clear();
        }

        private void searchBox_TextChanged(object sender, EventArgs e)
        {
            var studentData = context.students.Where(s => EF.Functions.Like(s.name,$"%{searchBox.Text}%")).
               Include(s => s.department)
               .Include(s => s.CourseStudent)
               .Select(s => new
               {
                   id = s.id,
                   name = s.name,
                   gpa = s.gpa,
                   birthdate = s.BirthDate,
                   address = s.address,
                   level = s.level,
                   phone = s.phone,
                   nid = s.NID,
                   department = s.department.name,
                   hours = s.hours,
                   NumberOfCourses = s.CourseStudent.Count
               })
               .ToList();

            dataGridView1.DataSource = studentData;
        }
    }
}