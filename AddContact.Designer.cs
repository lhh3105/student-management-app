using System.Windows.Forms;

namespace QLSV_L1
{
    partial class AddContact
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txt_addcontact_id = new System.Windows.Forms.TextBox();
            this.txt_addcontact_name = new System.Windows.Forms.TextBox();
            this.txt_addcontact_phone = new System.Windows.Forms.TextBox();
            this.txt_addcontact_email = new System.Windows.Forms.TextBox();
            this.picture_addcontact = new System.Windows.Forms.PictureBox();
            this.btt_addcontact_import = new System.Windows.Forms.Button();
            this.btt_addcontact_add = new System.Windows.Forms.Button();
            this.cbb_addcontact_group = new System.Windows.Forms.ComboBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picture_addcontact)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(105)))), ((int)(((byte)(168)))));
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(0, 1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(883, 119);
            this.panel1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(45, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(181, 32);
            this.label1.TabIndex = 0;
            this.label1.Text = "Add Contact";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(33, 231);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(154, 25);
            this.label2.TabIndex = 1;
            this.label2.Text = "Teacher Name";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(54, 314);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(133, 25);
            this.label3.TabIndex = 2;
            this.label3.Text = "Group Name";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(113, 392);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(74, 25);
            this.label4.TabIndex = 3;
            this.label4.Text = "Phone";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(122, 473);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(65, 25);
            this.label5.TabIndex = 4;
            this.label5.Text = "Email";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(108, 543);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(79, 25);
            this.label6.TabIndex = 5;
            this.label6.Text = "Picture";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(78, 165);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(114, 25);
            this.label7.TabIndex = 6;
            this.label7.Text = "Contact ID";
            // 
            // txt_addcontact_id
            // 
            this.txt_addcontact_id.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_addcontact_id.Location = new System.Drawing.Point(253, 160);
            this.txt_addcontact_id.Name = "txt_addcontact_id";
            this.txt_addcontact_id.Size = new System.Drawing.Size(282, 30);
            this.txt_addcontact_id.TabIndex = 7;
            // 
            // txt_addcontact_name
            // 
            this.txt_addcontact_name.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_addcontact_name.Location = new System.Drawing.Point(253, 231);
            this.txt_addcontact_name.Name = "txt_addcontact_name";
            this.txt_addcontact_name.Size = new System.Drawing.Size(282, 30);
            this.txt_addcontact_name.TabIndex = 8;
            // 
            // txt_addcontact_phone
            // 
            this.txt_addcontact_phone.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_addcontact_phone.Location = new System.Drawing.Point(253, 387);
            this.txt_addcontact_phone.Name = "txt_addcontact_phone";
            this.txt_addcontact_phone.Size = new System.Drawing.Size(282, 30);
            this.txt_addcontact_phone.TabIndex = 10;
            // 
            // txt_addcontact_email
            // 
            this.txt_addcontact_email.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_addcontact_email.Location = new System.Drawing.Point(253, 468);
            this.txt_addcontact_email.Name = "txt_addcontact_email";
            this.txt_addcontact_email.Size = new System.Drawing.Size(282, 30);
            this.txt_addcontact_email.TabIndex = 11;
            // 
            // picture_addcontact
            // 
            this.picture_addcontact.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.picture_addcontact.Location = new System.Drawing.Point(253, 543);
            this.picture_addcontact.Name = "picture_addcontact";
            this.picture_addcontact.Size = new System.Drawing.Size(170, 120);
            this.picture_addcontact.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picture_addcontact.TabIndex = 12;
            this.picture_addcontact.TabStop = false;
            // 
            // btt_addcontact_import
            // 
            this.btt_addcontact_import.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(105)))), ((int)(((byte)(168)))));
            this.btt_addcontact_import.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btt_addcontact_import.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btt_addcontact_import.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btt_addcontact_import.Location = new System.Drawing.Point(440, 543);
            this.btt_addcontact_import.Name = "btt_addcontact_import";
            this.btt_addcontact_import.Size = new System.Drawing.Size(95, 37);
            this.btt_addcontact_import.TabIndex = 13;
            this.btt_addcontact_import.Text = "Import";
            this.btt_addcontact_import.UseVisualStyleBackColor = false;
            this.btt_addcontact_import.Click += new System.EventHandler(this.btt_addcontact_import_Click);
            // 
            // btt_addcontact_add
            // 
            this.btt_addcontact_add.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(105)))), ((int)(((byte)(168)))));
            this.btt_addcontact_add.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btt_addcontact_add.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btt_addcontact_add.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btt_addcontact_add.Location = new System.Drawing.Point(253, 710);
            this.btt_addcontact_add.Name = "btt_addcontact_add";
            this.btt_addcontact_add.Size = new System.Drawing.Size(170, 37);
            this.btt_addcontact_add.TabIndex = 14;
            this.btt_addcontact_add.Text = "Add";
            this.btt_addcontact_add.UseVisualStyleBackColor = false;
            this.btt_addcontact_add.Click += new System.EventHandler(this.btt_addcontact_add_Click);
            // 
            // cbb_addcontact_group
            // 
            this.cbb_addcontact_group.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbb_addcontact_group.FormattingEnabled = true;
            this.cbb_addcontact_group.Location = new System.Drawing.Point(253, 311);
            this.cbb_addcontact_group.Name = "cbb_addcontact_group";
            this.cbb_addcontact_group.Size = new System.Drawing.Size(282, 33);
            this.cbb_addcontact_group.TabIndex = 15;
            // 
            // AddContact
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(883, 789);
            this.Controls.Add(this.cbb_addcontact_group);
            this.Controls.Add(this.btt_addcontact_add);
            this.Controls.Add(this.btt_addcontact_import);
            this.Controls.Add(this.picture_addcontact);
            this.Controls.Add(this.txt_addcontact_email);
            this.Controls.Add(this.txt_addcontact_phone);
            this.Controls.Add(this.txt_addcontact_name);
            this.Controls.Add(this.txt_addcontact_id);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.panel1);
            this.Name = "AddContact";
            this.Text = "Contact";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picture_addcontact)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txt_addcontact_id;
        private System.Windows.Forms.TextBox txt_addcontact_name;
        private System.Windows.Forms.TextBox txt_addcontact_phone;
        private System.Windows.Forms.TextBox txt_addcontact_email;
        private System.Windows.Forms.PictureBox picture_addcontact;
        private System.Windows.Forms.Button btt_addcontact_import;
        private System.Windows.Forms.Button btt_addcontact_add;
        private ComboBox cbb_addcontact_group;
    }
}