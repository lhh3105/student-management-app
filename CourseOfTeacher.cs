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
    public partial class CourseOfTeacher : Form
    {
        DB_Contact contact = new DB_Contact();
        public CourseOfTeacher(string name)
        {
            InitializeComponent();
            txt_teachername.Text = name;
            listbox_course.DataSource = contact.getCourseByTeacher(name);
        }

        private void CourseOfTeacher_Load(object sender, EventArgs e)
        {

        }

        private void listbox_course_DoubleClick(object sender, EventArgs e)
        {
            string selectedItem = listbox_course.Items[listbox_course.SelectedIndex].ToString();
            ScoreByCourse x=  new ScoreByCourse(txt_teachername.Text,selectedItem);
            x.ShowDialog();
            
        }
    }
}
