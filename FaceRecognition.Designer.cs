namespace QLSV_L1
{
    partial class FaceRecognition
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
            this.pb_face_cam = new System.Windows.Forms.PictureBox();
            this.pb_face_cap = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btn_open_cam = new System.Windows.Forms.Button();
            this.btn_cap = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pb_face_cam)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_face_cap)).BeginInit();
            this.SuspendLayout();
            // 
            // pb_face_cam
            // 
            this.pb_face_cam.Location = new System.Drawing.Point(15, 90);
            this.pb_face_cam.Name = "pb_face_cam";
            this.pb_face_cam.Size = new System.Drawing.Size(513, 383);
            this.pb_face_cam.TabIndex = 0;
            this.pb_face_cam.TabStop = false;
            // 
            // pb_face_cap
            // 
            this.pb_face_cap.Location = new System.Drawing.Point(554, 90);
            this.pb_face_cap.Name = "pb_face_cap";
            this.pb_face_cap.Size = new System.Drawing.Size(181, 160);
            this.pb_face_cap.TabIndex = 1;
            this.pb_face_cap.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 61);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(86, 20);
            this.label1.TabIndex = 2;
            this.label1.Text = "CAMERA";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(550, 61);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(95, 20);
            this.label2.TabIndex = 3;
            this.label2.Text = "CAPTURE";
            // 
            // btn_open_cam
            // 
            this.btn_open_cam.Location = new System.Drawing.Point(16, 498);
            this.btn_open_cam.Name = "btn_open_cam";
            this.btn_open_cam.Size = new System.Drawing.Size(136, 42);
            this.btn_open_cam.TabIndex = 4;
            this.btn_open_cam.Text = "Open camera";
            this.btn_open_cam.UseVisualStyleBackColor = true;
            this.btn_open_cam.Click += new System.EventHandler(this.btn_open_cam_Click);
            // 
            // btn_cap
            // 
            this.btn_cap.Location = new System.Drawing.Point(212, 498);
            this.btn_cap.Name = "btn_cap";
            this.btn_cap.Size = new System.Drawing.Size(136, 42);
            this.btn_cap.TabIndex = 5;
            this.btn_cap.Text = "Save image";
            this.btn_cap.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(392, 498);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(136, 42);
            this.button1.TabIndex = 6;
            this.button1.Text = "Detect";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // FaceRecognition
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btn_cap);
            this.Controls.Add(this.btn_open_cam);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pb_face_cap);
            this.Controls.Add(this.pb_face_cam);
            this.Name = "FaceRecognition";
            this.Size = new System.Drawing.Size(781, 615);
            ((System.ComponentModel.ISupportInitialize)(this.pb_face_cam)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_face_cap)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pb_face_cam;
        private System.Windows.Forms.PictureBox pb_face_cap;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btn_open_cam;
        private System.Windows.Forms.Button btn_cap;
        private System.Windows.Forms.Button button1;
    }
}
