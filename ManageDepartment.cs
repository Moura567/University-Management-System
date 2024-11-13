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
    public partial class ManageDepartment : Form
    {
        Context Context = new Context();
        public int indexRow = 0;
        public int id;

        public ManageDepartment()
        {
            InitializeComponent();
            content();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        public void wrong()
        {
            MessageBox.Show("Try again there is something wrong");

        }
        public void clear()
        {
            namebox.Clear();
            capacitybox.Clear();
        }
        private void content()
        {
            var departmentData = from dept in Context.departments
                                 let studentCount = dept.students.Count()
                                 select new
                                 {
                                     id = dept.id,
                                     name = dept.name,
                                     capacity = dept.capacity,
                                     numberOfStudent = studentCount,
                                     AvailablePlaces = dept.capacity - studentCount
                                 };

            dataGridView1.DataSource = departmentData.ToList();
        }
        private void AddBtn_Click(object sender, EventArgs e)
        {
            Department department = new Department();
            var cap = Convert.ToInt32(capacitybox.Text);
            var dept = new Department { name = namebox.Text, capacity = cap };
            var res = department.Add(dept, Context);
            if (res == 1)
                MessageBox.Show("Added Successfully");
            else
                wrong();

            content();
            clear();

        }
        private void EditBtn_Click(object sender, EventArgs e)
        {
            try
            {
                var department = Context.departments.Where(d => d.id == id).Select(d => d).First();
                department.name = namebox.Text;
                department.capacity = Convert.ToInt32(capacitybox.Text);
                if (department.update(department, Context) == 1)
                    MessageBox.Show("Updated Successfully");
                else
                    wrong();
            }
            catch (Exception ex) { wrong(); }
            content();
            clear();

        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            indexRow = e.RowIndex;
            DataGridViewRow row = dataGridView1.Rows[indexRow];

            namebox.Text = row.Cells[1].Value?.ToString() ?? string.Empty;
            capacitybox.Text = row.Cells[2].Value?.ToString() ?? string.Empty;
            id = Convert.ToInt32(row.Cells[0].Value);
            var departmentData = from dept in Context.departments
                                 where id == dept.id
                                 let studentCount = dept.students.Count()
                                 select new
                                 {
                                     id = dept.id,
                                     name = dept.name,
                                     capacity = dept.capacity,
                                     numberOfStudent = studentCount,
                                     AvailablePlaces = dept.capacity - studentCount
                                 };

            dataGridView1.DataSource = departmentData.ToList();
        }

        private void DeleteBtn_Click(object sender, EventArgs e)
        {
            var dept = Context.departments.Find(id);
            if (dept.Delete(dept, Context) == 1)
                MessageBox.Show("Deleted Successfully");
            else
                wrong();
            content();
            clear();

        }

        private void searchBox_TextChanged(object sender, EventArgs e)
        {
            var department = from dept in Context.departments
                             where EF.Functions.Like(dept.name, $"%{searchBox.Text}%")
                             let studentCount = dept.students.Count()
                             select new
                             {
                                 id = dept.id,
                                 name = dept.name,
                                 capacity = dept.capacity,
                                 numberOfStudent = studentCount,
                                 AvailablePlaces = dept.capacity - studentCount
                             };

            dataGridView1.DataSource = department.ToList();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            var home = new MainForm();
            home.Show();
            this.Hide();
        }
        private void Refresh_Click_1(object sender, EventArgs e)
        {
            content();
            clear();
        }
    }
}
