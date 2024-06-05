using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLSV_L1
{
    public partial class RegisterForm : Form
    {
        DB_Course  db_course= new DB_Course();
        DB_Score db_score = new DB_Score();
        public RegisterForm(string studentid)
        {
            InitializeComponent();
            DataTable course = db_course.Mydataset().Tables[0];
            txt_id.Text = studentid;
            txt_id.Enabled = false;

            foreach (DataRow row in course.Rows)
            {
                this.cbb_selectcourse.Items.Add(row[1].ToString());
            }


        }

        private void RegisterForm_Load(object sender, EventArgs e)
        {

        }

        private void btn_registercourse_Click(object sender, EventArgs e)
        {
           if (cbb_selectcourse.Text=="")
            {
                MessageBox.Show("Please select course");
                return;
            }
           if (db_score.existRecord(txt_id.Text,cbb_selectcourse.Text))
            {
                MessageBox.Show("Course was registered!","ERROR", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            bool x = db_score.InsertScore(txt_id.Text, cbb_selectcourse.Text, "0", "");
            if (x)
            {
                MessageBox.Show("Successful","INFORMATION",MessageBoxButtons.OK,MessageBoxIcon.Information);
                return;
            }
            MessageBox.Show("Error!", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Warning);
          
        }
    }
}
