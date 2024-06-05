namespace QLSV_L1
{
    partial class CourseForm
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
            this.btn_course_list = new System.Windows.Forms.Button();
            this.btn_Edit = new System.Windows.Forms.Button();
            this.btn_add_course = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.courseList2 = new QLSV_L1.courseList();
            this.editCourse1 = new QLSV_L1.EditCourse();
            this.addCourse1 = new QLSV_L1.AddCourse();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(105)))), ((int)(((byte)(168)))));
            this.panel1.Controls.Add(this.btn_course_list);
            this.panel1.Controls.Add(this.btn_Edit);
            this.panel1.Controls.Add(this.btn_add_course);
            this.panel1.Location = new System.Drawing.Point(2, 1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(363, 683);
            this.panel1.TabIndex = 0;
            // 
            // btn_course_list
            // 
            this.btn_course_list.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(105)))), ((int)(((byte)(168)))));
            this.btn_course_list.FlatAppearance.BorderColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_course_list.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_course_list.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_course_list.Location = new System.Drawing.Point(42, 217);
            this.btn_course_list.Name = "btn_course_list";
            this.btn_course_list.Size = new System.Drawing.Size(254, 61);
            this.btn_course_list.TabIndex = 2;
            this.btn_course_list.Text = "Course List";
            this.btn_course_list.UseVisualStyleBackColor = false;
            this.btn_course_list.Click += new System.EventHandler(this.btn_course_list_Click);
            // 
            // btn_Edit
            // 
            this.btn_Edit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(105)))), ((int)(((byte)(168)))));
            this.btn_Edit.FlatAppearance.BorderColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_Edit.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Edit.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_Edit.Location = new System.Drawing.Point(42, 399);
            this.btn_Edit.Name = "btn_Edit";
            this.btn_Edit.Size = new System.Drawing.Size(254, 61);
            this.btn_Edit.TabIndex = 1;
            this.btn_Edit.Text = "Edit";
            this.btn_Edit.UseVisualStyleBackColor = false;
            this.btn_Edit.Click += new System.EventHandler(this.btn_Edit_Click);
            // 
            // btn_add_course
            // 
            this.btn_add_course.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(105)))), ((int)(((byte)(168)))));
            this.btn_add_course.FlatAppearance.BorderColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_add_course.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_add_course.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_add_course.Location = new System.Drawing.Point(42, 306);
            this.btn_add_course.Name = "btn_add_course";
            this.btn_add_course.Size = new System.Drawing.Size(254, 61);
            this.btn_add_course.TabIndex = 0;
            this.btn_add_course.Text = "Add Course";
            this.btn_add_course.UseVisualStyleBackColor = false;
            this.btn_add_course.Click += new System.EventHandler(this.btn_add_course_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.courseList2);
            this.panel2.Controls.Add(this.editCourse1);
            this.panel2.Controls.Add(this.addCourse1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel2.Location = new System.Drawing.Point(364, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(638, 683);
            this.panel2.TabIndex = 1;
            // 
            // courseList2
            // 
            this.courseList2.BackColor = System.Drawing.Color.White;
            this.courseList2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.courseList2.Location = new System.Drawing.Point(0, 3);
            this.courseList2.Name = "courseList2";
            this.courseList2.Size = new System.Drawing.Size(641, 683);
            this.courseList2.TabIndex = 3;
            this.courseList2.Load += new System.EventHandler(this.courseList2_Load);
            // 
            // editCourse1
            // 
            this.editCourse1.Location = new System.Drawing.Point(0, 1);
            this.editCourse1.Name = "editCourse1";
            this.editCourse1.Size = new System.Drawing.Size(641, 682);
            this.editCourse1.TabIndex = 1;
            this.editCourse1.Load += new System.EventHandler(this.editCourse1_Load);
            // 
            // addCourse1
            // 
            this.addCourse1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.addCourse1.Location = new System.Drawing.Point(3, 3);
            this.addCourse1.Name = "addCourse1";
            this.addCourse1.Size = new System.Drawing.Size(638, 683);
            this.addCourse1.TabIndex = 0;
            // 
            // CourseForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1002, 683);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "CourseForm";
            this.Text = "CourseForm";
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btn_add_course;
        private System.Windows.Forms.Panel panel2;
        private AddCourse addCourse1;
        private System.Windows.Forms.Button btn_Edit;
        private EditCourse editCourse1;
        private System.Windows.Forms.Button btn_course_list;
        private courseList courseList2;
    }
}