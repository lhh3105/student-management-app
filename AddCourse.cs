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
    public partial class AddCourse : UserControl
    {
        DB_Course db= new DB_Course();
        DB_Score score= new DB_Score();
        public AddCourse()
        {
            InitializeComponent();
        }

        bool correctName(string name)
        {
            for (int i = 0; i < name.Length; i++)
            {
                if (('a' <= name[i] && name[i] <= 'z') || ('A' <= name[i] && name[i] <= 'Z') || name[i] == ' ') continue;
                return false;
            }
            return true;
        }
        bool correctPeriod(string period)
        {
            for (int i = 0; i < period.Length; i++)
            {
                if ('0' <= period[i] && period[i] <= '9') continue;
                return false;
            }
            int t = int.Parse(period);
            if (t < 0 || t >= 100) return false;
            return true;

        }

        private void btn_addCourse_Click(object sender, EventArgs e)
        {
            try
            {
                if (txt_courseID.Text == ""
              || txt_courseName.Text == ""
              || txt_coursePeriod.Text == ""
              || rich_txt_description.Text == ""
              )
                {
                    MessageBox.Show("Please fill all blank fields", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                if (!correctName(txt_courseName.Text))
                {
                    MessageBox.Show("Name is not correct!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                if (!correctPeriod(txt_coursePeriod.Text))
                {
                    MessageBox.Show("Period is not suitable!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                bool x = db.InsertCourse(txt_courseID.Text,txt_courseName.Text,txt_coursePeriod.Text,rich_txt_description.Text);
                
                if (x)
                {
                    MessageBox.Show("Adding Sucessfully");
                }
                else
                {
                    MessageBox.Show("Error! Course is existed!");
                }
            }
            catch (Exception ex )
            { MessageBox.Show("Error: "+ ex.Message); }

        }
    }
}
