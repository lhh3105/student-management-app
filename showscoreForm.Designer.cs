namespace QLSV_L1
{
    partial class showscoreForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.txt_showscore_studentid = new System.Windows.Forms.TextBox();
            this.btn_showscore_find = new System.Windows.Forms.Button();
            this.dtgrid_showscore_list = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.cbb_semester = new System.Windows.Forms.ComboBox();
            this.btn_text_file = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dtgrid_showscore_list)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(50, 59);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(98, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Student ID";
            // 
            // txt_showscore_studentid
            // 
            this.txt_showscore_studentid.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_showscore_studentid.Location = new System.Drawing.Point(202, 56);
            this.txt_showscore_studentid.Name = "txt_showscore_studentid";
            this.txt_showscore_studentid.Size = new System.Drawing.Size(258, 27);
            this.txt_showscore_studentid.TabIndex = 1;
            // 
            // btn_showscore_find
            // 
            this.btn_showscore_find.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(105)))), ((int)(((byte)(168)))));
            this.btn_showscore_find.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_showscore_find.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_showscore_find.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_showscore_find.Location = new System.Drawing.Point(597, 49);
            this.btn_showscore_find.Name = "btn_showscore_find";
            this.btn_showscore_find.Size = new System.Drawing.Size(125, 42);
            this.btn_showscore_find.TabIndex = 2;
            this.btn_showscore_find.Text = "Find";
            this.btn_showscore_find.UseVisualStyleBackColor = false;
            this.btn_showscore_find.Click += new System.EventHandler(this.btn_showscore_find_Click);
            // 
            // dtgrid_showscore_list
            // 
            this.dtgrid_showscore_list.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dtgrid_showscore_list.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgrid_showscore_list.Location = new System.Drawing.Point(54, 224);
            this.dtgrid_showscore_list.Name = "dtgrid_showscore_list";
            this.dtgrid_showscore_list.RowHeadersVisible = false;
            this.dtgrid_showscore_list.RowHeadersWidth = 51;
            this.dtgrid_showscore_list.RowTemplate.Height = 24;
            this.dtgrid_showscore_list.Size = new System.Drawing.Size(668, 369);
            this.dtgrid_showscore_list.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(50, 115);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(89, 20);
            this.label2.TabIndex = 4;
            this.label2.Text = "Semester";
            // 
            // cbb_semester
            // 
            this.cbb_semester.FormattingEnabled = true;
            this.cbb_semester.Items.AddRange(new object[] {
            "1",
            "2"});
            this.cbb_semester.Location = new System.Drawing.Point(202, 115);
            this.cbb_semester.Name = "cbb_semester";
            this.cbb_semester.Size = new System.Drawing.Size(158, 24);
            this.cbb_semester.TabIndex = 5;
            // 
            // btn_text_file
            // 
            this.btn_text_file.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(105)))), ((int)(((byte)(168)))));
            this.btn_text_file.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_text_file.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_text_file.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_text_file.Location = new System.Drawing.Point(54, 626);
            this.btn_text_file.Name = "btn_text_file";
            this.btn_text_file.Size = new System.Drawing.Size(163, 50);
            this.btn_text_file.TabIndex = 6;
            this.btn_text_file.Text = "Save to word";
            this.btn_text_file.UseVisualStyleBackColor = false;
            this.btn_text_file.Click += new System.EventHandler(this.btn_text_file_Click);
            // 
            // showscoreForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(769, 699);
            this.Controls.Add(this.btn_text_file);
            this.Controls.Add(this.cbb_semester);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dtgrid_showscore_list);
            this.Controls.Add(this.btn_showscore_find);
            this.Controls.Add(this.txt_showscore_studentid);
            this.Controls.Add(this.label1);
            this.Name = "showscoreForm";
            this.Text = "Result Of Students";
            ((System.ComponentModel.ISupportInitialize)(this.dtgrid_showscore_list)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_showscore_studentid;
        private System.Windows.Forms.Button btn_showscore_find;
        private System.Windows.Forms.DataGridView dtgrid_showscore_list;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cbb_semester;
        private System.Windows.Forms.Button btn_text_file;
    }
}