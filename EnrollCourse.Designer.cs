namespace WinFormsApp1
{
    partial class EnrollCourse
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
            Enroll = new System.Windows.Forms.Button();
            Unroll = new System.Windows.Forms.Button();
            label2 = new System.Windows.Forms.Label();
            comboBox1 = new System.Windows.Forms.ComboBox();
            label1 = new System.Windows.Forms.Label();
            deptbox = new System.Windows.Forms.ComboBox();
            panel2 = new System.Windows.Forms.Panel();
            searchBox = new System.Windows.Forms.TextBox();
            label5 = new System.Windows.Forms.Label();
            Refresh = new System.Windows.Forms.Button();
            label4 = new System.Windows.Forms.Label();
            levelBox = new System.Windows.Forms.TextBox();
            listBox1 = new System.Windows.Forms.ListBox();
            show = new System.Windows.Forms.Button();
            button1 = new System.Windows.Forms.Button();
            label6 = new System.Windows.Forms.Label();
            panel1.SuspendLayout();
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
            panel1.Size = new System.Drawing.Size(1336, 100);
            panel1.TabIndex = 79;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new System.Drawing.Font("Segoe UI Semilight", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            label3.Location = new System.Drawing.Point(577, 38);
            label3.Name = "label3";
            label3.Size = new System.Drawing.Size(150, 31);
            label3.TabIndex = 1;
            label3.Text = "Enroll courses";
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
            button2.Location = new System.Drawing.Point(1262, 0);
            button2.Name = "button2";
            button2.Size = new System.Drawing.Size(74, 100);
            button2.TabIndex = 0;
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // Enroll
            // 
            Enroll.BackColor = System.Drawing.Color.Red;
            Enroll.FlatAppearance.BorderSize = 0;
            Enroll.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            Enroll.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            Enroll.Location = new System.Drawing.Point(40, 501);
            Enroll.Name = "Enroll";
            Enroll.Size = new System.Drawing.Size(136, 46);
            Enroll.TabIndex = 91;
            Enroll.Text = "Enroll";
            Enroll.UseVisualStyleBackColor = false;
            Enroll.Click += enroll_Click;
            // 
            // Unroll
            // 
            Unroll.BackColor = System.Drawing.Color.Green;
            Unroll.FlatAppearance.BorderSize = 0;
            Unroll.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            Unroll.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            Unroll.Location = new System.Drawing.Point(235, 501);
            Unroll.Name = "Unroll";
            Unroll.Size = new System.Drawing.Size(136, 46);
            Unroll.TabIndex = 90;
            Unroll.Text = "Unroll";
            Unroll.UseVisualStyleBackColor = false;
            Unroll.Click += unroll_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new System.Drawing.Font("Segoe UI Semilight", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            label2.Location = new System.Drawing.Point(17, 220);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(92, 31);
            label2.TabIndex = 88;
            label2.Text = "Courses";
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new System.Drawing.Point(166, 221);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new System.Drawing.Size(165, 30);
            comboBox1.TabIndex = 87;
            comboBox1.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new System.Drawing.Font("Segoe UI Semilight", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            label1.Location = new System.Drawing.Point(17, 167);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(143, 31);
            label1.TabIndex = 86;
            label1.Text = "Departments";
            // 
            // deptbox
            // 
            deptbox.FormattingEnabled = true;
            deptbox.Location = new System.Drawing.Point(166, 168);
            deptbox.Name = "deptbox";
            deptbox.Size = new System.Drawing.Size(165, 30);
            deptbox.TabIndex = 85;
            deptbox.SelectedIndexChanged += deptbox_SelectedIndexChanged;
            // 
            // panel2
            // 
            panel2.BackColor = System.Drawing.SystemColors.HotTrack;
            panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            panel2.Location = new System.Drawing.Point(0, 628);
            panel2.Name = "panel2";
            panel2.Size = new System.Drawing.Size(1336, 29);
            panel2.TabIndex = 84;
            // 
            // searchBox
            // 
            searchBox.Location = new System.Drawing.Point(792, 165);
            searchBox.Name = "searchBox";
            searchBox.Size = new System.Drawing.Size(318, 29);
            searchBox.TabIndex = 83;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            label5.Location = new System.Drawing.Point(718, 171);
            label5.Name = "label5";
            label5.Size = new System.Drawing.Size(75, 25);
            label5.TabIndex = 82;
            label5.Text = "Search";
            // 
            // Refresh
            // 
            Refresh.BackColor = System.Drawing.SystemColors.HotTrack;
            Refresh.FlatAppearance.BorderSize = 0;
            Refresh.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            Refresh.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            Refresh.Location = new System.Drawing.Point(1212, 162);
            Refresh.Name = "Refresh";
            Refresh.Size = new System.Drawing.Size(94, 32);
            Refresh.TabIndex = 80;
            Refresh.Text = "Refresh";
            Refresh.UseVisualStyleBackColor = false;
            Refresh.Click += Refresh_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new System.Drawing.Font("Segoe UI Semilight", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            label4.Location = new System.Drawing.Point(17, 274);
            label4.Name = "label4";
            label4.Size = new System.Drawing.Size(65, 31);
            label4.TabIndex = 94;
            label4.Text = "Level";
            // 
            // levelBox
            // 
            levelBox.Location = new System.Drawing.Point(166, 274);
            levelBox.Name = "levelBox";
            levelBox.Size = new System.Drawing.Size(165, 29);
            levelBox.TabIndex = 95;
            levelBox.TextChanged += levelBox_TextChanged;
            // 
            // listBox1
            // 
            listBox1.FormattingEnabled = true;
            listBox1.ItemHeight = 22;
            listBox1.Location = new System.Drawing.Point(736, 199);
            listBox1.Name = "listBox1";
            listBox1.SelectionMode = System.Windows.Forms.SelectionMode.MultiExtended;
            listBox1.Size = new System.Drawing.Size(570, 400);
            listBox1.TabIndex = 96;
            // 
            // show
            // 
            show.BackColor = System.Drawing.Color.PowderBlue;
            show.FlatAppearance.BorderSize = 0;
            show.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            show.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            show.Location = new System.Drawing.Point(166, 355);
            show.Name = "show";
            show.Size = new System.Drawing.Size(136, 46);
            show.TabIndex = 98;
            show.Text = "Show";
            show.UseVisualStyleBackColor = false;
            show.Click += show_Click;
            // 
            // button1
            // 
            button1.BackColor = System.Drawing.SystemColors.HotTrack;
            button1.FlatAppearance.BorderSize = 0;
            button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            button1.Location = new System.Drawing.Point(137, 564);
            button1.Name = "button1";
            button1.Size = new System.Drawing.Size(136, 46);
            button1.TabIndex = 99;
            button1.Text = "Home";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new System.Drawing.Font("Segoe UI Semilight", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            label6.Location = new System.Drawing.Point(539, 171);
            label6.Name = "label6";
            label6.Size = new System.Drawing.Size(150, 31);
            label6.TabIndex = 100;
            label6.Text = "Enroll courses";
            // 
            // EnrollCourse
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(10F, 22F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(1336, 657);
            Controls.Add(label6);
            Controls.Add(button1);
            Controls.Add(show);
            Controls.Add(listBox1);
            Controls.Add(levelBox);
            Controls.Add(label4);
            Controls.Add(panel1);
            Controls.Add(Enroll);
            Controls.Add(Unroll);
            Controls.Add(label2);
            Controls.Add(comboBox1);
            Controls.Add(label1);
            Controls.Add(deptbox);
            Controls.Add(panel2);
            Controls.Add(searchBox);
            Controls.Add(label5);
            Controls.Add(Refresh);
            FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            Name = "EnrollCourse";
            Text = "EnrollCourse";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button Enroll;
        private System.Windows.Forms.Button Unroll;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox deptbox;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox searchBox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button Refresh;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox levelBox;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Button show;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label6;
    }
}