namespace QLSV_L1
{
    partial class LoginForm
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
            this.components = new System.ComponentModel.Container();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.btn_sign_up = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.radiobtn_human_resourse = new System.Windows.Forms.RadioButton();
            this.radio_staff = new System.Windows.Forms.RadioButton();
            this.radiobtn_admin = new System.Windows.Forms.RadioButton();
            this.checkb_login = new System.Windows.Forms.CheckBox();
            this.btn_login = new System.Windows.Forms.Button();
            this.txt_login_password = new System.Windows.Forms.TextBox();
            this.txt_login_username = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(105)))), ((int)(((byte)(168)))));
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.btn_sign_up);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(331, 565);
            this.panel1.TabIndex = 0;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::QLSV_L1.Properties.Resources.job_symbol_on_student_flat_vector_15947972;
            this.pictureBox1.Location = new System.Drawing.Point(101, 46);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(134, 120);
            this.pictureBox1.TabIndex = 7;
            this.pictureBox1.TabStop = false;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label6.Location = new System.Drawing.Point(12, 203);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(269, 22);
            this.label6.TabIndex = 6;
            this.label6.Text = "Student Management System";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label5.Location = new System.Drawing.Point(60, 397);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(194, 20);
            this.label5.TabIndex = 5;
            this.label5.Text = "Register your account";
            // 
            // btn_sign_up
            // 
            this.btn_sign_up.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(52)))), ((int)(((byte)(132)))));
            this.btn_sign_up.FlatAppearance.BorderSize = 0;
            this.btn_sign_up.FlatAppearance.MouseDownBackColor = System.Drawing.Color.SteelBlue;
            this.btn_sign_up.FlatAppearance.MouseOverBackColor = System.Drawing.Color.SteelBlue;
            this.btn_sign_up.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_sign_up.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_sign_up.ForeColor = System.Drawing.Color.Transparent;
            this.btn_sign_up.Location = new System.Drawing.Point(28, 435);
            this.btn_sign_up.Name = "btn_sign_up";
            this.btn_sign_up.Size = new System.Drawing.Size(275, 45);
            this.btn_sign_up.TabIndex = 4;
            this.btn_sign_up.Text = "Sign up";
            this.btn_sign_up.UseVisualStyleBackColor = false;
            this.btn_sign_up.Click += new System.EventHandler(this.btn_sign_up_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.panel2.Controls.Add(this.radiobtn_human_resourse);
            this.panel2.Controls.Add(this.radio_staff);
            this.panel2.Controls.Add(this.radiobtn_admin);
            this.panel2.Controls.Add(this.checkb_login);
            this.panel2.Controls.Add(this.btn_login);
            this.panel2.Controls.Add(this.txt_login_password);
            this.panel2.Controls.Add(this.txt_login_username);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(331, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(472, 565);
            this.panel2.TabIndex = 1;
            // 
            // radiobtn_human_resourse
            // 
            this.radiobtn_human_resourse.AutoSize = true;
            this.radiobtn_human_resourse.Location = new System.Drawing.Point(279, 412);
            this.radiobtn_human_resourse.Name = "radiobtn_human_resourse";
            this.radiobtn_human_resourse.Size = new System.Drawing.Size(127, 20);
            this.radiobtn_human_resourse.TabIndex = 18;
            this.radiobtn_human_resourse.TabStop = true;
            this.radiobtn_human_resourse.Text = "Human resourse";
            this.radiobtn_human_resourse.UseVisualStyleBackColor = true;
            // 
            // radio_staff
            // 
            this.radio_staff.AutoSize = true;
            this.radio_staff.Location = new System.Drawing.Point(181, 412);
            this.radio_staff.Name = "radio_staff";
            this.radio_staff.Size = new System.Drawing.Size(73, 20);
            this.radio_staff.TabIndex = 17;
            this.radio_staff.TabStop = true;
            this.radio_staff.Text = "Student";
            this.radio_staff.UseVisualStyleBackColor = true;
            // 
            // radiobtn_admin
            // 
            this.radiobtn_admin.AutoSize = true;
            this.radiobtn_admin.Location = new System.Drawing.Point(71, 412);
            this.radiobtn_admin.Name = "radiobtn_admin";
            this.radiobtn_admin.Size = new System.Drawing.Size(66, 20);
            this.radiobtn_admin.TabIndex = 16;
            this.radiobtn_admin.TabStop = true;
            this.radiobtn_admin.Text = "Admin";
            this.radiobtn_admin.UseVisualStyleBackColor = true;
            // 
            // checkb_login
            // 
            this.checkb_login.AutoSize = true;
            this.checkb_login.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.checkb_login.Location = new System.Drawing.Point(234, 370);
            this.checkb_login.Name = "checkb_login";
            this.checkb_login.Size = new System.Drawing.Size(121, 20);
            this.checkb_login.TabIndex = 15;
            this.checkb_login.Text = "Show Password";
            this.checkb_login.UseVisualStyleBackColor = true;
            this.checkb_login.CheckedChanged += new System.EventHandler(this.checkb_login_CheckedChanged);
            // 
            // btn_login
            // 
            this.btn_login.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(52)))), ((int)(((byte)(132)))));
            this.btn_login.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_login.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_login.ForeColor = System.Drawing.Color.White;
            this.btn_login.Location = new System.Drawing.Point(71, 482);
            this.btn_login.Name = "btn_login";
            this.btn_login.Size = new System.Drawing.Size(130, 51);
            this.btn_login.TabIndex = 14;
            this.btn_login.Text = "Login";
            this.btn_login.UseVisualStyleBackColor = false;
            this.btn_login.Click += new System.EventHandler(this.btn_login_Click);
            // 
            // txt_login_password
            // 
            this.txt_login_password.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_login_password.Location = new System.Drawing.Point(71, 316);
            this.txt_login_password.Name = "txt_login_password";
            this.txt_login_password.PasswordChar = '*';
            this.txt_login_password.Size = new System.Drawing.Size(284, 34);
            this.txt_login_password.TabIndex = 13;
            this.txt_login_password.Validating += new System.ComponentModel.CancelEventHandler(this.txt_login_password_Validating);
            // 
            // txt_login_username
            // 
            this.txt_login_username.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_login_username.Location = new System.Drawing.Point(71, 215);
            this.txt_login_username.Name = "txt_login_username";
            this.txt_login_username.Size = new System.Drawing.Size(284, 34);
            this.txt_login_username.TabIndex = 12;
            this.txt_login_username.TextChanged += new System.EventHandler(this.txt_login_username_TextChanged);
            this.txt_login_username.Validating += new System.ComponentModel.CancelEventHandler(this.txt_login_username_Validating);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(70, 288);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(104, 25);
            this.label4.TabIndex = 11;
            this.label4.Text = "Password:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(66, 187);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(108, 25);
            this.label3.TabIndex = 10;
            this.label3.Text = "Username:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Tai Le", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(65, 98);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(204, 35);
            this.label2.TabIndex = 9;
            this.label2.Text = "Login Account";
            // 
            // label1
            // 
            this.label1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.label1.Font = new System.Drawing.Font("Candara", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(426, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(34, 33);
            this.label1.TabIndex = 8;
            this.label1.Text = "X";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // LoginForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(803, 565);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "LoginForm";
            this.Text = "Form1";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btn_sign_up;
        private System.Windows.Forms.CheckBox checkb_login;
        private System.Windows.Forms.TextBox txt_login_password;
        private System.Windows.Forms.TextBox txt_login_username;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.Button btn_login;
        private System.Windows.Forms.RadioButton radiobtn_admin;
        private System.Windows.Forms.RadioButton radio_staff;
        private System.Windows.Forms.RadioButton radiobtn_human_resourse;
    }
}

