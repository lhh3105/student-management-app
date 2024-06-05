namespace QLSV_L1
{
    partial class Student_List
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label8 = new System.Windows.Forms.Label();
            this.listbox_course = new System.Windows.Forms.ListBox();
            this.label7 = new System.Windows.Forms.Label();
            this.datetime_birthday = new System.Windows.Forms.DateTimePicker();
            this.btn_studentlist_save = new System.Windows.Forms.Button();
            this.btn_studentlist_edit = new System.Windows.Forms.Button();
            this.cbb_dt_gender = new System.Windows.Forms.ComboBox();
            this.btn_dt_add = new System.Windows.Forms.Button();
            this.btn_dt_import_image = new System.Windows.Forms.Button();
            this.pb_dt_image = new System.Windows.Forms.PictureBox();
            this.txt_dt_phone = new System.Windows.Forms.TextBox();
            this.txt_dt_age = new System.Windows.Forms.TextBox();
            this.txt_dt_name = new System.Windows.Forms.TextBox();
            this.txt_dt_id = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btn_search_left = new System.Windows.Forms.Button();
            this.btn_search_right = new System.Windows.Forms.Button();
            this.btn_dt_refresh = new System.Windows.Forms.Button();
            this.dtgrid_student = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pb_dt_image)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgrid_student)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.Controls.Add(this.label8);
            this.panel2.Controls.Add(this.listbox_course);
            this.panel2.Controls.Add(this.label7);
            this.panel2.Controls.Add(this.datetime_birthday);
            this.panel2.Controls.Add(this.btn_studentlist_save);
            this.panel2.Controls.Add(this.btn_studentlist_edit);
            this.panel2.Controls.Add(this.cbb_dt_gender);
            this.panel2.Controls.Add(this.btn_dt_add);
            this.panel2.Controls.Add(this.btn_dt_import_image);
            this.panel2.Controls.Add(this.pb_dt_image);
            this.panel2.Controls.Add(this.txt_dt_phone);
            this.panel2.Controls.Add(this.txt_dt_age);
            this.panel2.Controls.Add(this.txt_dt_name);
            this.panel2.Controls.Add(this.txt_dt_id);
            this.panel2.Controls.Add(this.label6);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Location = new System.Drawing.Point(14, 352);
            this.panel2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(952, 427);
            this.panel2.TabIndex = 3;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(23, 212);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(68, 20);
            this.label8.TabIndex = 19;
            this.label8.Text = "Course:";
            // 
            // listbox_course
            // 
            this.listbox_course.FormattingEnabled = true;
            this.listbox_course.ItemHeight = 16;
            this.listbox_course.Location = new System.Drawing.Point(135, 212);
            this.listbox_course.Name = "listbox_course";
            this.listbox_course.Size = new System.Drawing.Size(216, 132);
            this.listbox_course.TabIndex = 18;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(360, 91);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(43, 20);
            this.label7.TabIndex = 17;
            this.label7.Text = "Age:";
            // 
            // datetime_birthday
            // 
            this.datetime_birthday.CustomFormat = "dd/MM/yyyy";
            this.datetime_birthday.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.datetime_birthday.Location = new System.Drawing.Point(497, 25);
            this.datetime_birthday.Name = "datetime_birthday";
            this.datetime_birthday.Size = new System.Drawing.Size(152, 22);
            this.datetime_birthday.TabIndex = 16;
            // 
            // btn_studentlist_save
            // 
            this.btn_studentlist_save.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(105)))), ((int)(((byte)(168)))));
            this.btn_studentlist_save.FlatAppearance.BorderSize = 0;
            this.btn_studentlist_save.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_studentlist_save.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_studentlist_save.Location = new System.Drawing.Point(712, 357);
            this.btn_studentlist_save.Name = "btn_studentlist_save";
            this.btn_studentlist_save.Size = new System.Drawing.Size(133, 34);
            this.btn_studentlist_save.TabIndex = 15;
            this.btn_studentlist_save.Text = "Save";
            this.btn_studentlist_save.UseVisualStyleBackColor = false;
            this.btn_studentlist_save.Click += new System.EventHandler(this.btn_studentlist_save_Click);
            // 
            // btn_studentlist_edit
            // 
            this.btn_studentlist_edit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(105)))), ((int)(((byte)(168)))));
            this.btn_studentlist_edit.FlatAppearance.BorderSize = 0;
            this.btn_studentlist_edit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_studentlist_edit.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_studentlist_edit.Location = new System.Drawing.Point(497, 357);
            this.btn_studentlist_edit.Name = "btn_studentlist_edit";
            this.btn_studentlist_edit.Size = new System.Drawing.Size(133, 34);
            this.btn_studentlist_edit.TabIndex = 14;
            this.btn_studentlist_edit.Text = "Edit";
            this.btn_studentlist_edit.UseVisualStyleBackColor = false;
            this.btn_studentlist_edit.Click += new System.EventHandler(this.btn_studentlist_edit_Click);
            // 
            // cbb_dt_gender
            // 
            this.cbb_dt_gender.FormattingEnabled = true;
            this.cbb_dt_gender.Items.AddRange(new object[] {
            "Male",
            "Female",
            "Others"});
            this.cbb_dt_gender.Location = new System.Drawing.Point(137, 146);
            this.cbb_dt_gender.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cbb_dt_gender.Name = "cbb_dt_gender";
            this.cbb_dt_gender.Size = new System.Drawing.Size(193, 24);
            this.cbb_dt_gender.TabIndex = 13;
            // 
            // btn_dt_add
            // 
            this.btn_dt_add.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_dt_add.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_dt_add.ForeColor = System.Drawing.Color.White;
            this.btn_dt_add.Location = new System.Drawing.Point(721, 253);
            this.btn_dt_add.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_dt_add.Name = "btn_dt_add";
            this.btn_dt_add.Size = new System.Drawing.Size(131, 34);
            this.btn_dt_add.TabIndex = 12;
            this.btn_dt_add.Text = "Add";
            this.btn_dt_add.UseVisualStyleBackColor = false;
            this.btn_dt_add.Click += new System.EventHandler(this.btn_dt_add_Click);
            // 
            // btn_dt_import_image
            // 
            this.btn_dt_import_image.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(105)))), ((int)(((byte)(168)))));
            this.btn_dt_import_image.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_dt_import_image.ForeColor = System.Drawing.Color.White;
            this.btn_dt_import_image.Location = new System.Drawing.Point(725, 174);
            this.btn_dt_import_image.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_dt_import_image.Name = "btn_dt_import_image";
            this.btn_dt_import_image.Size = new System.Drawing.Size(120, 34);
            this.btn_dt_import_image.TabIndex = 11;
            this.btn_dt_import_image.Text = "Import";
            this.btn_dt_import_image.UseVisualStyleBackColor = false;
            this.btn_dt_import_image.Click += new System.EventHandler(this.btn_dt_import_image_Click);
            // 
            // pb_dt_image
            // 
            this.pb_dt_image.BackColor = System.Drawing.Color.WhiteSmoke;
            this.pb_dt_image.Location = new System.Drawing.Point(712, 19);
            this.pb_dt_image.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pb_dt_image.Name = "pb_dt_image";
            this.pb_dt_image.Size = new System.Drawing.Size(140, 139);
            this.pb_dt_image.TabIndex = 10;
            this.pb_dt_image.TabStop = false;
            // 
            // txt_dt_phone
            // 
            this.txt_dt_phone.Location = new System.Drawing.Point(497, 146);
            this.txt_dt_phone.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txt_dt_phone.Name = "txt_dt_phone";
            this.txt_dt_phone.Size = new System.Drawing.Size(152, 22);
            this.txt_dt_phone.TabIndex = 9;
            this.txt_dt_phone.Validating += new System.ComponentModel.CancelEventHandler(this.txt_dt_phone_Validating);
            // 
            // txt_dt_age
            // 
            this.txt_dt_age.Location = new System.Drawing.Point(497, 89);
            this.txt_dt_age.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txt_dt_age.Name = "txt_dt_age";
            this.txt_dt_age.ReadOnly = true;
            this.txt_dt_age.Size = new System.Drawing.Size(152, 22);
            this.txt_dt_age.TabIndex = 8;
            this.txt_dt_age.TextChanged += new System.EventHandler(this.txt_dt_age_TextChanged);
            this.txt_dt_age.Validating += new System.ComponentModel.CancelEventHandler(this.txt_dt_age_Validating);
            // 
            // txt_dt_name
            // 
            this.txt_dt_name.Location = new System.Drawing.Point(135, 89);
            this.txt_dt_name.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txt_dt_name.Name = "txt_dt_name";
            this.txt_dt_name.Size = new System.Drawing.Size(195, 22);
            this.txt_dt_name.TabIndex = 6;
            this.txt_dt_name.Validating += new System.ComponentModel.CancelEventHandler(this.txt_dt_name_Validating);
            // 
            // txt_dt_id
            // 
            this.txt_dt_id.Location = new System.Drawing.Point(137, 25);
            this.txt_dt_id.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txt_dt_id.Name = "txt_dt_id";
            this.txt_dt_id.Size = new System.Drawing.Size(195, 22);
            this.txt_dt_id.TabIndex = 5;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(360, 146);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(117, 20);
            this.label6.TabIndex = 4;
            this.label6.Text = "Phone number";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(360, 25);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(71, 20);
            this.label5.TabIndex = 3;
            this.label5.Text = "Birthday";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(23, 146);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(64, 20);
            this.label4.TabIndex = 2;
            this.label4.Text = "Gender";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(23, 91);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 20);
            this.label3.TabIndex = 1;
            this.label3.Text = "Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(23, 25);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(88, 20);
            this.label2.TabIndex = 0;
            this.label2.Text = "Student ID";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.btn_search_left);
            this.panel1.Controls.Add(this.btn_search_right);
            this.panel1.Controls.Add(this.btn_dt_refresh);
            this.panel1.Controls.Add(this.dtgrid_student);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(14, 18);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(952, 318);
            this.panel1.TabIndex = 2;
            // 
            // btn_search_left
            // 
            this.btn_search_left.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(105)))), ((int)(((byte)(168)))));
            this.btn_search_left.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_search_left.ForeColor = System.Drawing.Color.White;
            this.btn_search_left.Location = new System.Drawing.Point(412, 22);
            this.btn_search_left.Margin = new System.Windows.Forms.Padding(4);
            this.btn_search_left.Name = "btn_search_left";
            this.btn_search_left.Size = new System.Drawing.Size(127, 34);
            this.btn_search_left.TabIndex = 4;
            this.btn_search_left.Text = "<<";
            this.btn_search_left.UseVisualStyleBackColor = false;
            this.btn_search_left.Click += new System.EventHandler(this.btn_search_left_Click);
            // 
            // btn_search_right
            // 
            this.btn_search_right.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(105)))), ((int)(((byte)(168)))));
            this.btn_search_right.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_search_right.ForeColor = System.Drawing.Color.White;
            this.btn_search_right.Location = new System.Drawing.Point(592, 22);
            this.btn_search_right.Margin = new System.Windows.Forms.Padding(4);
            this.btn_search_right.Name = "btn_search_right";
            this.btn_search_right.Size = new System.Drawing.Size(127, 34);
            this.btn_search_right.TabIndex = 3;
            this.btn_search_right.Text = ">>";
            this.btn_search_right.UseVisualStyleBackColor = false;
            this.btn_search_right.Click += new System.EventHandler(this.btn_search_right_Click);
            // 
            // btn_dt_refresh
            // 
            this.btn_dt_refresh.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(105)))), ((int)(((byte)(168)))));
            this.btn_dt_refresh.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_dt_refresh.ForeColor = System.Drawing.Color.White;
            this.btn_dt_refresh.Location = new System.Drawing.Point(779, 22);
            this.btn_dt_refresh.Margin = new System.Windows.Forms.Padding(4);
            this.btn_dt_refresh.Name = "btn_dt_refresh";
            this.btn_dt_refresh.Size = new System.Drawing.Size(127, 34);
            this.btn_dt_refresh.TabIndex = 2;
            this.btn_dt_refresh.Text = "Refresh";
            this.btn_dt_refresh.UseVisualStyleBackColor = false;
            this.btn_dt_refresh.Click += new System.EventHandler(this.btn_dt_refresh_Click);
            // 
            // dtgrid_student
            // 
            this.dtgrid_student.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(105)))), ((int)(((byte)(168)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dtgrid_student.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dtgrid_student.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgrid_student.EnableHeadersVisualStyles = false;
            this.dtgrid_student.Location = new System.Drawing.Point(39, 78);
            this.dtgrid_student.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dtgrid_student.Name = "dtgrid_student";
            this.dtgrid_student.ReadOnly = true;
            this.dtgrid_student.RowHeadersVisible = false;
            this.dtgrid_student.RowHeadersWidth = 51;
            this.dtgrid_student.RowTemplate.Height = 24;
            this.dtgrid_student.Size = new System.Drawing.Size(867, 220);
            this.dtgrid_student.TabIndex = 1;
            this.dtgrid_student.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgrid_student_CellClick);
            this.dtgrid_student.DoubleClick += new System.EventHandler(this.dtgrid_student_DoubleClick);
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(23, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(173, 34);
            this.label1.TabIndex = 0;
            this.label1.Text = " Student Data";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // Student_List
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "Student_List";
            this.Size = new System.Drawing.Size(992, 773);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pb_dt_image)).EndInit();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dtgrid_student)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btn_studentlist_save;
        private System.Windows.Forms.Button btn_studentlist_edit;
        private System.Windows.Forms.ComboBox cbb_dt_gender;
        private System.Windows.Forms.Button btn_dt_add;
        private System.Windows.Forms.Button btn_dt_import_image;
        private System.Windows.Forms.PictureBox pb_dt_image;
        private System.Windows.Forms.TextBox txt_dt_phone;
        private System.Windows.Forms.TextBox txt_dt_age;
        private System.Windows.Forms.TextBox txt_dt_name;
        private System.Windows.Forms.TextBox txt_dt_id;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btn_search_left;
        private System.Windows.Forms.Button btn_search_right;
        private System.Windows.Forms.Button btn_dt_refresh;
        private System.Windows.Forms.DataGridView dtgrid_student;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.DateTimePicker datetime_birthday;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ListBox listbox_course;
    }
}
