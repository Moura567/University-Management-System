using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BCrypt.Net; // Ensure you're using BCrypt.Net from BCrypt.Net-Next
using Microsoft.EntityFrameworkCore;

namespace WinFormsApp1
{
    public partial class Manage_staff : Form
    {
        int indexRow = 0;
        Context context = new Context();

        public Manage_staff()
        {
            InitializeComponent();
            content();
        }

        public void wrong()
        {
            MessageBox.Show("Try again there is something wrong");
        }

        public void clear()
        {
            namebox.Clear();
            userbox.Clear();
            passwordbox.Clear();
        }

        private void content()
        {
            var staffList = context.staff.Select(s => new { s.username, s.name }).ToList();
            dataGridView1.DataSource = staffList;
        }

        private string HashPassword(string password)
        {
            return BCrypt.Net.BCrypt.HashPassword(password);
        }
        private bool VerifyPassword(string password, string hashedPassword)
        {
            return BCrypt.Net.BCrypt.Verify(password, hashedPassword);
        }


        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void DeleteBtn_Click(object sender, EventArgs e)
        {
            try
            {
                var staff = context.staff.FirstOrDefault(s => s.username == userbox.Text);
                if (staff != null)
                {
                    context.staff.Remove(staff);
                    context.SaveChanges();
                    MessageBox.Show("Deleted Successfully");
                    content();
                    clear();
                }
                else
                {
                    MessageBox.Show("Staff not found.");
                }
            }
            catch (Exception ex)
            {
                wrong();
            }
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                indexRow = e.RowIndex;
                DataGridViewRow row = dataGridView1.Rows[indexRow];
                namebox.Text = row.Cells["name"].Value?.ToString() ?? string.Empty;
                userbox.Text = row.Cells["username"].Value?.ToString() ?? string.Empty;
                //passwordbox.Text = row.Cells["password"].Value?.ToString() ?? string.Empty;
            }
        }

        private void dataGridView1_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            // Handle cell value changes if needed
            // Ensure to hash the password if it was changed
            // This can be complex, so it's better to handle updates via a dedicated button
        }
        private void AddBtn_Click(object sender, EventArgs e)
        {
            try
            {
                var plainPassword = string.IsNullOrEmpty(passwordbox.Text) ? "12345678" : passwordbox.Text;

                // Hash the password before storing it
                var hashedPassword = staff.HashPassword(plainPassword);

                var newStaff = new staff
                {
                    username = userbox.Text,
                    name = namebox.Text,
                    password = hashedPassword
                };

                context.staff.Add(newStaff);
                context.SaveChanges();
                MessageBox.Show("Added Successfully.");

                content();
                clear();
            }
            catch (Exception ex)
            {
                wrong();
            }
        }


        private void EditBtn_Click(object sender, EventArgs e)
        {
            var staffMember = context.staff.FirstOrDefault(s => s.username == userbox.Text);
            if (staffMember != null)
            {
                staffMember.name = namebox.Text;

                // Only hash and update password if the user entered a new one
                if (!string.IsNullOrEmpty(passwordbox.Text))
                {
                    if (passwordbox.Text.Length < 8)
                    {
                        MessageBox.Show("Password must be at least 8 characters long.");
                        return;
                    }
                    staffMember.password = staff.HashPassword(passwordbox.Text);
                }

                context.SaveChanges();
                MessageBox.Show("Updated Successfully.");
                content();
                clear();
            }
            else
            {
                MessageBox.Show("Staff not found.");
            }
        }


        private void searchBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                var staff = context.staff
                    .Where(s => EF.Functions.Like(s.username, $"%{searchBox.Text}%"))
                    .ToList();
                dataGridView1.DataSource = staff;
            }
        }

        private void searchBox_TextChanged(object sender, EventArgs e)
        {
            var staff = context.staff
                .Where(s => EF.Functions.Like(s.name, $"%{searchBox.Text}%"))
                .ToList();
            dataGridView1.DataSource = staff;
        }

        private void Refresh_Click(object sender, EventArgs e)
        {
            content();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var home = new MainForm();
            home.Show();
            this.Hide();
        }

    }
}
