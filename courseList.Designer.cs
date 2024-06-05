namespace QLSV_L1
{
    partial class courseList
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_course_refresh = new System.Windows.Forms.Button();
            this.dtgrid_course_list = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dtgrid_course_list)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(39, 54);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(145, 29);
            this.label1.TabIndex = 1;
            this.label1.Text = "Course List";
            // 
            // btn_course_refresh
            // 
            this.btn_course_refresh.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(105)))), ((int)(((byte)(168)))));
            this.btn_course_refresh.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_course_refresh.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_course_refresh.Location = new System.Drawing.Point(427, 54);
            this.btn_course_refresh.Name = "btn_course_refresh";
            this.btn_course_refresh.Size = new System.Drawing.Size(146, 38);
            this.btn_course_refresh.TabIndex = 2;
            this.btn_course_refresh.Text = "Refresh";
            this.btn_course_refresh.UseVisualStyleBackColor = false;
            this.btn_course_refresh.Click += new System.EventHandler(this.btn_course_refresh_Click);
            // 
            // dtgrid_course_list
            // 
            this.dtgrid_course_list.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dtgrid_course_list.DefaultCellStyle = dataGridViewCellStyle1;
            this.dtgrid_course_list.Location = new System.Drawing.Point(44, 136);
            this.dtgrid_course_list.Name = "dtgrid_course_list";
            this.dtgrid_course_list.RowHeadersVisible = false;
            this.dtgrid_course_list.RowHeadersWidth = 51;
            this.dtgrid_course_list.RowTemplate.Height = 24;
            this.dtgrid_course_list.Size = new System.Drawing.Size(529, 529);
            this.dtgrid_course_list.TabIndex = 3;
            // 
            // courseList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Controls.Add(this.dtgrid_course_list);
            this.Controls.Add(this.btn_course_refresh);
            this.Controls.Add(this.label1);
            this.Name = "courseList";
            this.Size = new System.Drawing.Size(638, 683);
            ((System.ComponentModel.ISupportInitialize)(this.dtgrid_course_list)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_course_refresh;
        private System.Windows.Forms.DataGridView dtgrid_course_list;
    }
}
