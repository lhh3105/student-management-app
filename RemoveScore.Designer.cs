namespace QLSV_L1
{
    partial class RemoveScore
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
            this.dtgrid_remove_list = new System.Windows.Forms.DataGridView();
            this.btn_remove_remove = new System.Windows.Forms.Button();
            this.btn_remove_refresh = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dtgrid_remove_list)).BeginInit();
            this.SuspendLayout();
            // 
            // dtgrid_remove_list
            // 
            this.dtgrid_remove_list.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dtgrid_remove_list.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgrid_remove_list.Location = new System.Drawing.Point(27, 67);
            this.dtgrid_remove_list.Name = "dtgrid_remove_list";
            this.dtgrid_remove_list.RowHeadersVisible = false;
            this.dtgrid_remove_list.RowHeadersWidth = 51;
            this.dtgrid_remove_list.RowTemplate.Height = 24;
            this.dtgrid_remove_list.Size = new System.Drawing.Size(761, 368);
            this.dtgrid_remove_list.TabIndex = 0;
            // 
            // btn_remove_remove
            // 
            this.btn_remove_remove.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(105)))), ((int)(((byte)(168)))));
            this.btn_remove_remove.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_remove_remove.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_remove_remove.Location = new System.Drawing.Point(27, 451);
            this.btn_remove_remove.Name = "btn_remove_remove";
            this.btn_remove_remove.Size = new System.Drawing.Size(151, 47);
            this.btn_remove_remove.TabIndex = 1;
            this.btn_remove_remove.Text = "Remove";
            this.btn_remove_remove.UseVisualStyleBackColor = false;
            this.btn_remove_remove.Click += new System.EventHandler(this.btn_remove_remove_Click);
            // 
            // btn_remove_refresh
            // 
            this.btn_remove_refresh.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(105)))), ((int)(((byte)(168)))));
            this.btn_remove_refresh.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_remove_refresh.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_remove_refresh.Location = new System.Drawing.Point(637, 14);
            this.btn_remove_refresh.Name = "btn_remove_refresh";
            this.btn_remove_refresh.Size = new System.Drawing.Size(151, 47);
            this.btn_remove_refresh.TabIndex = 2;
            this.btn_remove_refresh.Text = "Refresh";
            this.btn_remove_refresh.UseVisualStyleBackColor = false;
            this.btn_remove_refresh.Click += new System.EventHandler(this.btn_remove_refresh_Click);
            // 
            // RemoveScore
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(818, 520);
            this.Controls.Add(this.btn_remove_refresh);
            this.Controls.Add(this.btn_remove_remove);
            this.Controls.Add(this.dtgrid_remove_list);
            this.Name = "RemoveScore";
            this.Text = "RemoveScore";
            ((System.ComponentModel.ISupportInitialize)(this.dtgrid_remove_list)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dtgrid_remove_list;
        private System.Windows.Forms.Button btn_remove_remove;
        private System.Windows.Forms.Button btn_remove_refresh;
    }
}