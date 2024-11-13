namespace WinFormsApp1
{
    partial class ViewForm
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
            searchBox = new System.Windows.Forms.TextBox();
            label5 = new System.Windows.Forms.Label();
            dataGridView1 = new System.Windows.Forms.DataGridView();
            Refresh = new System.Windows.Forms.Button();
            deptbox = new System.Windows.Forms.ComboBox();
            label1 = new System.Windows.Forms.Label();
            label2 = new System.Windows.Forms.Label();
            comboBox1 = new System.Windows.Forms.ComboBox();
            AddBtn = new System.Windows.Forms.Button();
            EditBtn = new System.Windows.Forms.Button();
            DeleteBtn = new System.Windows.Forms.Button();
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
            panel1.Size = new System.Drawing.Size(1336, 100);
            panel1.TabIndex = 58;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new System.Drawing.Font("Segoe UI Semilight", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            label3.Location = new System.Drawing.Point(577, 38);
            label3.Name = "label3";
            label3.Size = new System.Drawing.Size(93, 31);
            label3.TabIndex = 1;
            label3.Text = "View list";
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
            // panel2
            // 
            panel2.BackColor = System.Drawing.SystemColors.HotTrack;
            panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            panel2.Location = new System.Drawing.Point(0, 628);
            panel2.Name = "panel2";
            panel2.Size = new System.Drawing.Size(1336, 29);
            panel2.TabIndex = 71;
            // 
            // searchBox
            // 
            searchBox.Location = new System.Drawing.Point(792, 165);
            searchBox.Name = "searchBox";
            searchBox.Size = new System.Drawing.Size(318, 29);
            searchBox.TabIndex = 69;
            searchBox.TextChanged += searchBox_TextChanged;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            label5.Location = new System.Drawing.Point(718, 171);
            label5.Name = "label5";
            label5.Size = new System.Drawing.Size(75, 25);
            label5.TabIndex = 68;
            label5.Text = "Search";
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new System.Drawing.Point(599, 200);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.RowTemplate.Height = 31;
            dataGridView1.Size = new System.Drawing.Size(725, 397);
            dataGridView1.TabIndex = 64;
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
            Refresh.TabIndex = 62;
            Refresh.Text = "Refresh";
            Refresh.UseVisualStyleBackColor = false;
            Refresh.Click += Refresh_Click;
            // 
            // deptbox
            // 
            deptbox.FormattingEnabled = true;
            deptbox.Location = new System.Drawing.Point(166, 168);
            deptbox.Name = "deptbox";
            deptbox.Size = new System.Drawing.Size(165, 30);
            deptbox.TabIndex = 72;
            deptbox.SelectedIndexChanged += deptbox_SelectedIndexChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new System.Drawing.Font("Segoe UI Semilight", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            label1.Location = new System.Drawing.Point(17, 167);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(143, 31);
            label1.TabIndex = 73;
            label1.Text = "Departments";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new System.Drawing.Font("Segoe UI Semilight", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            label2.Location = new System.Drawing.Point(17, 220);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(92, 31);
            label2.TabIndex = 75;
            label2.Text = "Courses";
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new System.Drawing.Point(166, 221);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new System.Drawing.Size(165, 30);
            comboBox1.TabIndex = 74;
            comboBox1.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
            // 
            // AddBtn
            // 
            AddBtn.BackColor = System.Drawing.Color.LightCoral;
            AddBtn.FlatAppearance.BorderSize = 0;
            AddBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            AddBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            AddBtn.Location = new System.Drawing.Point(25, 469);
            AddBtn.Name = "AddBtn";
            AddBtn.Size = new System.Drawing.Size(136, 59);
            AddBtn.TabIndex = 78;
            AddBtn.Text = "View all";
            AddBtn.UseVisualStyleBackColor = false;
            AddBtn.Click += AddBtn_Click;
            // 
            // EditBtn
            // 
            EditBtn.BackColor = System.Drawing.Color.LightGreen;
            EditBtn.FlatAppearance.BorderSize = 0;
            EditBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            EditBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            EditBtn.Location = new System.Drawing.Point(195, 469);
            EditBtn.Name = "EditBtn";
            EditBtn.Size = new System.Drawing.Size(136, 59);
            EditBtn.TabIndex = 77;
            EditBtn.Text = "View all in department";
            EditBtn.UseVisualStyleBackColor = false;
            EditBtn.Click += EditBtn_Click;
            // 
            // DeleteBtn
            // 
            DeleteBtn.BackColor = System.Drawing.Color.Red;
            DeleteBtn.FlatAppearance.BorderSize = 0;
            DeleteBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            DeleteBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            DeleteBtn.Location = new System.Drawing.Point(365, 469);
            DeleteBtn.Name = "DeleteBtn";
            DeleteBtn.Size = new System.Drawing.Size(136, 59);
            DeleteBtn.TabIndex = 76;
            DeleteBtn.Text = "View all in course";
            DeleteBtn.UseVisualStyleBackColor = false;
            DeleteBtn.Click += DeleteBtn_Click;
            // 
            // button1
            // 
            button1.BackColor = System.Drawing.SystemColors.HotTrack;
            button1.FlatAppearance.BorderSize = 0;
            button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            button1.Location = new System.Drawing.Point(195, 549);
            button1.Name = "button1";
            button1.Size = new System.Drawing.Size(136, 59);
            button1.TabIndex = 79;
            button1.Text = "Home";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // ViewForm
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(10F, 22F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(1336, 657);
            Controls.Add(button1);
            Controls.Add(AddBtn);
            Controls.Add(EditBtn);
            Controls.Add(DeleteBtn);
            Controls.Add(label2);
            Controls.Add(comboBox1);
            Controls.Add(label1);
            Controls.Add(deptbox);
            Controls.Add(panel1);
            Controls.Add(panel2);
            Controls.Add(searchBox);
            Controls.Add(label5);
            Controls.Add(dataGridView1);
            Controls.Add(Refresh);
            FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            Name = "ViewForm";
            Text = "ViewForm";
            Load += DeleteBtn_Click;
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
        private System.Windows.Forms.TextBox searchBox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button Refresh;
        private System.Windows.Forms.ComboBox deptbox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Button AddBtn;
        private System.Windows.Forms.Button EditBtn;
        private System.Windows.Forms.Button DeleteBtn;
        private System.Windows.Forms.Button button1;
    }
}