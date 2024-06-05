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
    public partial class courseList : UserControl
    {
        DB_Course db = new DB_Course();
        public courseList()
        {
            InitializeComponent();
            DisplayData();
        }

        private void DisplayData()
        {
            DataTable x = db.Mydataset().Tables[0];
            dtgrid_course_list.DataSource = x;
        }
        private void btn_course_refresh_Click(object sender, EventArgs e)
        {
            DisplayData();
        }
    }
}
