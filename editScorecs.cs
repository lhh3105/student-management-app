using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLSV_L1
{
    public partial class editScorecs : Form
    {
        DB_Score db_score = new DB_Score();
        DB_Course db_course = new DB_Course();
        DB db_student = new DB();
        public editScorecs()
        {
            InitializeComponent();
        }

        private void btn_delete_score_Click(object sender, EventArgs e)
        {
            try
            {
                bool x = db_score.DeleteScore(txt_score_student_id.Text, cbb_score_course.Text);
                if (x)
                {
                    MessageBox.Show("Score is deleted!");
                }
                else
                {
                    MessageBox.Show("Error!");
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }
    }
}
