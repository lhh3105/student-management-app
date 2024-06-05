namespace QLSV_L1
{
    partial class AddStudent
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
            this.pb_addstudent = new System.Windows.Forms.Panel();
            this.btn_add_import = new System.Windows.Forms.Button();
            this.pb_add_image = new System.Windows.Forms.PictureBox();
            this.btn_add_add = new System.Windows.Forms.Button();
            this.txt_add_phone = new System.Windows.Forms.TextBox();
            this.dateTime_add_birth = new System.Windows.Forms.DateTimePicker();
            this.cbb_add_gender = new System.Windows.Forms.ComboBox();
            this.txt_add_name = new System.Windows.Forms.TextBox();
            this.txt_add_id = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.pb_addstudent.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pb_add_image)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // pb_addstudent
            // 
            this.pb_addstudent.BackColor = System.Drawing.Color.White;
            this.pb_addstudent.Controls.Add(this.btn_add_import);
            this.pb_addstudent.Controls.Add(this.pb_add_image);
            this.pb_addstudent.Controls.Add(this.btn_add_add);
            this.pb_addstudent.Controls.Add(this.txt_add_phone);
            this.pb_addstudent.Controls.Add(this.dateTime_add_birth);
            this.pb_addstudent.Controls.Add(this.cbb_add_gender);
            this.pb_addstudent.Controls.Add(this.txt_add_name);
            this.pb_addstudent.Controls.Add(this.txt_add_id);
            this.pb_addstudent.Controls.Add(this.label6);
            this.pb_addstudent.Controls.Add(this.label5);
            this.pb_addstudent.Controls.Add(this.label4);
            this.pb_addstudent.Controls.Add(this.label3);
            this.pb_addstudent.Controls.Add(this.label2);
            this.pb_addstudent.Location = new System.Drawing.Point(22, 16);
            this.pb_addstudent.Name = "pb_addstudent";
            this.pb_addstudent.Size = new System.Drawing.Size(937, 724);
            this.pb_addstudent.TabIndex = 0;
            // 
            // btn_add_import
            // 
            this.btn_add_import.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(105)))), ((int)(((byte)(168)))));
            this.btn_add_import.FlatAppearance.BorderSize = 0;
            this.btn_add_import.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_add_import.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_add_import.ForeColor = System.Drawing.Color.White;
            this.btn_add_import.Location = new System.Drawing.Point(674, 244);
            this.btn_add_import.Name = "btn_add_import";
            this.btn_add_import.Size = new System.Drawing.Size(140, 32);
            this.btn_add_import.TabIndex = 29;
            this.btn_add_import.Text = "Import";
            this.btn_add_import.UseVisualStyleBackColor = false;
            this.btn_add_import.Click += new System.EventHandler(this.btn_add_import_Click);
            // 
            // pb_add_image
            // 
            this.pb_add_image.BackColor = System.Drawing.Color.Gainsboro;
            this.pb_add_image.Location = new System.Drawing.Point(674, 90);
            this.pb_add_image.Name = "pb_add_image";
            this.pb_add_image.Size = new System.Drawing.Size(140, 139);
            this.pb_add_image.TabIndex = 28;
            this.pb_add_image.TabStop = false;
            // 
            // btn_add_add
            // 
            this.btn_add_add.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(105)))), ((int)(((byte)(168)))));
            this.btn_add_add.FlatAppearance.BorderSize = 0;
            this.btn_add_add.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_add_add.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_add_add.ForeColor = System.Drawing.Color.White;
            this.btn_add_add.Location = new System.Drawing.Point(330, 512);
            this.btn_add_add.Name = "btn_add_add";
            this.btn_add_add.Size = new System.Drawing.Size(177, 48);
            this.btn_add_add.TabIndex = 27;
            this.btn_add_add.Text = "ADD";
            this.btn_add_add.UseVisualStyleBackColor = false;
            this.btn_add_add.Click += new System.EventHandler(this.btn_add_add_Click);
            // 
            // txt_add_phone
            // 
            this.txt_add_phone.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_add_phone.Location = new System.Drawing.Point(253, 400);
            this.txt_add_phone.Name = "txt_add_phone";
            this.txt_add_phone.Size = new System.Drawing.Size(323, 30);
            this.txt_add_phone.TabIndex = 26;
            this.txt_add_phone.Validating += new System.ComponentModel.CancelEventHandler(this.txt_add_phone_Validating);
            // 
            // dateTime_add_birth
            // 
            this.dateTime_add_birth.CustomFormat = "dd/MM/yyyy";
            this.dateTime_add_birth.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTime_add_birth.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTime_add_birth.Location = new System.Drawing.Point(253, 306);
            this.dateTime_add_birth.Name = "dateTime_add_birth";
            this.dateTime_add_birth.Size = new System.Drawing.Size(323, 27);
            this.dateTime_add_birth.TabIndex = 25;
            this.dateTime_add_birth.Validating += new System.ComponentModel.CancelEventHandler(this.dateTime_add_birth_Validating);
            // 
            // cbb_add_gender
            // 
            this.cbb_add_gender.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbb_add_gender.FormattingEnabled = true;
            this.cbb_add_gender.Items.AddRange(new object[] {
            "Male",
            "Female",
            "Others"});
            this.cbb_add_gender.Location = new System.Drawing.Point(253, 231);
            this.cbb_add_gender.Name = "cbb_add_gender";
            this.cbb_add_gender.Size = new System.Drawing.Size(323, 28);
            this.cbb_add_gender.TabIndex = 24;
            // 
            // txt_add_name
            // 
            this.txt_add_name.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_add_name.Location = new System.Drawing.Point(253, 158);
            this.txt_add_name.Name = "txt_add_name";
            this.txt_add_name.Size = new System.Drawing.Size(323, 30);
            this.txt_add_name.TabIndex = 22;
            this.txt_add_name.Validating += new System.ComponentModel.CancelEventHandler(this.txt_add_name_Validating);
            // 
            // txt_add_id
            // 
            this.txt_add_id.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_add_id.Location = new System.Drawing.Point(253, 90);
            this.txt_add_id.Name = "txt_add_id";
            this.txt_add_id.Size = new System.Drawing.Size(323, 30);
            this.txt_add_id.TabIndex = 21;
            this.txt_add_id.Validating += new System.ComponentModel.CancelEventHandler(this.txt_add_id_Validating);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(28, 400);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(171, 29);
            this.label6.TabIndex = 19;
            this.label6.Text = "Phone number";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(99, 306);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(100, 29);
            this.label5.TabIndex = 18;
            this.label5.Text = "Birthday";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(105, 230);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(94, 29);
            this.label4.TabIndex = 5;
            this.label4.Text = "Gender";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(121, 158);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(78, 29);
            this.label3.TabIndex = 4;
            this.label3.Text = "Name";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(75, 90);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(124, 29);
            this.label2.TabIndex = 3;
            this.label2.Text = "Student ID";
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // AddStudent
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.pb_addstudent);
            this.Name = "AddStudent";
            this.Size = new System.Drawing.Size(992, 773);
            this.pb_addstudent.ResumeLayout(false);
            this.pb_addstudent.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pb_add_image)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pb_addstudent;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cbb_add_gender;
        private System.Windows.Forms.TextBox txt_add_name;
        private System.Windows.Forms.TextBox txt_add_id;
        private System.Windows.Forms.TextBox txt_add_phone;
        private System.Windows.Forms.DateTimePicker dateTime_add_birth;
        private System.Windows.Forms.Button btn_add_add;
        private System.Windows.Forms.PictureBox pb_add_image;
        private System.Windows.Forms.Button btn_add_import;
        private System.Windows.Forms.ErrorProvider errorProvider1;
    }
}
