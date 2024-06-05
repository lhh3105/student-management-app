namespace QLSV_L1
{
    partial class EditCourse
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txt_courseID = new System.Windows.Forms.TextBox();
            this.txt_courseName = new System.Windows.Forms.TextBox();
            this.txt_coursePeriod = new System.Windows.Forms.TextBox();
            this.rich_txt_courseDescription = new System.Windows.Forms.RichTextBox();
            this.btn_courseFind = new System.Windows.Forms.Button();
            this.btn_courseDelete = new System.Windows.Forms.Button();
            this.btn_courseEdit = new System.Windows.Forms.Button();
            this.btn_courseSave = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.panel1.Controls.Add(this.btn_courseDelete);
            this.panel1.Controls.Add(this.btn_courseFind);
            this.panel1.Controls.Add(this.txt_courseID);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(16, 23);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(597, 142);
            this.panel1.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.panel2.Controls.Add(this.btn_courseSave);
            this.panel2.Controls.Add(this.btn_courseEdit);
            this.panel2.Controls.Add(this.rich_txt_courseDescription);
            this.panel2.Controls.Add(this.txt_coursePeriod);
            this.panel2.Controls.Add(this.txt_courseName);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Location = new System.Drawing.Point(16, 185);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(597, 474);
            this.panel2.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(33, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(116, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Course ID:";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(74, 72);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(75, 25);
            this.label2.TabIndex = 1;
            this.label2.Text = "Name:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(68, 162);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(81, 25);
            this.label3.TabIndex = 2;
            this.label3.Text = "Period:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(29, 248);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(120, 25);
            this.label4.TabIndex = 3;
            this.label4.Text = "Desciption:";
            // 
            // txt_courseID
            // 
            this.txt_courseID.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_courseID.Location = new System.Drawing.Point(155, 35);
            this.txt_courseID.Name = "txt_courseID";
            this.txt_courseID.Size = new System.Drawing.Size(222, 30);
            this.txt_courseID.TabIndex = 1;
            // 
            // txt_courseName
            // 
            this.txt_courseName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_courseName.Location = new System.Drawing.Point(176, 67);
            this.txt_courseName.Name = "txt_courseName";
            this.txt_courseName.Size = new System.Drawing.Size(283, 30);
            this.txt_courseName.TabIndex = 4;
            // 
            // txt_coursePeriod
            // 
            this.txt_coursePeriod.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_coursePeriod.Location = new System.Drawing.Point(176, 159);
            this.txt_coursePeriod.Name = "txt_coursePeriod";
            this.txt_coursePeriod.Size = new System.Drawing.Size(283, 30);
            this.txt_coursePeriod.TabIndex = 5;
            // 
            // rich_txt_courseDescription
            // 
            this.rich_txt_courseDescription.Location = new System.Drawing.Point(176, 248);
            this.rich_txt_courseDescription.Name = "rich_txt_courseDescription";
            this.rich_txt_courseDescription.Size = new System.Drawing.Size(283, 127);
            this.rich_txt_courseDescription.TabIndex = 6;
            this.rich_txt_courseDescription.Text = "";
            // 
            // btn_courseFind
            // 
            this.btn_courseFind.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(105)))), ((int)(((byte)(168)))));
            this.btn_courseFind.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_courseFind.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_courseFind.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_courseFind.Location = new System.Drawing.Point(399, 33);
            this.btn_courseFind.Name = "btn_courseFind";
            this.btn_courseFind.Size = new System.Drawing.Size(116, 32);
            this.btn_courseFind.TabIndex = 2;
            this.btn_courseFind.Text = "Find";
            this.btn_courseFind.UseVisualStyleBackColor = false;
            this.btn_courseFind.Click += new System.EventHandler(this.btn_courseFind_Click);
            // 
            // btn_courseDelete
            // 
            this.btn_courseDelete.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(105)))), ((int)(((byte)(168)))));
            this.btn_courseDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_courseDelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_courseDelete.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_courseDelete.Location = new System.Drawing.Point(399, 88);
            this.btn_courseDelete.Name = "btn_courseDelete";
            this.btn_courseDelete.Size = new System.Drawing.Size(116, 32);
            this.btn_courseDelete.TabIndex = 3;
            this.btn_courseDelete.Text = "Delete";
            this.btn_courseDelete.UseVisualStyleBackColor = false;
            this.btn_courseDelete.Click += new System.EventHandler(this.btn_courseDelete_Click);
            // 
            // btn_courseEdit
            // 
            this.btn_courseEdit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(105)))), ((int)(((byte)(168)))));
            this.btn_courseEdit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_courseEdit.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_courseEdit.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_courseEdit.Location = new System.Drawing.Point(176, 408);
            this.btn_courseEdit.Name = "btn_courseEdit";
            this.btn_courseEdit.Size = new System.Drawing.Size(116, 40);
            this.btn_courseEdit.TabIndex = 7;
            this.btn_courseEdit.Text = "Edit";
            this.btn_courseEdit.UseVisualStyleBackColor = false;
            this.btn_courseEdit.Click += new System.EventHandler(this.btn_courseEdit_Click);
            // 
            // btn_courseSave
            // 
            this.btn_courseSave.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(105)))), ((int)(((byte)(168)))));
            this.btn_courseSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_courseSave.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_courseSave.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_courseSave.Location = new System.Drawing.Point(343, 408);
            this.btn_courseSave.Name = "btn_courseSave";
            this.btn_courseSave.Size = new System.Drawing.Size(116, 40);
            this.btn_courseSave.TabIndex = 8;
            this.btn_courseSave.Text = "Save";
            this.btn_courseSave.UseVisualStyleBackColor = false;
            this.btn_courseSave.Click += new System.EventHandler(this.btn_courseSave_Click);
            // 
            // EditCourse
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "EditCourse";
            this.Size = new System.Drawing.Size(638, 683);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txt_courseID;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txt_courseName;
        private System.Windows.Forms.Button btn_courseFind;
        private System.Windows.Forms.RichTextBox rich_txt_courseDescription;
        private System.Windows.Forms.TextBox txt_coursePeriod;
        private System.Windows.Forms.Button btn_courseDelete;
        private System.Windows.Forms.Button btn_courseSave;
        private System.Windows.Forms.Button btn_courseEdit;
    }
}
