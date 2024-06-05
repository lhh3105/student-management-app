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
    public partial class EditCourse : UserControl
    {
        DB_Course db = new DB_Course();
        public EditCourse()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btn_courseFind_Click(object sender, EventArgs e)
        {
            if (!db.existCourse(txt_courseID.Text))
            {
                MessageBox.Show("Error!ID is not existed! ");
                return;
            }
            DataTable x = db.getRecord(txt_courseID.Text).Tables[0];
            txt_courseName.Text = x.Rows[0][1].ToString();
            txt_coursePeriod.Text = x.Rows[0][2].ToString();
            rich_txt_courseDescription.Text = x.Rows[0][3].ToString();

            txt_courseName.Enabled = false;
            txt_coursePeriod.Enabled = false;
            rich_txt_courseDescription.Enabled = false;

        }

        private void btn_courseDelete_Click(object sender, EventArgs e)
        {
            try
            {
                if (!db.existCourse(txt_courseID.Text))
                {
                    MessageBox.Show("Error!ID is not existed! ");
                    return;
                }

                bool x = db.DeleteCourse(txt_courseID.Text);
                if (x)
                {
                    MessageBox.Show("Detele successfully");
                    return;
                }
                MessageBox.Show("Error!");

            }
            catch(Exception ex) { 
                MessageBox.Show(ex.Message);
            }
            
           




        }

        private void btn_courseEdit_Click(object sender, EventArgs e)
        {
            txt_courseID.Enabled = false;
            txt_courseName.Enabled = true;
            txt_coursePeriod.Enabled = true; 
            rich_txt_courseDescription.Enabled=true;


        }

        bool correctName(string name)
        {
            for (int i=0;i<name.Length; i++)
            {
                if (('a' <= name[i] && name[i] <= 'z') || ('A' <= name[i] && name[i] <= 'Z') || name[i]==' ') continue;
                return false;
            }
            return true;
        }
        bool correctPeriod(string period)
        {
            for (int i=0;i<period.Length;i++)
            {
                if ('0' <= period[i] && period[i] <= '9') continue;
                return false;
            }
            int t = int.Parse(period);
            if (t < 0 || t >= 100) return false;
            return true;

        }
        private void btn_courseSave_Click(object sender, EventArgs e)
        {
            txt_courseID.Enabled = true;
            if (!db.existCourse(txt_courseID.Text))
            {
                MessageBox.Show("ID NOT EXIST");
                txt_courseID.Enabled = true;
            }
            else
            {
                if (txt_courseID.Text == ""
               || txt_courseName.Text == ""
               || txt_coursePeriod.Text == ""
               || rich_txt_courseDescription.Text == ""
               )
                {
                    MessageBox.Show("Please fill all blank fields", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
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
                    DialogResult result = MessageBox.Show("Are you sure?", "Information", MessageBoxButtons.OKCancel);
                    if (result == DialogResult.Cancel)
                    {

                    }
                    else
                    {
                        DataSet x = db.updateRecord(txt_courseID.Text,txt_courseName.Text,txt_coursePeriod.Text,rich_txt_courseDescription.Text);
                        if (x != null)
                        {
                            MessageBox.Show("Edit successfully");

                        }
                        else
                        {
                            MessageBox.Show("Error");
                        }
                    }

                    
                }


            }
        }
    }
}
