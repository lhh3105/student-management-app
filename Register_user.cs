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
    public partial class Register_user : Form
    {
        DB_Login login = new DB_Login();
        public Register_user()
        {
            InitializeComponent();
        }


        byte[] ImageToByteArray(Image image)
        {
            MemoryStream m = new MemoryStream();
            image.Save(m, System.Drawing.Imaging.ImageFormat.Png);
            return m.ToArray();
        }
        private void btt_register_import_Click(object sender, EventArgs e)
        {
            OpenFileDialog open = new OpenFileDialog();
            if (open.ShowDialog() == DialogResult.OK)
            {
                picture_image.Image = Image.FromFile(open.FileName);

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
        private void btn_register_user_Click(object sender, EventArgs e)
        {
            if (txt_full_name.Text == ""
                || txt_username.Text == ""
                || txt_pass.Text == ""

                || txt_gmail.Text == ""
                || picture_image == null)
            {
                MessageBox.Show("Please fill all blank fields", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                
                if (!CorrectName(txt_full_name.Text))
                {
                    MessageBox.Show("Name is not valid", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
               

                try
                {
                    byte[] b = ImageToByteArray(picture_image.Image);


                    bool x = login.InsertAccount(txt_full_name.Text, txt_username.Text, txt_pass.Text, txt_gmail.Text, "Enable", b);

                    if (x)
                    {
                        MessageBox.Show("Add be successfull!");

                    }
                    else MessageBox.Show("ID student is existed!", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Warning);


                }
                catch (Exception ex)
                {
                    MessageBox.Show("ERROR: " + ex.Message);
                }

            }
        }

        private void txt_full_name_Validating(object sender, CancelEventArgs e)
        {
            
            if (txt_full_name.Text == "")
            {
                errorProvider1.SetError(txt_full_name, "Please fill blank fields");
                return;
            }
            if (!CorrectName(txt_full_name.Text))
            {
                errorProvider1.SetError(txt_full_name, "Name is not valid!");
                return;
            }
        }
    }
}
