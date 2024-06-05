namespace QLSV_L1
{
    partial class RegistercourseForm
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
            this.cbb_score_course = new System.Windows.Forms.ComboBox();
            this.txt_score_student_id = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lb1 = new System.Windows.Forms.Label();
            this.btn_add_score = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // cbb_score_course
            // 
            this.cbb_score_course.FormattingEnabled = true;
            this.cbb_score_course.Location = new System.Drawing.Point(263, 141);
            this.cbb_score_course.Name = "cbb_score_course";
            this.cbb_score_course.Size = new System.Drawing.Size(225, 24);
            this.cbb_score_course.TabIndex = 19;
            // 
            // txt_score_student_id
            // 
            this.txt_score_student_id.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_score_student_id.Location = new System.Drawing.Point(263, 68);
            this.txt_score_student_id.Name = "txt_score_student_id";
            this.txt_score_student_id.Size = new System.Drawing.Size(225, 27);
            this.txt_score_student_id.TabIndex = 18;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(107, 141);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(137, 25);
            this.label1.TabIndex = 17;
            this.label1.Text = "Select course:";
            // 
            // lb1
            // 
            this.lb1.AutoSize = true;
            this.lb1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb1.Location = new System.Drawing.Point(134, 70);
            this.lb1.Name = "lb1";
            this.lb1.Size = new System.Drawing.Size(110, 25);
            this.lb1.TabIndex = 16;
            this.lb1.Text = "Student ID:";
            // 
            // btn_add_score
            // 
            this.btn_add_score.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(105)))), ((int)(((byte)(168)))));
            this.btn_add_score.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_add_score.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_add_score.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_add_score.Location = new System.Drawing.Point(263, 228);
            this.btn_add_score.Name = "btn_add_score";
            this.btn_add_score.Size = new System.Drawing.Size(161, 41);
            this.btn_add_score.TabIndex = 20;
            this.btn_add_score.Text = "Add Score";
            this.btn_add_score.UseVisualStyleBackColor = false;
            // 
            // RegistercourseForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(697, 404);
            this.Controls.Add(this.btn_add_score);
            this.Controls.Add(this.cbb_score_course);
            this.Controls.Add(this.txt_score_student_id);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lb1);
            this.Name = "RegistercourseForm";
            this.Text = "RegistercourseForm";
            this.Load += new System.EventHandler(this.RegistercourseForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cbb_score_course;
        private System.Windows.Forms.TextBox txt_score_student_id;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lb1;
        private System.Windows.Forms.Button btn_add_score;
    }
}