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
    public partial class Dashboard : UserControl
    {
        DB db = new DB();
        public Dashboard()
        {
            InitializeComponent();
            displaycount();
        }
        public void displaycount()
        {
            int t = db.CountTotal();
            lb_student.Text = t.ToString();
        }
        public void Refreshdata()
        {
            if (InvokeRequired)
            {
                Invoke((MethodInvoker)Refreshdata);
                return;
            }
            displaycount();
        }
            private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
