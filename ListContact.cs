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
    public partial class ListContact : Form
    {
        DB_group group = new DB_group();
        DB_Contact contact = new DB_Contact();  
        public ListContact()
        {
            InitializeComponent();
            List<string> list = new List<string>();

            DataTable dt = group.Mydataset().Tables[0];
            foreach (DataRow dr in dt.Rows)
            {
                list.Add(dr["name"].ToString());

            }
            listbox_group.DataSource = list;

            
        }

        private void ListContact_Load(object sender, EventArgs e)
        {

        }

        private void listbox_group_DoubleClick(object sender, EventArgs e)
        {
            string selectedItem = listbox_group.Items[listbox_group.SelectedIndex].ToString();
            DataTable x = contact.FilterByGroup(selectedItem).Tables[0];
            dtgrid_contact.DataSource = x;

            dtgrid_contact.Columns[0].HeaderCell.Value = "Contact ID";
            dtgrid_contact.Columns[1].HeaderCell.Value = "Name";
            dtgrid_contact.Columns[2].HeaderCell.Value = "Group Name";
            dtgrid_contact.Columns[3].HeaderCell.Value = "Phone";
            dtgrid_contact.Columns[4].HeaderCell.Value = "Email";

            dtgrid_contact.Columns[1].Width = 100;


        }

        private void dtgrid_contact_DoubleClick(object sender, EventArgs e)
        {
            int row = dtgrid_contact.CurrentCell.RowIndex;
            DataGridViewRow selectedRow = dtgrid_contact.Rows[row];
            string teacherID = selectedRow.Cells[1].Value.ToString();
            CourseOfTeacher x = new CourseOfTeacher(teacherID);
            x.ShowDialog();
        }
    }
}
