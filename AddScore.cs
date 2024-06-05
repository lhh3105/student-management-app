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
    public partial class AddScore : Form
    {
        DB_Score db_score = new DB_Score();
        DB_Course db_course = new DB_Course();
        DB db_student = new DB();
        public AddScore()
        {
            InitializeComponent();
            DataTable course = db_course.Mydataset().Tables[0];
            

            foreach (DataRow row in course.Rows)
            {
                this.cbb_score_course.Items.Add(row[1].ToString());
            }
            
        }
        private bool correctScore(string score)
        {
            if (score.Length>1) return false;
            if ('0' <= score[0] && score[0] <= '9') return true;
            return false;
        }
        private void btn_add_score_Click(object sender, EventArgs e)
        {
            try
            {
                if (txt_score_student_id.Text==""||txt_score_score.Text==""||cbb_score_course.Text==""||richtxt_score_description.Text=="")
                {
                    MessageBox.Show("Please enter blank fields!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                if (!correctScore(txt_score_score.Text))    
                {
                    MessageBox.Show("Error! Score is not suitable!","Error",MessageBoxButtons.OK,MessageBoxIcon.Warning);
                    return;
                }
                if (!db_student.existStudent(txt_score_student_id.Text))
                {
                    MessageBox.Show("Error! Student is not existed", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                if (!db_course.existCourseByName(cbb_score_course.Text))
                {
                    MessageBox.Show("Error! Course is not existed","Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                if (db_score.existRecord(txt_score_student_id.Text,txt_score_score.Text))
                {
                    bool added = db_score.updateRecord(txt_score_student_id.Text, cbb_score_course.Text, txt_score_score.Text, richtxt_score_description.Text);
                    
                }else db_score.InsertScore(txt_score_student_id.Text, cbb_score_course.Text, txt_score_score.Text, richtxt_score_description.Text);
                MessageBox.Show("Score is added!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show("ERROR: " + ex.Message);
            }
        }
    }
}
