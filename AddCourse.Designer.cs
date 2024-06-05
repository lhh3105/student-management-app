namespace QLSV_L1
{
    partial class AddCourse
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txt_courseID = new System.Windows.Forms.TextBox();
            this.txt_courseName = new System.Windows.Forms.TextBox();
            this.txt_coursePeriod = new System.Windows.Forms.TextBox();
            this.rich_txt_description = new System.Windows.Forms.RichTextBox();
            this.btn_addCourse = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(62, 108);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(136, 29);
            this.label1.TabIndex = 0;
            this.label1.Text = "Course ID:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(109, 176);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(89, 29);
            this.label2.TabIndex = 1;
            this.label2.Text = "Name:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(45, 349);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(153, 29);
            this.label3.TabIndex = 2;
            this.label3.Text = "Description:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(100, 255);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(98, 29);
            this.label4.TabIndex = 3;
            this.label4.Text = "Period:";
            // 
            // txt_courseID
            // 
            this.txt_courseID.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_courseID.Location = new System.Drawing.Point(249, 108);
            this.txt_courseID.Name = "txt_courseID";
            this.txt_courseID.Size = new System.Drawing.Size(277, 34);
            this.txt_courseID.TabIndex = 4;
            // 
            // txt_courseName
            // 
            this.txt_courseName.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_courseName.Location = new System.Drawing.Point(249, 176);
            this.txt_courseName.Name = "txt_courseName";
            this.txt_courseName.Size = new System.Drawing.Size(277, 34);
            this.txt_courseName.TabIndex = 5;
            // 
            // txt_coursePeriod
            // 
            this.txt_coursePeriod.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_coursePeriod.Location = new System.Drawing.Point(249, 255);
            this.txt_coursePeriod.Name = "txt_coursePeriod";
            this.txt_coursePeriod.Size = new System.Drawing.Size(277, 34);
            this.txt_coursePeriod.TabIndex = 6;
            // 
            // rich_txt_description
            // 
            this.rich_txt_description.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rich_txt_description.Location = new System.Drawing.Point(249, 349);
            this.rich_txt_description.Name = "rich_txt_description";
            this.rich_txt_description.Size = new System.Drawing.Size(277, 171);
            this.rich_txt_description.TabIndex = 7;
            this.rich_txt_description.Text = "";
            // 
            // btn_addCourse
            // 
            this.btn_addCourse.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(105)))), ((int)(((byte)(168)))));
            this.btn_addCourse.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_addCourse.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_addCourse.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_addCourse.Location = new System.Drawing.Point(153, 576);
            this.btn_addCourse.Name = "btn_addCourse";
            this.btn_addCourse.Size = new System.Drawing.Size(269, 51);
            this.btn_addCourse.TabIndex = 8;
            this.btn_addCourse.Text = "Add Course";
            this.btn_addCourse.UseVisualStyleBackColor = false;
            this.btn_addCourse.Click += new System.EventHandler(this.btn_addCourse_Click);
            // 
            // AddCourse
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Controls.Add(this.btn_addCourse);
            this.Controls.Add(this.rich_txt_description);
            this.Controls.Add(this.txt_coursePeriod);
            this.Controls.Add(this.txt_courseName);
            this.Controls.Add(this.txt_courseID);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "AddCourse";
            this.Size = new System.Drawing.Size(638, 683);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txt_courseID;
        private System.Windows.Forms.TextBox txt_courseName;
        private System.Windows.Forms.TextBox txt_coursePeriod;
        private System.Windows.Forms.RichTextBox rich_txt_description;
        private System.Windows.Forms.Button btn_addCourse;
    }
}
