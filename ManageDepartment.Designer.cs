using System;

namespace WinFormsApp1
{
    partial class ManageDepartment
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            panel1 = new System.Windows.Forms.Panel();
            label3 = new System.Windows.Forms.Label();
            button2 = new System.Windows.Forms.Button();
            label6 = new System.Windows.Forms.Label();
            searchBox = new System.Windows.Forms.TextBox();
            label5 = new System.Windows.Forms.Label();
            AddBtn = new System.Windows.Forms.Button();
            EditBtn = new System.Windows.Forms.Button();
            DeleteBtn = new System.Windows.Forms.Button();
            dataGridView1 = new System.Windows.Forms.DataGridView();
            label4 = new System.Windows.Forms.Label();
            Refresh = new System.Windows.Forms.Button();
            label1 = new System.Windows.Forms.Label();
            capacitybox = new System.Windows.Forms.TextBox();
            namebox = new System.Windows.Forms.TextBox();
            panel2 = new System.Windows.Forms.Panel();
            button1 = new System.Windows.Forms.Button();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = System.Drawing.SystemColors.HotTrack;
            panel1.Controls.Add(label3);
            panel1.Controls.Add(button2);
            panel1.Dock = System.Windows.Forms.DockStyle.Top;
            panel1.Location = new System.Drawing.Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new System.Drawing.Size(1335, 100);
            panel1.TabIndex = 14;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new System.Drawing.Font("Segoe UI Semilight", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            label3.Location = new System.Drawing.Point(543, 29);
            label3.Name = "label3";
            label3.Size = new System.Drawing.Size(222, 31);
            label3.TabIndex = 1;
            label3.Text = "Manage Department";
            // 
            // button2
            // 
            button2.BackColor = System.Drawing.Color.Transparent;
            button2.BackgroundImage = Properties.Resources.close_48px;
            button2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            button2.Dock = System.Windows.Forms.DockStyle.Right;
            button2.FlatAppearance.BorderSize = 0;
            button2.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red;
            button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            button2.Location = new System.Drawing.Point(1261, 0);
            button2.Name = "button2";
            button2.Size = new System.Drawing.Size(74, 100);
            button2.TabIndex = 0;
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            label6.Location = new System.Drawing.Point(969, 111);
            label6.Name = "label6";
            label6.Size = new System.Drawing.Size(150, 29);
            label6.TabIndex = 38;
            label6.Text = "Departments";
            // 
            // searchBox
            // 
            searchBox.Location = new System.Drawing.Point(800, 165);
            searchBox.Name = "searchBox";
            searchBox.Size = new System.Drawing.Size(318, 29);
            searchBox.TabIndex = 37;
            searchBox.TextChanged += searchBox_TextChanged;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            label5.Location = new System.Drawing.Point(726, 171);
            label5.Name = "label5";
            label5.Size = new System.Drawing.Size(75, 25);
            label5.TabIndex = 36;
            label5.Text = "Search";
            // 
            // AddBtn
            // 
            AddBtn.BackColor = System.Drawing.Color.LightCoral;
            AddBtn.FlatAppearance.BorderSize = 0;
            AddBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            AddBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            AddBtn.Location = new System.Drawing.Point(25, 540);
            AddBtn.Name = "AddBtn";
            AddBtn.Size = new System.Drawing.Size(136, 46);
            AddBtn.TabIndex = 35;
            AddBtn.Text = "Add";
            AddBtn.UseVisualStyleBackColor = false;
            AddBtn.Click += AddBtn_Click;
            // 
            // EditBtn
            // 
            EditBtn.BackColor = System.Drawing.Color.LightGreen;
            EditBtn.FlatAppearance.BorderSize = 0;
            EditBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            EditBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            EditBtn.Location = new System.Drawing.Point(195, 540);
            EditBtn.Name = "EditBtn";
            EditBtn.Size = new System.Drawing.Size(136, 46);
            EditBtn.TabIndex = 34;
            EditBtn.Text = "Edit";
            EditBtn.UseVisualStyleBackColor = false;
            EditBtn.Click += EditBtn_Click;
            // 
            // DeleteBtn
            // 
            DeleteBtn.BackColor = System.Drawing.Color.Red;
            DeleteBtn.FlatAppearance.BorderSize = 0;
            DeleteBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            DeleteBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            DeleteBtn.Location = new System.Drawing.Point(365, 540);
            DeleteBtn.Name = "DeleteBtn";
            DeleteBtn.Size = new System.Drawing.Size(136, 46);
            DeleteBtn.TabIndex = 33;
            DeleteBtn.Text = "Delete";
            DeleteBtn.UseVisualStyleBackColor = false;
            DeleteBtn.Click += DeleteBtn_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new System.Drawing.Point(607, 200);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.RowTemplate.Height = 31;
            dataGridView1.Size = new System.Drawing.Size(707, 397);
            dataGridView1.TabIndex = 32;
            dataGridView1.CellClick += dataGridView1_CellClick;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            label4.Location = new System.Drawing.Point(25, 270);
            label4.Name = "label4";
            label4.Size = new System.Drawing.Size(89, 25);
            label4.TabIndex = 31;
            label4.Text = "Capacity";
            // 
            // Refresh
            // 
            Refresh.BackColor = System.Drawing.SystemColors.HotTrack;
            Refresh.FlatAppearance.BorderSize = 0;
            Refresh.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            Refresh.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            Refresh.Location = new System.Drawing.Point(1220, 162);
            Refresh.Name = "Refresh";
            Refresh.Size = new System.Drawing.Size(94, 32);
            Refresh.TabIndex = 29;
            Refresh.Text = "Refresh";
            Refresh.UseVisualStyleBackColor = false;
            Refresh.Click += Refresh_Click_1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            label1.Location = new System.Drawing.Point(19, 203);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(170, 25);
            label1.TabIndex = 27;
            label1.Text = "Department Name";
            // 
            // capacitybox
            // 
            capacitybox.Location = new System.Drawing.Point(195, 266);
            capacitybox.Name = "capacitybox";
            capacitybox.Size = new System.Drawing.Size(318, 29);
            capacitybox.TabIndex = 26;
            // 
            // namebox
            // 
            namebox.Location = new System.Drawing.Point(195, 205);
            namebox.Name = "namebox";
            namebox.Size = new System.Drawing.Size(318, 29);
            namebox.TabIndex = 25;
            // 
            // panel2
            // 
            panel2.BackColor = System.Drawing.SystemColors.HotTrack;
            panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            panel2.Location = new System.Drawing.Point(0, 681);
            panel2.Name = "panel2";
            panel2.Size = new System.Drawing.Size(1335, 29);
            panel2.TabIndex = 39;
            // 
            // button1
            // 
            button1.BackColor = System.Drawing.SystemColors.HotTrack;
            button1.FlatAppearance.BorderSize = 0;
            button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            button1.Location = new System.Drawing.Point(195, 606);
            button1.Name = "button1";
            button1.Size = new System.Drawing.Size(136, 46);
            button1.TabIndex = 81;
            button1.Text = "Home";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // ManageDepartment
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(10F, 22F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(1335, 710);
            Controls.Add(button1);
            Controls.Add(panel2);
            Controls.Add(label6);
            Controls.Add(searchBox);
            Controls.Add(label5);
            Controls.Add(AddBtn);
            Controls.Add(EditBtn);
            Controls.Add(DeleteBtn);
            Controls.Add(dataGridView1);
            Controls.Add(label4);
            Controls.Add(Refresh);
            Controls.Add(label1);
            Controls.Add(capacitybox);
            Controls.Add(namebox);
            Controls.Add(panel1);
            FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            Name = "ManageDepartment";
            Text = "a";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }



        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox searchBox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button AddBtn;
        private System.Windows.Forms.Button EditBtn;
        private System.Windows.Forms.Button DeleteBtn;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button Refresh;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox capacitybox;
        private System.Windows.Forms.TextBox namebox;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button button1;
    }
}