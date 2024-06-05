namespace QLSV_L1
{
    partial class editScorecs
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
            this.richtxt_score_description = new System.Windows.Forms.RichTextBox();
            this.cbb_score_course = new System.Windows.Forms.ComboBox();
            this.txt_score_score = new System.Windows.Forms.TextBox();
            this.txt_score_student_id = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lb1 = new System.Windows.Forms.Label();
            this.btn_edit_score = new System.Windows.Forms.Button();
            this.pn_edit_score = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // richtxt_score_description
            // 
            this.richtxt_score_description.Location = new System.Drawing.Point(467, 321);
            this.richtxt_score_description.Name = "richtxt_score_description";
            this.richtxt_score_description.Size = new System.Drawing.Size(225, 122);
            this.richtxt_score_description.TabIndex = 16;
            this.richtxt_score_description.Text = "";
            // 
            // cbb_score_course
            // 
            this.cbb_score_course.FormattingEnabled = true;
            this.cbb_score_course.Location = new System.Drawing.Point(467, 162);
            this.cbb_score_course.Name = "cbb_score_course";
            this.cbb_score_course.Size = new System.Drawing.Size(225, 24);
            this.cbb_score_course.TabIndex = 15;
            // 
            // txt_score_score
            // 
            this.txt_score_score.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_score_score.Location = new System.Drawing.Point(467, 252);
            this.txt_score_score.Name = "txt_score_score";
            this.txt_score_score.Size = new System.Drawing.Size(225, 27);
            this.txt_score_score.TabIndex = 14;
            // 
            // txt_score_student_id
            // 
            this.txt_score_student_id.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_score_student_id.Location = new System.Drawing.Point(467, 65);
            this.txt_score_student_id.Name = "txt_score_student_id";
            this.txt_score_student_id.Size = new System.Drawing.Size(225, 27);
            this.txt_score_student_id.TabIndex = 13;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(333, 317);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(115, 25);
            this.label3.TabIndex = 12;
            this.label3.Text = "Description:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(378, 251);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(70, 25);
            this.label2.TabIndex = 11;
            this.label2.Text = "Score:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(311, 158);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(137, 25);
            this.label1.TabIndex = 10;
            this.label1.Text = "Select course:";
            // 
            // lb1
            // 
            this.lb1.AutoSize = true;
            this.lb1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb1.Location = new System.Drawing.Point(338, 64);
            this.lb1.Name = "lb1";
            this.lb1.Size = new System.Drawing.Size(110, 25);
            this.lb1.TabIndex = 9;
            this.lb1.Text = "Student ID:";
            // 
            // btn_edit_score
            // 
            this.btn_edit_score.Location = new System.Drawing.Point(467, 488);
            this.btn_edit_score.Name = "btn_edit_score";
            this.btn_edit_score.Size = new System.Drawing.Size(148, 43);
            this.btn_edit_score.TabIndex = 18;
            this.btn_edit_score.Text = "Edit";
            this.btn_edit_score.UseVisualStyleBackColor = true;
            // 
            // pn_edit_score
            // 
            this.pn_edit_score.Location = new System.Drawing.Point(0, 0);
            this.pn_edit_score.Name = "pn_edit_score";
            this.pn_edit_score.Size = new System.Drawing.Size(275, 654);
            this.pn_edit_score.TabIndex = 19;
            // 
            // editScorecs
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(890, 566);
            this.Controls.Add(this.pn_edit_score);
            this.Controls.Add(this.btn_edit_score);
            this.Controls.Add(this.richtxt_score_description);
            this.Controls.Add(this.cbb_score_course);
            this.Controls.Add(this.txt_score_score);
            this.Controls.Add(this.txt_score_student_id);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lb1);
            this.Name = "editScorecs";
            this.Text = "editScorecs";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox richtxt_score_description;
        private System.Windows.Forms.ComboBox cbb_score_course;
        private System.Windows.Forms.TextBox txt_score_score;
        private System.Windows.Forms.TextBox txt_score_student_id;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lb1;
        private System.Windows.Forms.Button btn_edit_score;
        private System.Windows.Forms.Panel pn_edit_score;
    }
}