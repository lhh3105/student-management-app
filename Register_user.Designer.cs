using System.Windows.Forms;

namespace QLSV_L1
{
    partial class Register_user
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
            this.txt_full_name = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_pass = new System.Windows.Forms.TextBox();
            this.txt_username = new System.Windows.Forms.TextBox();
            this.txt_gmail = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label7 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.picture_image = new System.Windows.Forms.PictureBox();
            this.btt_register_import = new System.Windows.Forms.Button();
            this.btn_register_user = new System.Windows.Forms.Button();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picture_image)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // txt_full_name
            // 
            this.txt_full_name.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_full_name.Location = new System.Drawing.Point(288, 147);
            this.txt_full_name.Name = "txt_full_name";
            this.txt_full_name.Size = new System.Drawing.Size(275, 30);
            this.txt_full_name.TabIndex = 25;
            this.txt_full_name.Validating += new System.ComponentModel.CancelEventHandler(this.txt_full_name_Validating);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(135, 150);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(106, 25);
            this.label6.TabIndex = 24;
            this.label6.Text = "Full Name:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(135, 279);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(104, 25);
            this.label5.TabIndex = 23;
            this.label5.Text = "Password:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(135, 216);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(113, 25);
            this.label3.TabIndex = 21;
            this.label3.Text = "User name:";
            // 
            // txt_pass
            // 
            this.txt_pass.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_pass.Location = new System.Drawing.Point(288, 276);
            this.txt_pass.Name = "txt_pass";
            this.txt_pass.Size = new System.Drawing.Size(275, 30);
            this.txt_pass.TabIndex = 19;
            // 
            // txt_username
            // 
            this.txt_username.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_username.Location = new System.Drawing.Point(288, 211);
            this.txt_username.Name = "txt_username";
            this.txt_username.Size = new System.Drawing.Size(275, 30);
            this.txt_username.TabIndex = 18;
            // 
            // txt_gmail
            // 
            this.txt_gmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_gmail.Location = new System.Drawing.Point(288, 352);
            this.txt_gmail.Name = "txt_gmail";
            this.txt_gmail.Size = new System.Drawing.Size(275, 30);
            this.txt_gmail.TabIndex = 26;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(173, 355);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(66, 25);
            this.label1.TabIndex = 27;
            this.label1.Text = "Email:";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(105)))), ((int)(((byte)(168)))));
            this.panel1.Controls.Add(this.label7);
            this.panel1.Location = new System.Drawing.Point(1, -2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(843, 104);
            this.panel1.TabIndex = 28;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(44, 27);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(373, 42);
            this.label7.TabIndex = 4;
            this.label7.Text = "Create new Account";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(167, 433);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(72, 25);
            this.label2.TabIndex = 29;
            this.label2.Text = "Image:";
            // 
            // picture_image
            // 
            this.picture_image.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.picture_image.Location = new System.Drawing.Point(288, 433);
            this.picture_image.Name = "picture_image";
            this.picture_image.Size = new System.Drawing.Size(164, 125);
            this.picture_image.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picture_image.TabIndex = 30;
            this.picture_image.TabStop = false;
            // 
            // btt_register_import
            // 
            this.btt_register_import.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(105)))), ((int)(((byte)(168)))));
            this.btt_register_import.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btt_register_import.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btt_register_import.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btt_register_import.Location = new System.Drawing.Point(468, 433);
            this.btt_register_import.Name = "btt_register_import";
            this.btt_register_import.Size = new System.Drawing.Size(95, 37);
            this.btt_register_import.TabIndex = 31;
            this.btt_register_import.Text = "Import";
            this.btt_register_import.UseVisualStyleBackColor = false;
            this.btt_register_import.Click += new System.EventHandler(this.btt_register_import_Click);
            // 
            // btn_register_user
            // 
            this.btn_register_user.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(105)))), ((int)(((byte)(168)))));
            this.btn_register_user.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_register_user.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_register_user.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_register_user.Location = new System.Drawing.Point(288, 604);
            this.btn_register_user.Name = "btn_register_user";
            this.btn_register_user.Size = new System.Drawing.Size(275, 48);
            this.btn_register_user.TabIndex = 32;
            this.btn_register_user.Text = "Register";
            this.btn_register_user.UseVisualStyleBackColor = false;
            this.btn_register_user.Click += new System.EventHandler(this.btn_register_user_Click);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // Register_user
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(843, 683);
            this.Controls.Add(this.btn_register_user);
            this.Controls.Add(this.btt_register_import);
            this.Controls.Add(this.picture_image);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txt_gmail);
            this.Controls.Add(this.txt_full_name);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txt_pass);
            this.Controls.Add(this.txt_username);
            this.Name = "Register_user";
            this.Text = "Register_user";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picture_image)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txt_full_name;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txt_pass;
        private System.Windows.Forms.TextBox txt_username;
        private System.Windows.Forms.TextBox txt_gmail;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox picture_image;
        private System.Windows.Forms.Button btt_register_import;
        private System.Windows.Forms.Button btn_register_user;
        private ErrorProvider errorProvider1;
    }
}