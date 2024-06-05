using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLSV_L1
{
    public partial class AddContact : Form
    {
        DB_Contact db = new DB_Contact();
        DB_group db_group = new DB_group();
        public AddContact()
        {
            InitializeComponent();
            List <string > list  = new List<string>();
            DataTable dt = db_group.Mydataset().Tables[0];
            foreach (DataRow dr in dt.Rows)
            {
                list.Add(dr["name"].ToString());
            }
            cbb_addcontact_group.DataSource = list;
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }


        byte[] ImageToByteArray(Image image)
        {
            MemoryStream m = new MemoryStream();
            image.Save(m, System.Drawing.Imaging.ImageFormat.Png);
            return m.ToArray();
        }
        private void btt_addcontact_import_Click(object sender, EventArgs e)
        {
            OpenFileDialog open = new OpenFileDialog();
            if (open.ShowDialog() == DialogResult.OK)
            {
                picture_addcontact.Image = Image.FromFile(open.FileName);

            }
        }
        private bool CorrectName(string name)
        {
            if (name.Length <= 1) { return false; }
            foreach (char c in name)
            {
                if ('0' <= c && c <= '9') return false;

            }


            return true;
        }
        private void btt_addcontact_add_Click(object sender, EventArgs e)
        {

            if (txt_addcontact_id.Text == ""
                || txt_addcontact_name.Text == ""
                || cbb_addcontact_group.Text == ""

                || txt_addcontact_phone.Text == ""
                || txt_addcontact_email.Text == ""
                || picture_addcontact.Image == null)
            {
                MessageBox.Show("Please fill all blank fields", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (!CorrectName(txt_addcontact_name.Text))
            {
                MessageBox.Show("Name is not valid", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            try
            {
                byte[] b = ImageToByteArray(picture_addcontact.Image);


                bool x = db.InsertContact(txt_addcontact_id.Text,
                    txt_addcontact_name.Text,
                    cbb_addcontact_group.Text,
                    txt_addcontact_phone.Text,
                    txt_addcontact_email.Text,
                    b);
                if (!x)
                {
                    MessageBox.Show("Contact is existed!", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    MessageBox.Show("Successfull!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }


            }
            catch (Exception ex)
            {
                MessageBox.Show("ERROR: " + ex.Message);
            }
        }
    }
}
