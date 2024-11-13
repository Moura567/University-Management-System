using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BCrypt.Net;

namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        Context context = new Context();
        public Form1()
        {
            InitializeComponent();
        }

        public void clear()
        {
            textBox1.Clear();

            textBox2.Clear();
        }
        public void check()
        {
            if (textBox1.Text.Length == 0 || textBox2.Text.Length == 0)
                { MessageBox.Show("Enter your username and password."); return; }
            else if (textBox2.Text.Length < 8)
                MessageBox.Show("Password should be at least 8 characters.");
        }

        private async void button1_Click(object sender, EventArgs e)
        {
            check();

            var staffMember = context.staff.FirstOrDefault(s => s.username == textBox1.Text);

            if (staffMember != null && BCrypt.Net.BCrypt.Verify(textBox2.Text, staffMember.password))
            {
                MessageBox.Show("Login successfully.");
                clear();
                var main = new MainForm();
                main.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Username or password is incorrect!");
                clear();
            }
        }


        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked == true)
            {
                textBox2.PasswordChar = '\0';
            }
            else
                textBox2.PasswordChar = '*';

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void textBox2_Enter(object sender, EventArgs e)
        {
          //  button1_Click(sender,e);
        }
    }
}
