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
    public partial class MainForm : Form
    {
        public int IsAdmin = 0;
        public MainForm()
        {
            InitializeComponent();
            student_List1.Visible = false;
            search_student1.Visible = false;
            addStudent1.Visible = false;
            admin1.Visible = false;
            dashboard1.Visible = true;
            
            
        }
        public void checkadmin()
        {
            if (IsAdmin == 0)
            {
                btn_admin.Enabled = false;
            }
            else btn_admin.Enabled = true;
        }
       
        private void btn_dashboard_Click(object sender, EventArgs e)
        {
            student_List1.Visible = false;
            search_student1.Visible = false;
            addStudent1.Visible = false;
            admin1.Visible = false;
            dashboard2.Visible = true;

            Dashboard dashboard = dashboard1 as Dashboard;

            if (dashboard !=null)
            {
                dashboard.Refreshdata();
            }
        }

        private void btn_Studentlist_Click(object sender, EventArgs e)
        {
            dashboard2.Visible=false;
            search_student1.Visible=false;
            addStudent1 .Visible=false;
            admin1 .Visible=false;
            student_List1.Visible=true;
        }

        private void label2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void student_List1_Load(object sender, EventArgs e)
        {
           
        }

        private void btn_search_Click(object sender, EventArgs e)
        {
            dashboard2.Visible = false;
            student_List1.Visible = false;
            addStudent1.Visible = false;
            admin1.Visible = false;
            search_student1.Visible = true;
            

        }

        private void btn_add_Click(object sender, EventArgs e)
        {
            dashboard2.Visible = false;
            student_List1.Visible = false;
            search_student1.Visible = false;
            admin1.Visible = false;
            addStudent1.Visible = true;
        }

        private void addStudent1_Load(object sender, EventArgs e)
        {

        }

        private void btn_admin_Click(object sender, EventArgs e)
        {
            dashboard2.Visible = false;
            student_List1.Visible = false;
            search_student1.Visible = false;
            addStudent1.Visible = false;
            admin1.Visible = true;
        }

        private void btn_course_Click(object sender, EventArgs e)
        {
            CourseForm x = new CourseForm();   
            x.ShowDialog();
        }

        private void btn_print_Click(object sender, EventArgs e)
        {
            printForm x = new printForm(); 
            x.ShowDialog();
        }

        private void btn_score_Click(object sender, EventArgs e)
        {
            Score x = new Score(); 
            x.ShowDialog();
        }

        private void admin1_Load(object sender, EventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
