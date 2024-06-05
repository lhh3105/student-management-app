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
    public partial class Admin : UserControl
    {
        DB_Login db_login = new DB_Login();
        public Admin()
        {
            InitializeComponent();
            ShowData();
        }

        public void ShowData()
        {
            DataTable dt = db_login.Mydataset().Tables["admin1"];
            dtgrid_staff.DataSource = dt;
            dtgrid_staff.Columns[0].HeaderCell.Value = "Full name";
            dtgrid_staff.Columns[1].HeaderCell.Value = "Username";
            dtgrid_staff.Columns[2].HeaderCell.Value = "Password";
            dtgrid_staff.Columns[3].HeaderCell.Value = "Email";
            dtgrid_staff.Columns[4].HeaderCell.Value = "Status";


        }

        private void btn_refresh_Click(object sender, EventArgs e)
        {
            ShowData();
        }

        private void btn_save_Click(object sender, EventArgs e)
        {
            
            DataSet x = db_login.updateRecord(txt_fullname.Text,txt_username.Text,txt_pass.Text,txt_email.Text,cbb_status.Text);
            MessageBox.Show("Successfull!","INFORMATION",MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        private void Display(int rowindex)
        {
            txt_fullname.Text = dtgrid_staff.Rows[rowindex].Cells[0].Value.ToString();
            txt_username.Text = dtgrid_staff.Rows[rowindex].Cells[1].Value.ToString();
            txt_pass.Text = dtgrid_staff.Rows[rowindex].Cells[2].Value.ToString();
            txt_email.Text = dtgrid_staff.Rows[rowindex].Cells[3].Value.ToString();
            cbb_status.Text = dtgrid_staff.Rows[rowindex].Cells[4].Value.ToString();
        }
        private void dtgrid_staff_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int rowindex = dtgrid_staff.CurrentCell.RowIndex;
            Display(rowindex);
        }
    }
}
