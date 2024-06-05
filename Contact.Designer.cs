using System.Windows.Forms;

namespace QLSV_L1
{
    partial class Contact
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
            this.btn_refresh = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.lbl_gmail = new System.Windows.Forms.Label();
            this.lbl_name = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btn_contact_showlist = new System.Windows.Forms.Button();
            this.btn_contact_remove = new System.Windows.Forms.Button();
            this.btn_contact_select = new System.Windows.Forms.Button();
            this.txt_contact_id = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btn_contact_add = new System.Windows.Forms.Button();
            this.btn_contact_edit = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel6 = new System.Windows.Forms.Panel();
            this.cbb_group_remove = new System.Windows.Forms.ComboBox();
            this.btn_group_remove = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.panel5 = new System.Windows.Forms.Panel();
            this.txt_contact_newname = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.cbb_group_select = new System.Windows.Forms.ComboBox();
            this.button1 = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.btn_group_add = new System.Windows.Forms.Button();
            this.txt_group_name = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.pbb_user_image = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel6.SuspendLayout();
            this.panel5.SuspendLayout();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbb_user_image)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(105)))), ((int)(((byte)(168)))));
            this.panel1.Controls.Add(this.btn_refresh);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.pbb_user_image);
            this.panel1.Controls.Add(this.lbl_gmail);
            this.panel1.Controls.Add(this.lbl_name);
            this.panel1.Location = new System.Drawing.Point(0, -1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1193, 145);
            this.panel1.TabIndex = 0;
            // 
            // btn_refresh
            // 
            this.btn_refresh.BackColor = System.Drawing.Color.LimeGreen;
            this.btn_refresh.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_refresh.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_refresh.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_refresh.Location = new System.Drawing.Point(28, 99);
            this.btn_refresh.Name = "btn_refresh";
            this.btn_refresh.Size = new System.Drawing.Size(142, 30);
            this.btn_refresh.TabIndex = 4;
            this.btn_refresh.Text = "Refresh";
            this.btn_refresh.UseVisualStyleBackColor = false;
            this.btn_refresh.Click += new System.EventHandler(this.btn_refresh_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(35, 39);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(323, 42);
            this.label7.TabIndex = 3;
            this.label7.Text = "Human Resourse";
            // 
            // lbl_gmail
            // 
            this.lbl_gmail.AutoSize = true;
            this.lbl_gmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_gmail.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lbl_gmail.Location = new System.Drawing.Point(813, 76);
            this.lbl_gmail.Name = "lbl_gmail";
            this.lbl_gmail.Size = new System.Drawing.Size(46, 18);
            this.lbl_gmail.TabIndex = 1;
            this.lbl_gmail.Text = "label1";
            // 
            // lbl_name
            // 
            this.lbl_name.AutoSize = true;
            this.lbl_name.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_name.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lbl_name.Location = new System.Drawing.Point(811, 39);
            this.lbl_name.Name = "lbl_name";
            this.lbl_name.Size = new System.Drawing.Size(70, 25);
            this.lbl_name.TabIndex = 0;
            this.lbl_name.Text = "label1";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.Controls.Add(this.btn_contact_showlist);
            this.panel2.Controls.Add(this.btn_contact_remove);
            this.panel2.Controls.Add(this.btn_contact_select);
            this.panel2.Controls.Add(this.txt_contact_id);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.btn_contact_add);
            this.panel2.Controls.Add(this.btn_contact_edit);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Location = new System.Drawing.Point(28, 150);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(543, 574);
            this.panel2.TabIndex = 1;
            // 
            // btn_contact_showlist
            // 
            this.btn_contact_showlist.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(105)))), ((int)(((byte)(168)))));
            this.btn_contact_showlist.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btn_contact_showlist.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_contact_showlist.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_contact_showlist.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_contact_showlist.Location = new System.Drawing.Point(56, 489);
            this.btn_contact_showlist.Name = "btn_contact_showlist";
            this.btn_contact_showlist.Size = new System.Drawing.Size(143, 50);
            this.btn_contact_showlist.TabIndex = 7;
            this.btn_contact_showlist.Text = "Show Full List";
            this.btn_contact_showlist.UseVisualStyleBackColor = false;
            this.btn_contact_showlist.Click += new System.EventHandler(this.btn_contact_showlist_Click);
            // 
            // btn_contact_remove
            // 
            this.btn_contact_remove.BackColor = System.Drawing.Color.Red;
            this.btn_contact_remove.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btn_contact_remove.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_contact_remove.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_contact_remove.ForeColor = System.Drawing.Color.White;
            this.btn_contact_remove.Location = new System.Drawing.Point(56, 386);
            this.btn_contact_remove.Name = "btn_contact_remove";
            this.btn_contact_remove.Size = new System.Drawing.Size(468, 43);
            this.btn_contact_remove.TabIndex = 6;
            this.btn_contact_remove.Text = "Remove";
            this.btn_contact_remove.UseVisualStyleBackColor = false;
            this.btn_contact_remove.Click += new System.EventHandler(this.btn_contact_remove_Click);
            // 
            // btn_contact_select
            // 
            this.btn_contact_select.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(105)))), ((int)(((byte)(168)))));
            this.btn_contact_select.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btn_contact_select.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_contact_select.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_contact_select.Location = new System.Drawing.Point(417, 323);
            this.btn_contact_select.Name = "btn_contact_select";
            this.btn_contact_select.Size = new System.Drawing.Size(107, 31);
            this.btn_contact_select.TabIndex = 5;
            this.btn_contact_select.Text = "Select";
            this.btn_contact_select.UseVisualStyleBackColor = false;
            // 
            // txt_contact_id
            // 
            this.txt_contact_id.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_contact_id.Location = new System.Drawing.Point(220, 327);
            this.txt_contact_id.Name = "txt_contact_id";
            this.txt_contact_id.Size = new System.Drawing.Size(181, 27);
            this.txt_contact_id.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label3.Location = new System.Drawing.Point(52, 330);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(147, 20);
            this.label3.TabIndex = 3;
            this.label3.Text = "Enter contact ID";
            // 
            // btn_contact_add
            // 
            this.btn_contact_add.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(105)))), ((int)(((byte)(168)))));
            this.btn_contact_add.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btn_contact_add.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_contact_add.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_contact_add.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_contact_add.Location = new System.Drawing.Point(47, 119);
            this.btn_contact_add.Name = "btn_contact_add";
            this.btn_contact_add.Size = new System.Drawing.Size(152, 43);
            this.btn_contact_add.TabIndex = 2;
            this.btn_contact_add.Text = "Add";
            this.btn_contact_add.UseVisualStyleBackColor = false;
            this.btn_contact_add.Click += new System.EventHandler(this.btn_contact_add_Click);
            // 
            // btn_contact_edit
            // 
            this.btn_contact_edit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(105)))), ((int)(((byte)(168)))));
            this.btn_contact_edit.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btn_contact_edit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_contact_edit.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_contact_edit.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_contact_edit.Location = new System.Drawing.Point(47, 204);
            this.btn_contact_edit.Name = "btn_contact_edit";
            this.btn_contact_edit.Size = new System.Drawing.Size(152, 43);
            this.btn_contact_edit.TabIndex = 1;
            this.btn_contact_edit.Text = "Edit";
            this.btn_contact_edit.UseVisualStyleBackColor = false;
            this.btn_contact_edit.Click += new System.EventHandler(this.btn_contact_edit_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label1.Location = new System.Drawing.Point(177, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(124, 36);
            this.label1.TabIndex = 0;
            this.label1.Text = "Contact";
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.White;
            this.panel3.Controls.Add(this.panel6);
            this.panel3.Controls.Add(this.panel5);
            this.panel3.Controls.Add(this.panel4);
            this.panel3.Controls.Add(this.label2);
            this.panel3.Location = new System.Drawing.Point(593, 150);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(587, 574);
            this.panel3.TabIndex = 2;
            // 
            // panel6
            // 
            this.panel6.Controls.Add(this.cbb_group_remove);
            this.panel6.Controls.Add(this.btn_group_remove);
            this.panel6.Controls.Add(this.label8);
            this.panel6.Location = new System.Drawing.Point(26, 407);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(535, 132);
            this.panel6.TabIndex = 13;
            // 
            // cbb_group_remove
            // 
            this.cbb_group_remove.FormattingEnabled = true;
            this.cbb_group_remove.Location = new System.Drawing.Point(187, 15);
            this.cbb_group_remove.Name = "cbb_group_remove";
            this.cbb_group_remove.Size = new System.Drawing.Size(318, 24);
            this.cbb_group_remove.TabIndex = 15;
            // 
            // btn_group_remove
            // 
            this.btn_group_remove.BackColor = System.Drawing.Color.Red;
            this.btn_group_remove.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btn_group_remove.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_group_remove.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_group_remove.ForeColor = System.Drawing.Color.White;
            this.btn_group_remove.Location = new System.Drawing.Point(16, 69);
            this.btn_group_remove.Name = "btn_group_remove";
            this.btn_group_remove.Size = new System.Drawing.Size(495, 43);
            this.btn_group_remove.TabIndex = 14;
            this.btn_group_remove.Text = "Remove";
            this.btn_group_remove.UseVisualStyleBackColor = false;
            this.btn_group_remove.Click += new System.EventHandler(this.btn_group_remove_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label8.Location = new System.Drawing.Point(12, 15);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(115, 20);
            this.label8.TabIndex = 11;
            this.label8.Text = "Select group";
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.txt_contact_newname);
            this.panel5.Controls.Add(this.label6);
            this.panel5.Controls.Add(this.cbb_group_select);
            this.panel5.Controls.Add(this.button1);
            this.panel5.Controls.Add(this.label5);
            this.panel5.Location = new System.Drawing.Point(26, 228);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(535, 164);
            this.panel5.TabIndex = 12;
            // 
            // txt_contact_newname
            // 
            this.txt_contact_newname.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_contact_newname.Location = new System.Drawing.Point(187, 58);
            this.txt_contact_newname.Name = "txt_contact_newname";
            this.txt_contact_newname.Size = new System.Drawing.Size(318, 27);
            this.txt_contact_newname.TabIndex = 17;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label6.Location = new System.Drawing.Point(12, 61);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(144, 20);
            this.label6.TabIndex = 16;
            this.label6.Text = "Enter new name";
            // 
            // cbb_group_select
            // 
            this.cbb_group_select.FormattingEnabled = true;
            this.cbb_group_select.Location = new System.Drawing.Point(187, 15);
            this.cbb_group_select.Name = "cbb_group_select";
            this.cbb_group_select.Size = new System.Drawing.Size(318, 24);
            this.cbb_group_select.TabIndex = 15;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(105)))), ((int)(((byte)(168)))));
            this.button1.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(16, 102);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(495, 43);
            this.button1.TabIndex = 14;
            this.button1.Text = "Edit";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label5.Location = new System.Drawing.Point(12, 15);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(115, 20);
            this.label5.TabIndex = 11;
            this.label5.Text = "Select group";
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.btn_group_add);
            this.panel4.Controls.Add(this.txt_group_name);
            this.panel4.Controls.Add(this.label4);
            this.panel4.Location = new System.Drawing.Point(20, 82);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(535, 119);
            this.panel4.TabIndex = 11;
            // 
            // btn_group_add
            // 
            this.btn_group_add.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(105)))), ((int)(((byte)(168)))));
            this.btn_group_add.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btn_group_add.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_group_add.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_group_add.ForeColor = System.Drawing.Color.White;
            this.btn_group_add.Location = new System.Drawing.Point(16, 61);
            this.btn_group_add.Name = "btn_group_add";
            this.btn_group_add.Size = new System.Drawing.Size(495, 43);
            this.btn_group_add.TabIndex = 14;
            this.btn_group_add.Text = "Add";
            this.btn_group_add.UseVisualStyleBackColor = false;
            this.btn_group_add.Click += new System.EventHandler(this.btn_group_add_Click);
            // 
            // txt_group_name
            // 
            this.txt_group_name.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_group_name.Location = new System.Drawing.Point(215, 12);
            this.txt_group_name.Name = "txt_group_name";
            this.txt_group_name.Size = new System.Drawing.Size(296, 27);
            this.txt_group_name.TabIndex = 12;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label4.Location = new System.Drawing.Point(12, 15);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(161, 20);
            this.label4.TabIndex = 11;
            this.label4.Text = "Enter group Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label2.Location = new System.Drawing.Point(217, 29);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(104, 36);
            this.label2.TabIndex = 1;
            this.label2.Text = "Group";
            // 
            // pbb_user_image
            // 
            this.pbb_user_image.Image = global::QLSV_L1.Properties.Resources.c42eb09e_3ac4_4590_b3c0_abbd822da6d0_640_360;
            this.pbb_user_image.Location = new System.Drawing.Point(1028, 13);
            this.pbb_user_image.Name = "pbb_user_image";
            this.pbb_user_image.Size = new System.Drawing.Size(149, 116);
            this.pbb_user_image.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbb_user_image.TabIndex = 2;
            this.pbb_user_image.TabStop = false;
            // 
            // Contact
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(105)))), ((int)(((byte)(168)))));
            this.ClientSize = new System.Drawing.Size(1205, 751);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "Contact";
            this.Text = "Contact";
            this.Load += new System.EventHandler(this.Contact_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel6.ResumeLayout(false);
            this.panel6.PerformLayout();
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbb_user_image)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lbl_name;
        private System.Windows.Forms.Label lbl_gmail;
        private System.Windows.Forms.PictureBox pbb_user_image;
        private Panel panel2;
        private Label label1;
        private Button btn_contact_edit;
        private Button btn_contact_add;
        private Label label3;
        private TextBox txt_contact_id;
        private Button btn_contact_remove;
        private Button btn_contact_select;
        private Button btn_contact_showlist;
        private Panel panel3;
        private Label label2;
        private Panel panel4;
        private Button btn_group_add;
        private TextBox txt_group_name;
        private Label label4;
        private Panel panel6;
        private ComboBox cbb_group_remove;
        private Button btn_group_remove;
        private Label label8;
        private Panel panel5;
        private TextBox txt_contact_newname;
        private Label label6;
        private ComboBox cbb_group_select;
        private Button button1;
        private Label label5;
        private Label label7;
        private Button btn_refresh;
    }
}