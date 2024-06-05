namespace QLSV_L1
{
    partial class SignUp_Form
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
            this.lbl_tt_signup = new System.Windows.Forms.Label();
            this.txt_username = new System.Windows.Forms.TextBox();
            this.txt_pass = new System.Windows.Forms.TextBox();
            this.txt_repass = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.lbl_signup_destroy = new System.Windows.Forms.Label();
            this.btn_createAccount = new System.Windows.Forms.Button();
            this.btn_cancel_signup = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.txt_full_name = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btn_getcode = new System.Windows.Forms.Button();
            this.txt_code = new System.Windows.Forms.TextBox();
            this.btn_sendCode = new System.Windows.Forms.Button();
            this.txt_email = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // lbl_tt_signup
            // 
            this.lbl_tt_signup.AutoSize = true;
            this.lbl_tt_signup.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_tt_signup.Location = new System.Drawing.Point(218, 55);
            this.lbl_tt_signup.Name = "lbl_tt_signup";
            this.lbl_tt_signup.Size = new System.Drawing.Size(296, 36);
            this.lbl_tt_signup.TabIndex = 0;
            this.lbl_tt_signup.Text = "Create new account";
            // 
            // txt_username
            // 
            this.txt_username.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_username.Location = new System.Drawing.Point(273, 376);
            this.txt_username.Name = "txt_username";
            this.txt_username.Size = new System.Drawing.Size(275, 30);
            this.txt_username.TabIndex = 5;
            // 
            // txt_pass
            // 
            this.txt_pass.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_pass.Location = new System.Drawing.Point(273, 441);
            this.txt_pass.Name = "txt_pass";
            this.txt_pass.Size = new System.Drawing.Size(275, 30);
            this.txt_pass.TabIndex = 6;
            // 
            // txt_repass
            // 
            this.txt_repass.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_repass.Location = new System.Drawing.Point(273, 505);
            this.txt_repass.Name = "txt_repass";
            this.txt_repass.Size = new System.Drawing.Size(275, 30);
            this.txt_repass.TabIndex = 7;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(120, 381);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(113, 25);
            this.label3.TabIndex = 8;
            this.label3.Text = "User name:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(120, 510);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(135, 25);
            this.label4.TabIndex = 9;
            this.label4.Text = "Re-Password:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(120, 444);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(104, 25);
            this.label5.TabIndex = 10;
            this.label5.Text = "Password:";
            // 
            // lbl_signup_destroy
            // 
            this.lbl_signup_destroy.AutoSize = true;
            this.lbl_signup_destroy.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_signup_destroy.Location = new System.Drawing.Point(699, 9);
            this.lbl_signup_destroy.Name = "lbl_signup_destroy";
            this.lbl_signup_destroy.Size = new System.Drawing.Size(31, 29);
            this.lbl_signup_destroy.TabIndex = 12;
            this.lbl_signup_destroy.Text = "X";
            this.lbl_signup_destroy.Click += new System.EventHandler(this.lbl_signup_destroy_Click);
            this.lbl_signup_destroy.MouseClick += new System.Windows.Forms.MouseEventHandler(this.lbl_signup_destroy_MouseClick);
            // 
            // btn_createAccount
            // 
            this.btn_createAccount.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(105)))), ((int)(((byte)(168)))));
            this.btn_createAccount.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_createAccount.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_createAccount.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_createAccount.Location = new System.Drawing.Point(125, 574);
            this.btn_createAccount.Name = "btn_createAccount";
            this.btn_createAccount.Size = new System.Drawing.Size(130, 42);
            this.btn_createAccount.TabIndex = 13;
            this.btn_createAccount.Text = "OK";
            this.btn_createAccount.UseVisualStyleBackColor = false;
            this.btn_createAccount.Click += new System.EventHandler(this.btn_createAccount_Click);
            // 
            // btn_cancel_signup
            // 
            this.btn_cancel_signup.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(105)))), ((int)(((byte)(168)))));
            this.btn_cancel_signup.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_cancel_signup.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_cancel_signup.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_cancel_signup.Location = new System.Drawing.Point(412, 574);
            this.btn_cancel_signup.Name = "btn_cancel_signup";
            this.btn_cancel_signup.Size = new System.Drawing.Size(136, 42);
            this.btn_cancel_signup.TabIndex = 14;
            this.btn_cancel_signup.Text = "Cancel";
            this.btn_cancel_signup.UseVisualStyleBackColor = false;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(120, 315);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(106, 25);
            this.label6.TabIndex = 16;
            this.label6.Text = "Full Name:";
            // 
            // txt_full_name
            // 
            this.txt_full_name.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_full_name.Location = new System.Drawing.Point(273, 312);
            this.txt_full_name.Name = "txt_full_name";
            this.txt_full_name.Size = new System.Drawing.Size(275, 30);
            this.txt_full_name.TabIndex = 17;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(34, 143);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(66, 25);
            this.label1.TabIndex = 1;
            this.label1.Text = "Email:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(34, 222);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(66, 25);
            this.label2.TabIndex = 2;
            this.label2.Text = "Code:";
            // 
            // btn_getcode
            // 
            this.btn_getcode.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(105)))), ((int)(((byte)(168)))));
            this.btn_getcode.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_getcode.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_getcode.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_getcode.Location = new System.Drawing.Point(600, 215);
            this.btn_getcode.Name = "btn_getcode";
            this.btn_getcode.Size = new System.Drawing.Size(130, 37);
            this.btn_getcode.TabIndex = 15;
            this.btn_getcode.Text = "Verify";
            this.btn_getcode.UseVisualStyleBackColor = false;
            this.btn_getcode.Click += new System.EventHandler(this.btn_getcode_Click);
            // 
            // txt_code
            // 
            this.txt_code.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_code.Location = new System.Drawing.Point(125, 222);
            this.txt_code.Name = "txt_code";
            this.txt_code.Size = new System.Drawing.Size(423, 30);
            this.txt_code.TabIndex = 4;
            // 
            // btn_sendCode
            // 
            this.btn_sendCode.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(105)))), ((int)(((byte)(168)))));
            this.btn_sendCode.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_sendCode.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_sendCode.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_sendCode.Location = new System.Drawing.Point(600, 134);
            this.btn_sendCode.Name = "btn_sendCode";
            this.btn_sendCode.Size = new System.Drawing.Size(130, 42);
            this.btn_sendCode.TabIndex = 11;
            this.btn_sendCode.Text = "Send Code";
            this.btn_sendCode.UseVisualStyleBackColor = false;
            this.btn_sendCode.Click += new System.EventHandler(this.btn_sendCode_Click);
            // 
            // txt_email
            // 
            this.txt_email.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_email.Location = new System.Drawing.Point(125, 138);
            this.txt_email.Name = "txt_email";
            this.txt_email.Size = new System.Drawing.Size(423, 30);
            this.txt_email.TabIndex = 3;
            // 
            // SignUp_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(781, 651);
            this.Controls.Add(this.txt_full_name);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.btn_getcode);
            this.Controls.Add(this.btn_cancel_signup);
            this.Controls.Add(this.btn_createAccount);
            this.Controls.Add(this.lbl_signup_destroy);
            this.Controls.Add(this.btn_sendCode);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txt_repass);
            this.Controls.Add(this.txt_pass);
            this.Controls.Add(this.txt_username);
            this.Controls.Add(this.txt_code);
            this.Controls.Add(this.txt_email);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lbl_tt_signup);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "SignUp_Form";
            this.Text = "SignUp_Form";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_tt_signup;
        private System.Windows.Forms.TextBox txt_username;
        private System.Windows.Forms.TextBox txt_pass;
        private System.Windows.Forms.TextBox txt_repass;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lbl_signup_destroy;
        private System.Windows.Forms.Button btn_createAccount;
        private System.Windows.Forms.Button btn_cancel_signup;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txt_full_name;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btn_getcode;
        private System.Windows.Forms.TextBox txt_code;
        private System.Windows.Forms.Button btn_sendCode;
        private System.Windows.Forms.TextBox txt_email;
    }
}