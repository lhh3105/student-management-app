namespace QLSV_L1
{
    partial class MainForm
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.dashboard1 = new QLSV_L1.Dashboard();
            this.label1 = new System.Windows.Forms.Label();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btn_score = new System.Windows.Forms.Button();
            this.btn_print = new System.Windows.Forms.Button();
            this.btn_course = new System.Windows.Forms.Button();
            this.btn_admin = new System.Windows.Forms.Button();
            this.btn_add = new System.Windows.Forms.Button();
            this.btn_search = new System.Windows.Forms.Button();
            this.btn_Studentlist = new System.Windows.Forms.Button();
            this.btn_dashboard = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.admin1 = new QLSV_L1.Admin();
            this.addStudent1 = new QLSV_L1.AddStudent();
            this.search_student1 = new QLSV_L1.Search_student();
            this.student_List1 = new QLSV_L1.Student_List();
            this.dashboard2 = new QLSV_L1.Dashboard();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(105)))), ((int)(((byte)(168)))));
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.flowLayoutPanel1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1274, 51);
            this.panel1.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.label2.Font = new System.Drawing.Font("Candara", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label2.Location = new System.Drawing.Point(1228, 6);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(34, 33);
            this.label2.TabIndex = 9;
            this.label2.Text = "X";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.dashboard1);
            this.panel3.Location = new System.Drawing.Point(291, 69);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(951, 682);
            this.panel3.TabIndex = 2;
            // 
            // dashboard1
            // 
            this.dashboard1.Location = new System.Drawing.Point(634, -27);
            this.dashboard1.Name = "dashboard1";
            this.dashboard1.Size = new System.Drawing.Size(860, 673);
            this.dashboard1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(24, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(296, 25);
            this.label1.TabIndex = 2;
            this.label1.Text = "Student Management System";
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Location = new System.Drawing.Point(0, 122);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(221, 583);
            this.flowLayoutPanel1.TabIndex = 1;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(105)))), ((int)(((byte)(168)))));
            this.panel2.Controls.Add(this.btn_score);
            this.panel2.Controls.Add(this.btn_print);
            this.panel2.Controls.Add(this.btn_course);
            this.panel2.Controls.Add(this.btn_admin);
            this.panel2.Controls.Add(this.btn_add);
            this.panel2.Controls.Add(this.btn_search);
            this.panel2.Controls.Add(this.btn_Studentlist);
            this.panel2.Controls.Add(this.btn_dashboard);
            this.panel2.Controls.Add(this.pictureBox1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel2.Location = new System.Drawing.Point(0, 51);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(285, 770);
            this.panel2.TabIndex = 1;
            this.panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint);
            // 
            // btn_score
            // 
            this.btn_score.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_score.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_score.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_score.Location = new System.Drawing.Point(29, 698);
            this.btn_score.Name = "btn_score";
            this.btn_score.Size = new System.Drawing.Size(222, 50);
            this.btn_score.TabIndex = 9;
            this.btn_score.Text = "Score";
            this.btn_score.UseVisualStyleBackColor = true;
            this.btn_score.Click += new System.EventHandler(this.btn_score_Click);
            // 
            // btn_print
            // 
            this.btn_print.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_print.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_print.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_print.Location = new System.Drawing.Point(29, 561);
            this.btn_print.Name = "btn_print";
            this.btn_print.Size = new System.Drawing.Size(222, 50);
            this.btn_print.TabIndex = 8;
            this.btn_print.Text = "Print";
            this.btn_print.UseVisualStyleBackColor = true;
            this.btn_print.Click += new System.EventHandler(this.btn_print_Click);
            // 
            // btn_course
            // 
            this.btn_course.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_course.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_course.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_course.Location = new System.Drawing.Point(29, 630);
            this.btn_course.Name = "btn_course";
            this.btn_course.Size = new System.Drawing.Size(222, 50);
            this.btn_course.TabIndex = 7;
            this.btn_course.Text = "Course";
            this.btn_course.UseVisualStyleBackColor = true;
            this.btn_course.Click += new System.EventHandler(this.btn_course_Click);
            // 
            // btn_admin
            // 
            this.btn_admin.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(105)))), ((int)(((byte)(168)))));
            this.btn_admin.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btn_admin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_admin.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_admin.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_admin.Location = new System.Drawing.Point(29, 247);
            this.btn_admin.Name = "btn_admin";
            this.btn_admin.Size = new System.Drawing.Size(222, 55);
            this.btn_admin.TabIndex = 6;
            this.btn_admin.Text = "Admin";
            this.btn_admin.UseVisualStyleBackColor = false;
            this.btn_admin.Click += new System.EventHandler(this.btn_admin_Click);
            // 
            // btn_add
            // 
            this.btn_add.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_add.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_add.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_add.Location = new System.Drawing.Point(29, 411);
            this.btn_add.Name = "btn_add";
            this.btn_add.Size = new System.Drawing.Size(222, 50);
            this.btn_add.TabIndex = 5;
            this.btn_add.Text = "Add Student";
            this.btn_add.UseVisualStyleBackColor = true;
            this.btn_add.Click += new System.EventHandler(this.btn_add_Click);
            // 
            // btn_search
            // 
            this.btn_search.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_search.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_search.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_search.Location = new System.Drawing.Point(29, 486);
            this.btn_search.Name = "btn_search";
            this.btn_search.Size = new System.Drawing.Size(222, 50);
            this.btn_search.TabIndex = 4;
            this.btn_search.Text = "Search";
            this.btn_search.UseVisualStyleBackColor = true;
            this.btn_search.Click += new System.EventHandler(this.btn_search_Click);
            // 
            // btn_Studentlist
            // 
            this.btn_Studentlist.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Studentlist.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Studentlist.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_Studentlist.Location = new System.Drawing.Point(29, 329);
            this.btn_Studentlist.Name = "btn_Studentlist";
            this.btn_Studentlist.Size = new System.Drawing.Size(222, 50);
            this.btn_Studentlist.TabIndex = 3;
            this.btn_Studentlist.Text = "Student List";
            this.btn_Studentlist.UseVisualStyleBackColor = true;
            this.btn_Studentlist.Click += new System.EventHandler(this.btn_Studentlist_Click);
            // 
            // btn_dashboard
            // 
            this.btn_dashboard.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_dashboard.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_dashboard.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_dashboard.Location = new System.Drawing.Point(29, 175);
            this.btn_dashboard.Name = "btn_dashboard";
            this.btn_dashboard.Size = new System.Drawing.Size(222, 50);
            this.btn_dashboard.TabIndex = 2;
            this.btn_dashboard.Text = "DashBoard";
            this.btn_dashboard.UseVisualStyleBackColor = true;
            this.btn_dashboard.Click += new System.EventHandler(this.btn_dashboard_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::QLSV_L1.Properties.Resources.job_symbol_on_student_flat_vector_15947972;
            this.pictureBox1.Location = new System.Drawing.Point(72, 18);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(134, 120);
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // admin1
            // 
            this.admin1.Location = new System.Drawing.Point(282, 45);
            this.admin1.Name = "admin1";
            this.admin1.Size = new System.Drawing.Size(992, 799);
            this.admin1.TabIndex = 8;
            this.admin1.Load += new System.EventHandler(this.admin1_Load);
            // 
            // addStudent1
            // 
            this.addStudent1.Location = new System.Drawing.Point(282, 45);
            this.addStudent1.Name = "addStudent1";
            this.addStudent1.Size = new System.Drawing.Size(992, 882);
            this.addStudent1.TabIndex = 7;
            this.addStudent1.Load += new System.EventHandler(this.addStudent1_Load);
            // 
            // search_student1
            // 
            this.search_student1.Location = new System.Drawing.Point(279, 45);
            this.search_student1.Name = "search_student1";
            this.search_student1.Size = new System.Drawing.Size(992, 785);
            this.search_student1.TabIndex = 6;
            // 
            // student_List1
            // 
            this.student_List1.Location = new System.Drawing.Point(282, 45);
            this.student_List1.Name = "student_List1";
            this.student_List1.Size = new System.Drawing.Size(992, 776);
            this.student_List1.TabIndex = 5;
            // 
            // dashboard2
            // 
            this.dashboard2.Location = new System.Drawing.Point(282, 45);
            this.dashboard2.Name = "dashboard2";
            this.dashboard2.Size = new System.Drawing.Size(989, 773);
            this.dashboard2.TabIndex = 4;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1274, 821);
            this.Controls.Add(this.admin1);
            this.Controls.Add(this.addStudent1);
            this.Controls.Add(this.search_student1);
            this.Controls.Add(this.student_List1);
            this.Controls.Add(this.dashboard2);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "MainForm";
            this.Text = "MainForm";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btn_dashboard;
        private System.Windows.Forms.Button btn_search;
        private System.Windows.Forms.Button btn_Studentlist;
        private System.Windows.Forms.Panel panel3;
        private Dashboard dashboard1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private Dashboard dashboard2;
        private Student_List student_List1;
        private Search_student search_student1;
        private System.Windows.Forms.Button btn_add;
        private AddStudent addStudent1;
        private System.Windows.Forms.Button btn_admin;
        private Admin admin1;
        private System.Windows.Forms.Button btn_course;
        private System.Windows.Forms.Button btn_print;
        private System.Windows.Forms.Button btn_score;
    }
}