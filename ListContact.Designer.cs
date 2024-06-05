using System.Windows.Forms;

namespace QLSV_L1
{
    partial class ListContact
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
            this.listbox_group = new System.Windows.Forms.ListBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label7 = new System.Windows.Forms.Label();
            this.dtgrid_contact = new System.Windows.Forms.DataGridView();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtgrid_contact)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(105)))), ((int)(((byte)(168)))));
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.listbox_group);
            this.panel1.Location = new System.Drawing.Point(2, 127);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(280, 567);
            this.panel1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(83, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(104, 36);
            this.label1.TabIndex = 5;
            this.label1.Text = "Group";
            // 
            // listbox_group
            // 
            this.listbox_group.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listbox_group.FormattingEnabled = true;
            this.listbox_group.ItemHeight = 20;
            this.listbox_group.Location = new System.Drawing.Point(64, 109);
            this.listbox_group.Name = "listbox_group";
            this.listbox_group.Size = new System.Drawing.Size(155, 164);
            this.listbox_group.TabIndex = 0;
            this.listbox_group.DoubleClick += new System.EventHandler(this.listbox_group_DoubleClick);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(105)))), ((int)(((byte)(168)))));
            this.panel2.Controls.Add(this.pictureBox1);
            this.panel2.Controls.Add(this.label7);
            this.panel2.Location = new System.Drawing.Point(2, 1);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1011, 120);
            this.panel2.TabIndex = 1;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::QLSV_L1.Properties.Resources.c42eb09e_3ac4_4590_b3c0_abbd822da6d0_640_360;
            this.pictureBox1.Location = new System.Drawing.Point(864, 11);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(119, 97);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 5;
            this.pictureBox1.TabStop = false;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(38, 28);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(266, 42);
            this.label7.TabIndex = 4;
            this.label7.Text = "Detail Contact";
            // 
            // dtgrid_contact
            // 
            this.dtgrid_contact.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgrid_contact.Location = new System.Drawing.Point(335, 150);
            this.dtgrid_contact.Name = "dtgrid_contact";
            this.dtgrid_contact.RowHeadersVisible = false;
            this.dtgrid_contact.RowHeadersWidth = 100;
            this.dtgrid_contact.RowTemplate.Height = 100;
            this.dtgrid_contact.Size = new System.Drawing.Size(626, 517);
            this.dtgrid_contact.TabIndex = 2;
            this.dtgrid_contact.DoubleClick += new System.EventHandler(this.dtgrid_contact_DoubleClick);
            // 
            // ListContact
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1012, 695);
            this.Controls.Add(this.dtgrid_contact);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "ListContact";
            this.Text = "List Contact";
            this.Load += new System.EventHandler(this.ListContact_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtgrid_contact)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ListBox listbox_group;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dtgrid_contact;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}