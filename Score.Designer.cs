namespace QLSV_L1
{
    partial class Score
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
            this.dtgrid_score = new System.Windows.Forms.DataGridView();
            this.lb1 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_score_student_id = new System.Windows.Forms.TextBox();
            this.txt_score_score = new System.Windows.Forms.TextBox();
            this.cbb_score_course = new System.Windows.Forms.ComboBox();
            this.richtxt_score_description = new System.Windows.Forms.RichTextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btn_remove_score = new System.Windows.Forms.Button();
            this.btn_add_score = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.btn_score_refresh = new System.Windows.Forms.Button();
            this.btn_score_first = new System.Windows.Forms.Button();
            this.btn_score_last = new System.Windows.Forms.Button();
            this.btn_score_previous = new System.Windows.Forms.Button();
            this.btn_score_next = new System.Windows.Forms.Button();
            this.btn_show_score = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.dtgrid_score)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // dtgrid_score
            // 
            this.dtgrid_score.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgrid_score.Location = new System.Drawing.Point(746, 109);
            this.dtgrid_score.Name = "dtgrid_score";
            this.dtgrid_score.RowHeadersVisible = false;
            this.dtgrid_score.RowHeadersWidth = 51;
            this.dtgrid_score.RowTemplate.Height = 24;
            this.dtgrid_score.Size = new System.Drawing.Size(442, 464);
            this.dtgrid_score.TabIndex = 0;
            this.dtgrid_score.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgrid_score_CellClick);
            // 
            // lb1
            // 
            this.lb1.AutoSize = true;
            this.lb1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb1.Location = new System.Drawing.Point(296, 111);
            this.lb1.Name = "lb1";
            this.lb1.Size = new System.Drawing.Size(110, 25);
            this.lb1.TabIndex = 1;
            this.lb1.Text = "Student ID:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(269, 182);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(137, 25);
            this.label1.TabIndex = 2;
            this.label1.Text = "Select course:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(332, 271);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(70, 25);
            this.label2.TabIndex = 3;
            this.label2.Text = "Score:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(287, 328);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(115, 25);
            this.label3.TabIndex = 4;
            this.label3.Text = "Description:";
            // 
            // txt_score_student_id
            // 
            this.txt_score_student_id.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_score_student_id.Location = new System.Drawing.Point(425, 109);
            this.txt_score_student_id.Name = "txt_score_student_id";
            this.txt_score_student_id.Size = new System.Drawing.Size(225, 27);
            this.txt_score_student_id.TabIndex = 5;
            // 
            // txt_score_score
            // 
            this.txt_score_score.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_score_score.Location = new System.Drawing.Point(425, 269);
            this.txt_score_score.Name = "txt_score_score";
            this.txt_score_score.Size = new System.Drawing.Size(225, 27);
            this.txt_score_score.TabIndex = 6;
            // 
            // cbb_score_course
            // 
            this.cbb_score_course.FormattingEnabled = true;
            this.cbb_score_course.Location = new System.Drawing.Point(425, 182);
            this.cbb_score_course.Name = "cbb_score_course";
            this.cbb_score_course.Size = new System.Drawing.Size(225, 24);
            this.cbb_score_course.TabIndex = 7;
            // 
            // richtxt_score_description
            // 
            this.richtxt_score_description.Location = new System.Drawing.Point(425, 332);
            this.richtxt_score_description.Name = "richtxt_score_description";
            this.richtxt_score_description.Size = new System.Drawing.Size(225, 144);
            this.richtxt_score_description.TabIndex = 8;
            this.richtxt_score_description.Text = "";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(105)))), ((int)(((byte)(168)))));
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.btn_show_score);
            this.panel1.Controls.Add(this.btn_remove_score);
            this.panel1.Controls.Add(this.btn_add_score);
            this.panel1.Location = new System.Drawing.Point(0, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(252, 658);
            this.panel1.TabIndex = 11;
            // 
            // btn_remove_score
            // 
            this.btn_remove_score.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_remove_score.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_remove_score.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_remove_score.Location = new System.Drawing.Point(31, 342);
            this.btn_remove_score.Name = "btn_remove_score";
            this.btn_remove_score.Size = new System.Drawing.Size(191, 50);
            this.btn_remove_score.TabIndex = 14;
            this.btn_remove_score.Text = "Remove score";
            this.btn_remove_score.UseVisualStyleBackColor = true;
            this.btn_remove_score.Click += new System.EventHandler(this.btn_remove_score_Click);
            // 
            // btn_add_score
            // 
            this.btn_add_score.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_add_score.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_add_score.ForeColor = System.Drawing.Color.Snow;
            this.btn_add_score.Location = new System.Drawing.Point(31, 244);
            this.btn_add_score.Name = "btn_add_score";
            this.btn_add_score.Size = new System.Drawing.Size(191, 50);
            this.btn_add_score.TabIndex = 13;
            this.btn_add_score.Text = "Add score";
            this.btn_add_score.UseVisualStyleBackColor = true;
            this.btn_add_score.Click += new System.EventHandler(this.btn_add_score_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(472, 22);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(178, 29);
            this.label4.TabIndex = 12;
            this.label4.Text = "Manage score";
            // 
            // btn_score_refresh
            // 
            this.btn_score_refresh.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(105)))), ((int)(((byte)(168)))));
            this.btn_score_refresh.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_score_refresh.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_score_refresh.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_score_refresh.Location = new System.Drawing.Point(1042, 54);
            this.btn_score_refresh.Name = "btn_score_refresh";
            this.btn_score_refresh.Size = new System.Drawing.Size(146, 37);
            this.btn_score_refresh.TabIndex = 13;
            this.btn_score_refresh.Text = "Refresh";
            this.btn_score_refresh.UseVisualStyleBackColor = false;
            this.btn_score_refresh.Click += new System.EventHandler(this.btn_score_refresh_Click);
            // 
            // btn_score_first
            // 
            this.btn_score_first.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(105)))), ((int)(((byte)(168)))));
            this.btn_score_first.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_score_first.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_score_first.Location = new System.Drawing.Point(274, 531);
            this.btn_score_first.Name = "btn_score_first";
            this.btn_score_first.Size = new System.Drawing.Size(90, 42);
            this.btn_score_first.TabIndex = 14;
            this.btn_score_first.Text = "First";
            this.btn_score_first.UseVisualStyleBackColor = false;
            this.btn_score_first.Click += new System.EventHandler(this.btn_score_first_Click);
            // 
            // btn_score_last
            // 
            this.btn_score_last.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(105)))), ((int)(((byte)(168)))));
            this.btn_score_last.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_score_last.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_score_last.Location = new System.Drawing.Point(613, 531);
            this.btn_score_last.Name = "btn_score_last";
            this.btn_score_last.Size = new System.Drawing.Size(98, 42);
            this.btn_score_last.TabIndex = 15;
            this.btn_score_last.Text = "Last";
            this.btn_score_last.UseVisualStyleBackColor = false;
            this.btn_score_last.Click += new System.EventHandler(this.btn_score_last_Click);
            // 
            // btn_score_previous
            // 
            this.btn_score_previous.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(105)))), ((int)(((byte)(168)))));
            this.btn_score_previous.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_score_previous.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_score_previous.Location = new System.Drawing.Point(387, 531);
            this.btn_score_previous.Name = "btn_score_previous";
            this.btn_score_previous.Size = new System.Drawing.Size(90, 42);
            this.btn_score_previous.TabIndex = 16;
            this.btn_score_previous.Text = "Previous";
            this.btn_score_previous.UseVisualStyleBackColor = false;
            this.btn_score_previous.Click += new System.EventHandler(this.btn_score_previous_Click);
            // 
            // btn_score_next
            // 
            this.btn_score_next.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(105)))), ((int)(((byte)(168)))));
            this.btn_score_next.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_score_next.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_score_next.Location = new System.Drawing.Point(496, 531);
            this.btn_score_next.Name = "btn_score_next";
            this.btn_score_next.Size = new System.Drawing.Size(90, 42);
            this.btn_score_next.TabIndex = 17;
            this.btn_score_next.Text = "Next";
            this.btn_score_next.UseVisualStyleBackColor = false;
            this.btn_score_next.Click += new System.EventHandler(this.btn_score_next_Click);
            // 
            // btn_show_score
            // 
            this.btn_show_score.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_show_score.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_show_score.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_show_score.Location = new System.Drawing.Point(31, 441);
            this.btn_show_score.Name = "btn_show_score";
            this.btn_show_score.Size = new System.Drawing.Size(191, 50);
            this.btn_show_score.TabIndex = 15;
            this.btn_show_score.Text = "Show average score";
            this.btn_show_score.UseVisualStyleBackColor = true;
            this.btn_show_score.Click += new System.EventHandler(this.btn_show_score_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::QLSV_L1.Properties.Resources.job_symbol_on_student_flat_vector_15947972;
            this.pictureBox1.Location = new System.Drawing.Point(58, 63);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(134, 120);
            this.pictureBox1.TabIndex = 16;
            this.pictureBox1.TabStop = false;
            // 
            // Score
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1219, 662);
            this.Controls.Add(this.btn_score_next);
            this.Controls.Add(this.btn_score_previous);
            this.Controls.Add(this.btn_score_last);
            this.Controls.Add(this.btn_score_first);
            this.Controls.Add(this.btn_score_refresh);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.richtxt_score_description);
            this.Controls.Add(this.cbb_score_course);
            this.Controls.Add(this.txt_score_score);
            this.Controls.Add(this.txt_score_student_id);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lb1);
            this.Controls.Add(this.dtgrid_score);
            this.Name = "Score";
            this.Text = "Score";
            ((System.ComponentModel.ISupportInitialize)(this.dtgrid_score)).EndInit();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dtgrid_score;
        private System.Windows.Forms.Label lb1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txt_score_student_id;
        private System.Windows.Forms.TextBox txt_score_score;
        private System.Windows.Forms.ComboBox cbb_score_course;
        private System.Windows.Forms.RichTextBox richtxt_score_description;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btn_add_score;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btn_score_refresh;
        private System.Windows.Forms.Button btn_remove_score;
        private System.Windows.Forms.Button btn_score_first;
        private System.Windows.Forms.Button btn_score_last;
        private System.Windows.Forms.Button btn_score_previous;
        private System.Windows.Forms.Button btn_score_next;
        private System.Windows.Forms.Button btn_show_score;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}