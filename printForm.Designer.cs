namespace QLSV_L1
{
    partial class printForm
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
            this.dtgrid_print_student = new System.Windows.Forms.DataGridView();
            this.button1 = new System.Windows.Forms.Button();
            this.btn_print_save = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.cbb_print_sex = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.radiobtn_yes = new System.Windows.Forms.RadioButton();
            this.radiobtn_no = new System.Windows.Forms.RadioButton();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.dateTimePicker2 = new System.Windows.Forms.DateTimePicker();
            this.btn_print_filter = new System.Windows.Forms.Button();
            this.btn_import = new System.Windows.Forms.Button();
            this.btn_delete = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dtgrid_print_student)).BeginInit();
            this.SuspendLayout();
            // 
            // dtgrid_print_student
            // 
            this.dtgrid_print_student.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dtgrid_print_student.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgrid_print_student.Location = new System.Drawing.Point(49, 123);
            this.dtgrid_print_student.Name = "dtgrid_print_student";
            this.dtgrid_print_student.RowHeadersVisible = false;
            this.dtgrid_print_student.RowHeadersWidth = 51;
            this.dtgrid_print_student.RowTemplate.Height = 24;
            this.dtgrid_print_student.Size = new System.Drawing.Size(885, 381);
            this.dtgrid_print_student.TabIndex = 0;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(689, 842);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(146, 53);
            this.button1.TabIndex = 1;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // btn_print_save
            // 
            this.btn_print_save.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(105)))), ((int)(((byte)(168)))));
            this.btn_print_save.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_print_save.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_print_save.Location = new System.Drawing.Point(48, 552);
            this.btn_print_save.Name = "btn_print_save";
            this.btn_print_save.Size = new System.Drawing.Size(199, 46);
            this.btn_print_save.TabIndex = 2;
            this.btn_print_save.Text = "Save to Text File";
            this.btn_print_save.UseVisualStyleBackColor = false;
            this.btn_print_save.Click += new System.EventHandler(this.btn_print_save_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(44, 48);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 25);
            this.label1.TabIndex = 3;
            this.label1.Text = "Sex:";
            // 
            // cbb_print_sex
            // 
            this.cbb_print_sex.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbb_print_sex.FormattingEnabled = true;
            this.cbb_print_sex.Items.AddRange(new object[] {
            "Male",
            "Female",
            "Both"});
            this.cbb_print_sex.Location = new System.Drawing.Point(113, 48);
            this.cbb_print_sex.Name = "cbb_print_sex";
            this.cbb_print_sex.Size = new System.Drawing.Size(151, 28);
            this.cbb_print_sex.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(365, 26);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(130, 25);
            this.label2.TabIndex = 5;
            this.label2.Text = "Filter Birthday";
            // 
            // radiobtn_yes
            // 
            this.radiobtn_yes.AutoSize = true;
            this.radiobtn_yes.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radiobtn_yes.Location = new System.Drawing.Point(535, 28);
            this.radiobtn_yes.Name = "radiobtn_yes";
            this.radiobtn_yes.Size = new System.Drawing.Size(58, 24);
            this.radiobtn_yes.TabIndex = 6;
            this.radiobtn_yes.TabStop = true;
            this.radiobtn_yes.Text = "Yes";
            this.radiobtn_yes.UseVisualStyleBackColor = true;
            // 
            // radiobtn_no
            // 
            this.radiobtn_no.AutoSize = true;
            this.radiobtn_no.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radiobtn_no.Location = new System.Drawing.Point(637, 28);
            this.radiobtn_no.Name = "radiobtn_no";
            this.radiobtn_no.Size = new System.Drawing.Size(51, 24);
            this.radiobtn_no.TabIndex = 7;
            this.radiobtn_no.TabStop = true;
            this.radiobtn_no.Text = "No";
            this.radiobtn_no.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(365, 64);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(57, 25);
            this.label3.TabIndex = 8;
            this.label3.Text = "From";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(565, 65);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(28, 25);
            this.label4.TabIndex = 9;
            this.label4.Text = "to";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.CustomFormat = "dd/MM/yyyy";
            this.dateTimePicker1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePicker1.Location = new System.Drawing.Point(428, 64);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(131, 27);
            this.dateTimePicker1.TabIndex = 10;
            // 
            // dateTimePicker2
            // 
            this.dateTimePicker2.CustomFormat = "dd/MM/yyyy";
            this.dateTimePicker2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePicker2.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePicker2.Location = new System.Drawing.Point(599, 65);
            this.dateTimePicker2.Name = "dateTimePicker2";
            this.dateTimePicker2.Size = new System.Drawing.Size(134, 27);
            this.dateTimePicker2.TabIndex = 11;
            // 
            // btn_print_filter
            // 
            this.btn_print_filter.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(105)))), ((int)(((byte)(168)))));
            this.btn_print_filter.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_print_filter.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_print_filter.Location = new System.Drawing.Point(808, 42);
            this.btn_print_filter.Name = "btn_print_filter";
            this.btn_print_filter.Size = new System.Drawing.Size(126, 40);
            this.btn_print_filter.TabIndex = 12;
            this.btn_print_filter.Text = "Filter";
            this.btn_print_filter.UseVisualStyleBackColor = false;
            this.btn_print_filter.Click += new System.EventHandler(this.btn_print_filter_Click);
            // 
            // btn_import
            // 
            this.btn_import.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(105)))), ((int)(((byte)(168)))));
            this.btn_import.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_import.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_import.Location = new System.Drawing.Point(394, 552);
            this.btn_import.Name = "btn_import";
            this.btn_import.Size = new System.Drawing.Size(199, 46);
            this.btn_import.TabIndex = 13;
            this.btn_import.Text = "Import";
            this.btn_import.UseVisualStyleBackColor = false;
            this.btn_import.Click += new System.EventHandler(this.btn_import_Click);
            // 
            // btn_delete
            // 
            this.btn_delete.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(105)))), ((int)(((byte)(168)))));
            this.btn_delete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_delete.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_delete.Location = new System.Drawing.Point(735, 552);
            this.btn_delete.Name = "btn_delete";
            this.btn_delete.Size = new System.Drawing.Size(199, 46);
            this.btn_delete.TabIndex = 14;
            this.btn_delete.Text = "Delete Import";
            this.btn_delete.UseVisualStyleBackColor = false;
            this.btn_delete.Click += new System.EventHandler(this.btn_delete_Click);
            // 
            // printForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(961, 648);
            this.Controls.Add(this.btn_delete);
            this.Controls.Add(this.btn_import);
            this.Controls.Add(this.btn_print_filter);
            this.Controls.Add(this.dateTimePicker2);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.radiobtn_no);
            this.Controls.Add(this.radiobtn_yes);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cbb_print_sex);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_print_save);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dtgrid_print_student);
            this.Name = "printForm";
            this.Text = "Print Student";
            ((System.ComponentModel.ISupportInitialize)(this.dtgrid_print_student)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dtgrid_print_student;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btn_print_save;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbb_print_sex;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.RadioButton radiobtn_yes;
        private System.Windows.Forms.RadioButton radiobtn_no;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.DateTimePicker dateTimePicker2;
        private System.Windows.Forms.Button btn_print_filter;
        private System.Windows.Forms.Button btn_import;
        private System.Windows.Forms.Button btn_delete;
    }
}