namespace WinFormsApp1
{
    partial class ManageStudent
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
            panel2 = new System.Windows.Forms.Panel();
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
            gpaBox = new System.Windows.Forms.TextBox();
            namebox = new System.Windows.Forms.TextBox();
            label2 = new System.Windows.Forms.Label();
            label7 = new System.Windows.Forms.Label();
            AddressBox = new System.Windows.Forms.TextBox();
            birthBox = new System.Windows.Forms.TextBox();
            label8 = new System.Windows.Forms.Label();
            label9 = new System.Windows.Forms.Label();
            PhoneBox = new System.Windows.Forms.TextBox();
            levelBox = new System.Windows.Forms.TextBox();
            label10 = new System.Windows.Forms.Label();
            NidBox = new System.Windows.Forms.TextBox();
            label11 = new System.Windows.Forms.Label();
            deptBox = new System.Windows.Forms.TextBox();
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
            panel1.Size = new System.Drawing.Size(1323, 100);
            panel1.TabIndex = 40;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new System.Drawing.Font("Segoe UI Semilight", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            label3.Location = new System.Drawing.Point(533, 29);
            label3.Name = "label3";
            label3.Size = new System.Drawing.Size(178, 31);
            label3.TabIndex = 1;
            label3.Text = "Manage Student";
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
            button2.Location = new System.Drawing.Point(1249, 0);
            button2.Name = "button2";
            button2.Size = new System.Drawing.Size(74, 100);
            button2.TabIndex = 0;
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // panel2
            // 
            panel2.BackColor = System.Drawing.SystemColors.HotTrack;
            panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            panel2.Location = new System.Drawing.Point(0, 668);
            panel2.Name = "panel2";
            panel2.Size = new System.Drawing.Size(1323, 29);
            panel2.TabIndex = 53;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            label6.Location = new System.Drawing.Point(969, 111);
            label6.Name = "label6";
            label6.Size = new System.Drawing.Size(107, 29);
            label6.TabIndex = 52;
            label6.Text = "Students";
            // 
            // searchBox
            // 
            searchBox.Location = new System.Drawing.Point(800, 165);
            searchBox.Name = "searchBox";
            searchBox.Size = new System.Drawing.Size(318, 29);
            searchBox.TabIndex = 51;
            searchBox.TextChanged += searchBox_TextChanged;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            label5.Location = new System.Drawing.Point(726, 171);
            label5.Name = "label5";
            label5.Size = new System.Drawing.Size(75, 25);
            label5.TabIndex = 50;
            label5.Text = "Search";
            // 
            // AddBtn
            // 
            AddBtn.BackColor = System.Drawing.Color.LightCoral;
            AddBtn.FlatAppearance.BorderSize = 0;
            AddBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            AddBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            AddBtn.Location = new System.Drawing.Point(25, 539);
            AddBtn.Name = "AddBtn";
            AddBtn.Size = new System.Drawing.Size(136, 46);
            AddBtn.TabIndex = 49;
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
            EditBtn.Location = new System.Drawing.Point(195, 539);
            EditBtn.Name = "EditBtn";
            EditBtn.Size = new System.Drawing.Size(136, 46);
            EditBtn.TabIndex = 48;
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
            DeleteBtn.Location = new System.Drawing.Point(365, 539);
            DeleteBtn.Name = "DeleteBtn";
            DeleteBtn.Size = new System.Drawing.Size(136, 46);
            DeleteBtn.TabIndex = 47;
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
            dataGridView1.TabIndex = 46;
            dataGridView1.CellClick += dataGridView1_CellClick;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            label4.Location = new System.Drawing.Point(19, 177);
            label4.Name = "label4";
            label4.Size = new System.Drawing.Size(54, 25);
            label4.TabIndex = 45;
            label4.Text = "GPA";
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
            Refresh.TabIndex = 44;
            Refresh.Text = "Refresh";
            Refresh.UseVisualStyleBackColor = false;
            Refresh.Click += Refresh_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            label1.Location = new System.Drawing.Point(19, 114);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(64, 25);
            label1.TabIndex = 43;
            label1.Text = "Name";
            // 
            // gpaBox
            // 
            gpaBox.Location = new System.Drawing.Point(146, 173);
            gpaBox.Name = "gpaBox";
            gpaBox.Size = new System.Drawing.Size(318, 29);
            gpaBox.TabIndex = 42;
            // 
            // namebox
            // 
            namebox.Location = new System.Drawing.Point(146, 116);
            namebox.Name = "namebox";
            namebox.Size = new System.Drawing.Size(318, 29);
            namebox.TabIndex = 41;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            label2.Location = new System.Drawing.Point(19, 287);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(85, 25);
            label2.TabIndex = 57;
            label2.Text = "Address";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            label7.Location = new System.Drawing.Point(19, 234);
            label7.Name = "label7";
            label7.Size = new System.Drawing.Size(94, 25);
            label7.TabIndex = 56;
            label7.Text = "Birth date";
            // 
            // AddressBox
            // 
            AddressBox.Location = new System.Drawing.Point(146, 283);
            AddressBox.Name = "AddressBox";
            AddressBox.Size = new System.Drawing.Size(318, 29);
            AddressBox.TabIndex = 55;
            // 
            // birthBox
            // 
            birthBox.Location = new System.Drawing.Point(146, 230);
            birthBox.Name = "birthBox";
            birthBox.Size = new System.Drawing.Size(318, 29);
            birthBox.TabIndex = 54;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            label8.Location = new System.Drawing.Point(19, 391);
            label8.Name = "label8";
            label8.Size = new System.Drawing.Size(67, 25);
            label8.TabIndex = 61;
            label8.Text = "phone";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            label9.Location = new System.Drawing.Point(19, 337);
            label9.Name = "label9";
            label9.Size = new System.Drawing.Size(52, 25);
            label9.TabIndex = 60;
            label9.Text = "level";
            // 
            // PhoneBox
            // 
            PhoneBox.Location = new System.Drawing.Point(146, 387);
            PhoneBox.Name = "PhoneBox";
            PhoneBox.Size = new System.Drawing.Size(318, 29);
            PhoneBox.TabIndex = 59;
            // 
            // levelBox
            // 
            levelBox.Location = new System.Drawing.Point(146, 339);
            levelBox.Name = "levelBox";
            levelBox.Size = new System.Drawing.Size(318, 29);
            levelBox.TabIndex = 58;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            label10.Location = new System.Drawing.Point(19, 443);
            label10.Name = "label10";
            label10.Size = new System.Drawing.Size(45, 25);
            label10.TabIndex = 63;
            label10.Text = "NID";
            // 
            // NidBox
            // 
            NidBox.Location = new System.Drawing.Point(146, 439);
            NidBox.Name = "NidBox";
            NidBox.Size = new System.Drawing.Size(318, 29);
            NidBox.TabIndex = 62;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            label11.Location = new System.Drawing.Point(19, 487);
            label11.Name = "label11";
            label11.Size = new System.Drawing.Size(113, 25);
            label11.TabIndex = 65;
            label11.Text = "Department";
            // 
            // deptBox
            // 
            deptBox.Location = new System.Drawing.Point(146, 483);
            deptBox.Name = "deptBox";
            deptBox.Size = new System.Drawing.Size(318, 29);
            deptBox.TabIndex = 64;
            // 
            // button1
            // 
            button1.BackColor = System.Drawing.SystemColors.HotTrack;
            button1.FlatAppearance.BorderSize = 0;
            button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            button1.Location = new System.Drawing.Point(195, 602);
            button1.Name = "button1";
            button1.Size = new System.Drawing.Size(136, 46);
            button1.TabIndex = 80;
            button1.Text = "Home";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click_1;
            // 
            // ManageStudent
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(10F, 22F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(1323, 697);
            Controls.Add(button1);
            Controls.Add(label11);
            Controls.Add(deptBox);
            Controls.Add(label10);
            Controls.Add(NidBox);
            Controls.Add(label8);
            Controls.Add(label9);
            Controls.Add(PhoneBox);
            Controls.Add(levelBox);
            Controls.Add(label2);
            Controls.Add(label7);
            Controls.Add(AddressBox);
            Controls.Add(birthBox);
            Controls.Add(panel1);
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
            Controls.Add(gpaBox);
            Controls.Add(namebox);
            FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            Name = "ManageStudent";
            Text = "ManageStudent";
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
        private System.Windows.Forms.Panel panel2;
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
        private System.Windows.Forms.TextBox gpaBox;
        private System.Windows.Forms.TextBox namebox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox AddressBox;
        private System.Windows.Forms.TextBox birthBox;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox PhoneBox;
        private System.Windows.Forms.TextBox levelBox;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox NidBox;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox deptBox;
        private System.Windows.Forms.Button button1;
    }
}