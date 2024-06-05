namespace QLSV_L1
{
    partial class ScoreByCourse
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
            this.dtgrid_scorebycourse = new System.Windows.Forms.DataGridView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lb_gv = new System.Windows.Forms.Label();
            this.lb_course = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.cbb_semester = new System.Windows.Forms.ComboBox();
            this.btn_ok = new System.Windows.Forms.Button();
            this.btn_save = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dtgrid_scorebycourse)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dtgrid_scorebycourse
            // 
            this.dtgrid_scorebycourse.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dtgrid_scorebycourse.ColumnHeadersHeight = 29;
            this.dtgrid_scorebycourse.Location = new System.Drawing.Point(55, 260);
            this.dtgrid_scorebycourse.Name = "dtgrid_scorebycourse";
            this.dtgrid_scorebycourse.RowHeadersVisible = false;
            this.dtgrid_scorebycourse.RowHeadersWidth = 51;
            this.dtgrid_scorebycourse.RowTemplate.Height = 24;
            this.dtgrid_scorebycourse.Size = new System.Drawing.Size(673, 393);
            this.dtgrid_scorebycourse.TabIndex = 0;
            this.dtgrid_scorebycourse.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgrid_scorebycourse_CellContentClick);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(105)))), ((int)(((byte)(168)))));
            this.panel1.Controls.Add(this.lb_course);
            this.panel1.Controls.Add(this.lb_gv);
            this.panel1.Location = new System.Drawing.Point(0, 1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(803, 158);
            this.panel1.TabIndex = 1;
            // 
            // lb_gv
            // 
            this.lb_gv.AutoSize = true;
            this.lb_gv.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_gv.ForeColor = System.Drawing.Color.White;
            this.lb_gv.Location = new System.Drawing.Point(26, 22);
            this.lb_gv.Name = "lb_gv";
            this.lb_gv.Size = new System.Drawing.Size(245, 29);
            this.lb_gv.TabIndex = 5;
            this.lb_gv.Text = "Create new Account";
            // 
            // lb_course
            // 
            this.lb_course.AutoSize = true;
            this.lb_course.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_course.ForeColor = System.Drawing.Color.White;
            this.lb_course.Location = new System.Drawing.Point(26, 78);
            this.lb_course.Name = "lb_course";
            this.lb_course.Size = new System.Drawing.Size(189, 25);
            this.lb_course.TabIndex = 6;
            this.lb_course.Text = "Create new Account";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(50, 190);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(107, 25);
            this.label1.TabIndex = 7;
            this.label1.Text = "Semester: ";
            // 
            // cbb_semester
            // 
            this.cbb_semester.FormattingEnabled = true;
            this.cbb_semester.Items.AddRange(new object[] {
            "1",
            "2"});
            this.cbb_semester.Location = new System.Drawing.Point(188, 191);
            this.cbb_semester.Name = "cbb_semester";
            this.cbb_semester.Size = new System.Drawing.Size(144, 24);
            this.cbb_semester.TabIndex = 8;
            // 
            // btn_ok
            // 
            this.btn_ok.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(105)))), ((int)(((byte)(168)))));
            this.btn_ok.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_ok.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_ok.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_ok.Location = new System.Drawing.Point(396, 184);
            this.btn_ok.Name = "btn_ok";
            this.btn_ok.Size = new System.Drawing.Size(102, 34);
            this.btn_ok.TabIndex = 18;
            this.btn_ok.Text = "OK";
            this.btn_ok.UseVisualStyleBackColor = false;
            this.btn_ok.Click += new System.EventHandler(this.btn_ok_Click);
            // 
            // btn_save
            // 
            this.btn_save.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(105)))), ((int)(((byte)(168)))));
            this.btn_save.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_save.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_save.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_save.Location = new System.Drawing.Point(55, 674);
            this.btn_save.Name = "btn_save";
            this.btn_save.Size = new System.Drawing.Size(160, 42);
            this.btn_save.TabIndex = 19;
            this.btn_save.Text = "Save to Word";
            this.btn_save.UseVisualStyleBackColor = false;
            this.btn_save.Click += new System.EventHandler(this.btn_save_Click);
            // 
            // ScoreByCourse
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(800, 742);
            this.Controls.Add(this.btn_save);
            this.Controls.Add(this.btn_ok);
            this.Controls.Add(this.cbb_semester);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.dtgrid_scorebycourse);
            this.Name = "ScoreByCourse";
            this.Text = "ScoreByCourse";
            this.Load += new System.EventHandler(this.ScoreByCourse_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtgrid_scorebycourse)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dtgrid_scorebycourse;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lb_gv;
        private System.Windows.Forms.Label lb_course;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbb_semester;
        private System.Windows.Forms.Button btn_ok;
        private System.Windows.Forms.Button btn_save;
    }
}