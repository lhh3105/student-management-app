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
   
    public partial class RemoveScore : Form
    {
        DB_Score db_score = new DB_Score();
        DB_Course db_course = new DB_Course();
        DB db_student = new DB();

        
        public RemoveScore()
        {
            InitializeComponent();
            dtgrid_remove_list.DataSource = db_score.Mydataset1().Tables[0];
            dtgrid_remove_list.Columns[0].HeaderCell.Value = "Student ID";
            dtgrid_remove_list.Columns[1].HeaderCell.Value = "Student Name";
            dtgrid_remove_list.Columns[2].HeaderCell.Value = "Course Name";
            dtgrid_remove_list.Columns[3].HeaderCell.Value = "Period";
            dtgrid_remove_list.Columns[4].HeaderCell.Value = "Description";
        }

        private void btn_remove_remove_Click(object sender, EventArgs e)
        {
            int rowindex = dtgrid_remove_list.CurrentCell.RowIndex;
           /* try
            {
               
            }
            catch(Exception ex)
            {
                MessageBox.Show("ERROR! "+ ex.Message);
            }*/

            string stdid = dtgrid_remove_list.Rows[rowindex].Cells[0].Value.ToString();
            string coursename = dtgrid_remove_list.Rows[rowindex].Cells[2].Value.ToString();
            Console.WriteLine(stdid);
            Console.WriteLine(coursename);
            bool x = db_score.DeleteScore(stdid, coursename);
            if (x)
            {
                MessageBox.Show("Successfull! "+stdid+" and "+coursename, "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else MessageBox.Show("Fail!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        private void btn_remove_refresh_Click(object sender, EventArgs e)
        {
            dtgrid_remove_list.DataSource = db_score.Mydataset1().Tables[0];
            dtgrid_remove_list.Columns[0].HeaderCell.Value = "Student ID";
            dtgrid_remove_list.Columns[1].HeaderCell.Value = "Student Name";
            dtgrid_remove_list.Columns[2].HeaderCell.Value = "Course Name";
            dtgrid_remove_list.Columns[3].HeaderCell.Value = "Period";
            dtgrid_remove_list.Columns[4].HeaderCell.Value = "Description";
        }
    }
}
