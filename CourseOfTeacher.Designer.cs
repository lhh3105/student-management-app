namespace QLSV_L1
{
    partial class CourseOfTeacher
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
            this.label1 = new System.Windows.Forms.Label();
            this.txt_teachername = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.listbox_course = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(52, 49);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(154, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Teacher Name";
            // 
            // txt_teachername
            // 
            this.txt_teachername.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_teachername.Location = new System.Drawing.Point(246, 46);
            this.txt_teachername.Name = "txt_teachername";
            this.txt_teachername.Size = new System.Drawing.Size(293, 30);
            this.txt_teachername.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(124, 166);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(82, 25);
            this.label2.TabIndex = 2;
            this.label2.Text = "Course";
            // 
            // listbox_course
            // 
            this.listbox_course.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listbox_course.FormattingEnabled = true;
            this.listbox_course.ItemHeight = 25;
            this.listbox_course.Location = new System.Drawing.Point(246, 166);
            this.listbox_course.Name = "listbox_course";
            this.listbox_course.Size = new System.Drawing.Size(214, 129);
            this.listbox_course.TabIndex = 3;
            this.listbox_course.DoubleClick += new System.EventHandler(this.listbox_course_DoubleClick);
            // 
            // CourseOfTeacher
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(852, 522);
            this.Controls.Add(this.listbox_course);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txt_teachername);
            this.Controls.Add(this.label1);
            this.Name = "CourseOfTeacher";
            this.Text = "Course Of Teacher";
            this.Load += new System.EventHandler(this.CourseOfTeacher_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_teachername;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ListBox listbox_course;
    }
}