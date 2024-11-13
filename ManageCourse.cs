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

namespace WinFormsApp1
{
    public partial class ManageCourse : Form
    {
        int id = 0;
        Context Context = new Context();
        public ManageCourse()
        {
            InitializeComponent();
            content();
        }

        public void wrong()
        {
            MessageBox.Show("Try again there is something wrong");

        }
        public async void clear()
        {
            namebox.Clear();
            idbox.Clear();
            DeptIDBox.Clear();
            HoursBox.Clear();
        }

        public async void content()
        {
            dataGridView1.DataSource = Context.courses.Select(s => new {id=s.id, name = s.name, hour=s.hour,deptid=s.departmentid,numbersofstudent=s.students.Count}).ToList();
        }
        private async void AddBtn_Click(object sender, EventArgs e)
        {
            var coures = new Course();
            coures.name = namebox.Text;
            coures.id = Convert.ToInt32(idbox.Text);
            coures.hour = Convert.ToInt32(HoursBox.Text);
            coures.departmentid = Convert.ToInt32(DeptIDBox.Text);
            if (1 == coures.Add(coures, Context))
                MessageBox.Show("Added Successfully");
            else
                wrong();
            content();
            clear();
        }


        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private async void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int indexRow = e.RowIndex;
            DataGridViewRow Row = dataGridView1.Rows[indexRow];
            namebox.Text = Row.Cells[1].Value?.ToString() ?? string.Empty;
            idbox.Text = Row.Cells[0].Value?.ToString() ?? string.Empty;
            DeptIDBox.Text = Row.Cells[3].Value?.ToString() ?? string.Empty;
            HoursBox.Text = Row.Cells[2].Value?.ToString() ?? string.Empty;
            id = Convert.ToInt32(idbox.Text);
            dataGridView1.DataSource = Context.courses.Where(course => course.id == id)
                .Select(s => new { id = s.id, name = s.name, hour = s.hour, deptid = s.departmentid,
                numbersofstudent = s.students.Count }).ToList();
            idbox.ReadOnly = true;
        }

        private async void EditBtn_Click(object sender, EventArgs e)
        {
            var course = Context.courses.Find(id);
            course.name = namebox.Text;
            course.hour = Convert.ToInt32(HoursBox.Text);
            course.departmentid = Convert.ToInt32(DeptIDBox.Text);
            if (1 == course.update(course, Context))
                MessageBox.Show("Updated Successfully");
            else
                wrong();
            content();
            clear();
        }

        private async void DeleteBtn_Click(object sender, EventArgs e)
        {
            var course = Context.courses.Find(id);
            if (1 == course.Delete(course, Context))
                MessageBox.Show("Deleted Successfully");
            else
                wrong();
            content();
            clear();
        }

        private async void searchBox_TextChanged(object sender, EventArgs e)
        {
            var searched=from crs in Context.courses
                         where EF.Functions.Like(crs.name,$"%{searchBox.Text}%")
                         select new {id=crs.id,Name=crs.name,Hours=crs.hour,departmentId=crs.departmentid, numbersofstudent = crs.students.Count };
            dataGridView1.DataSource = searched.ToList();
        }

        private async void Refresh_Click(object sender, EventArgs e)
        {
            content();
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

    }
}
