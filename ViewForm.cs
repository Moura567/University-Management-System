using Microsoft.EntityFrameworkCore;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace WinFormsApp1
{
    public partial class ViewForm : Form
    {
        Context context = new Context();
        int departmentId = 0;
        int courseId = 0;

        public ViewForm()
        {
            InitializeComponent();
            LoadDepartments();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        // Load departments into the department combo box
        public void LoadDepartments()
        {
            deptbox.DataSource = context.departments.ToList();
            deptbox.DisplayMember = "name";
            deptbox.ValueMember = "id";
            deptbox.SelectedIndex = -1;
        }

        private void deptbox_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                if (deptbox.SelectedIndex != -1)
                {
                    Int32.TryParse(deptbox.SelectedValue.ToString(), out departmentId);

                    // Load courses for the selected department
                    var deptCourses = context.courses.Where(c => c.departmentid == departmentId).ToList();
                    comboBox1.DataSource = deptCourses;

                    if (deptCourses.Count == 0)
                    {
                        comboBox1.DataSource = null;
                        courseId = 0;
                    }
                    else
                    {
                        comboBox1.DisplayMember = "name";
                        comboBox1.ValueMember = "id";
                    }
                }
            }
            catch (Exception ex)
            {
                ShowError("An error occurred while loading courses.");
            }
        }

        private void Refresh_Click(object sender, EventArgs e)
        {
            deptbox.SelectedIndex = -1;
            comboBox1.SelectedIndex = -1;
            dataGridView1.DataSource = null;
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox1.SelectedValue != null)
            {
                Int32.TryParse(comboBox1.SelectedValue.ToString(), out courseId);
            }
        }

        // Show all students
        private void AddBtn_Click(object sender, EventArgs e)
        {
            try
            {
                var allStudents = context.students.Where(s=>s.departmentId==departmentId&&s.courses.Any(c=>c.id==courseId)).Select(s => new { id = s.id, name=s.name,Level=s.level}).ToList();
                dataGridView1.DataSource = allStudents;
            }
            catch (Exception ex)
            {
                ShowError("An error occurred while displaying all students.");
            }
        }

        // Show students in the selected department
        private void EditBtn_Click(object sender, EventArgs e)
        {
            try
            {
                if (deptbox.SelectedValue != null)
                {
                    Int32.TryParse(deptbox.SelectedValue.ToString(), out departmentId);
                    var studentsInDepartment = context.students.Where(s => s.departmentId == departmentId).Select(s => new { id = s.id, name = s.name, Level = s.level }).ToList();
                    dataGridView1.DataSource = studentsInDepartment;
                }
            }
            catch (Exception ex)
            {
                ShowError("An error occurred while displaying students in the department.");
            }
        }

        // Show students in the selected course
        private void DeleteBtn_Click(object sender, EventArgs e)
        {
            try
            {
                if (comboBox1.SelectedValue != null)
                {
                    int courseId;
                    Int32.TryParse(comboBox1.SelectedValue.ToString(), out courseId);

                    var studentsInCourse = (from student in context.students
                                            join courseStudent in context.Set<CourseStudent>()
                                            on student.id equals courseStudent.studentid
                                            join course in context.courses
                                            on courseStudent.courseid equals course.id
                                            where course.id == courseId
                                            select new  { id = student.id, name = student.name, Level = student.level })
                                            .Distinct() 
                                            .ToList();

                    dataGridView1.DataSource = studentsInCourse;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred while displaying students in the course: " + ex.Message);
            }
        }






        // Search students by name
        private void searchBox_TextChanged(object sender, EventArgs e)
        {
            var searchTerm = searchBox.Text;
            var searchResult = context.students
                .Where(stud => EF.Functions.Like(stud.name, $"%{searchTerm}%")).Select(s => new { id = s.id, name = s.name, Level = s.level }).ToList();
            if (searchResult.Count == 0)
            {
                MessageBox.Show("No students found with this name.");
                dataGridView1.DataSource = null;
            }
            else
            {
                dataGridView1.DataSource = searchResult;
            }
        }

        // Error handling
        private void ShowError(string message)
        {
            MessageBox.Show(message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        // Navigate to main form
        private void button1_Click(object sender, EventArgs e)
        {
            var home = new MainForm();
            home.Show();
            this.Hide();
        }
    }
}
