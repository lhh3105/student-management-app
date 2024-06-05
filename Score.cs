using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace QLSV_L1
{
    public partial class Score : Form
    {
        DB_Score db_score = new DB_Score();
        DB_Course db_course = new DB_Course();
        DB db_student = new DB();
        int rowindex = 0;

        public Score()
        {
            InitializeComponent();
            btn_score_previous.Enabled = false;

            DataTable course = db_course.Mydataset().Tables[0];
            DataTable score = db_score.Mydataset().Tables[0];
            

            foreach (DataRow row in course.Rows)
            {
                this.cbb_score_course.Items.Add(row[1].ToString());
            }
            dtgrid_score.DataSource = score;
            dtgrid_score.Columns[0].HeaderCell.Value = "Student ID";
            dtgrid_score.Columns[1].HeaderCell.Value = "Course Name";
            dtgrid_score.Columns[2].HeaderCell.Value = "Period";
            dtgrid_score.Columns[3].HeaderCell.Value = "Description";
        }

        private void btn_score_add_Click(object sender, EventArgs e)
        {
            try
            {
                if (!db_student.existStudent(txt_score_student_id.Text))
                {
                    MessageBox.Show("Error! Student is not existed");
                    return;
                }
                if (!db_course.existCourseByName(cbb_score_course.Text))
                {
                    MessageBox.Show("Error! Course is not existed");
                    return;
                }
                db_score.InsertScore(txt_score_student_id.Text, cbb_score_course.Text, txt_score_score.Text, richtxt_score_description.Text);
                MessageBox.Show("Score is added!");
            }
            catch(Exception ex)
            {
                MessageBox.Show("ERROR: " + ex.Message);
            }
            
        }
        private void DisplayScore(int rowindex)
        {
            DataTable dt = db_score.Mydataset().Tables[0];
            txt_score_student_id.Text = dt.Rows[rowindex][0].ToString();
            cbb_score_course.Text = dt.Rows[rowindex][1].ToString();
            txt_score_score.Text = dt.Rows[rowindex][2].ToString();
            richtxt_score_description.Text = dt.Rows[rowindex][3].ToString();

        }

        

        private void dtgrid_score_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int row = dtgrid_score.CurrentCell.RowIndex;
            DisplayScore(row);
        }

        private void btn_score_remove_Click(object sender, EventArgs e)
        {
            try
            {
                bool x = db_score.DeleteScore(txt_score_student_id.Text, cbb_score_course.Text);
                if (x)
                {
                    MessageBox.Show("Score is deleted!","Information",MessageBoxButtons.OK,MessageBoxIcon.Information);
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

        private void btn_score_show_scores_Click(object sender, EventArgs e)
        {

        }

        private void btn_add_score_Click(object sender, EventArgs e)
        {
            AddScore x = new AddScore(); 
            x.ShowDialog();
        }

        private void btn_score_refresh_Click(object sender, EventArgs e)
        {
            DataTable score = db_score.Mydataset().Tables[0];
            dtgrid_score.DataSource = score;
        }

        private void btn_remove_score_Click(object sender, EventArgs e)
        {
            RemoveScore x = new RemoveScore(); 
            x.ShowDialog(); 
        }

        public void updatePointer()
        {

            DataTable dt = db_score.Mydataset().Tables["score"];
            if (dt.Rows.Count - 1 == rowindex) btn_score_next.Enabled = false;
            else btn_score_next.Enabled = true;
            if (0 == rowindex) btn_score_previous.Enabled = false;
            else btn_score_previous.Enabled = true;
        }


        private void btn_score_previous_Click(object sender, EventArgs e)
        {
            rowindex--;

            DataTable dt = db_score.Mydataset().Tables["score"];
            if (rowindex == 0)
            {
                MessageBox.Show("This is the first score!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                DisplayScore(rowindex);
                updatePointer();
                btn_score_previous.Enabled = false;
                return;

            }
            DisplayScore(rowindex);
            updatePointer();
        }

        private void btn_score_first_Click(object sender, EventArgs e)
        {
            rowindex = 0;
            DisplayScore(rowindex);
            updatePointer();
        }

        private void btn_score_next_Click(object sender, EventArgs e)
        {
            rowindex++;

            DataTable dt = db_score.Mydataset().Tables["score"];
            if (rowindex == dt.Rows.Count - 1)
            {
                MessageBox.Show("This is the last student!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                DisplayScore(rowindex);
                btn_score_next.Enabled = false;
                updatePointer();

                return;

            }
            DisplayScore(rowindex);
            updatePointer();
        }

        private void btn_score_last_Click(object sender, EventArgs e)
        {
            DataTable dt = db_score.Mydataset().Tables["score"];
            rowindex = dt.Rows.Count-1 ;
            DisplayScore(rowindex);
            updatePointer();
        }

        private void btn_show_score_Click(object sender, EventArgs e)
        {
            showscoreForm x = new showscoreForm();
            x.ShowDialog();
        }
    }
}
