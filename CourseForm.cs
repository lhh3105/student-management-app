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
    public partial class CourseForm : Form
    {
        public CourseForm()
        {
            InitializeComponent();
            editCourse1.Visible = false;
            addCourse1.Visible = false;
            courseList2.Visible = true;
        }

        private void btn_Edit_Click(object sender, EventArgs e)
        {
            courseList2.Visible = false;
            addCourse1.Visible = false;
            editCourse1.Visible = true;
      
        }

        private void btn_add_course_Click(object sender, EventArgs e)
        {
            courseList2.Visible=false; 
            editCourse1.Visible = false;
            addCourse1.Visible = true;
        }

        private void editCourse1_Load(object sender, EventArgs e)
        {
            
        }

        private void btn_course_list_Click(object sender, EventArgs e)
        {
            
            editCourse1.Visible = false;
            addCourse1.Visible = false;
            courseList2.Visible = true;
        }

        private void courseList2_Load(object sender, EventArgs e)
        {

        }
    }
}
