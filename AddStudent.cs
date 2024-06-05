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
    public partial class AddStudent : UserControl
    {
        DB db = new DB();
        public AddStudent()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
        public int getAge()
        {

            DateTime birthday_text = dateTime_add_birth.Value.Date;
            DateTime today = DateTime.Today;
            int x = today.Year - birthday_text.Year;

            return x;
        }
      
        private void btn_add_add_Click(object sender, EventArgs e)
        {
            
            if (txt_add_id.Text == ""
                || txt_add_name.Text == ""
                || cbb_add_gender.Text == ""
                
                || txt_add_phone.Text == ""
                || pb_add_image == null)
            {
                MessageBox.Show("Please fill all blank fields", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                string age = getAge().ToString();
                int age1 = getAge();
                if (!(16<=age1&&age1<=99))
                {
                    MessageBox.Show("Birthday is not valid", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return; 
                }
                if (!CorrectName(txt_add_name.Text))
                {
                    MessageBox.Show("Name is not valid", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                if (!CorrectPhone(txt_add_phone.Text))
                {
                    MessageBox.Show("Phone number is not valid", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                if (!(cbb_add_gender.Text=="Male"|| cbb_add_gender.Text == "Female"|| cbb_add_gender.Text == "Others"))
                {
                    MessageBox.Show("Please select gender", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                try
                {
                    byte[] b = ImageToByteArray(pb_add_image.Image);


                    bool x = db.InsertStudent(txt_add_id.Text,
                        txt_add_name.Text,
                        cbb_add_gender.Text,
                        age,
                        txt_add_phone.Text,
                        b);
                    bool y = db.InsertBirth(txt_add_id.Text, dateTime_add_birth.Text);

                    if (x&y)
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
        byte[] ImageToByteArray(Image image)
        {
            MemoryStream m = new MemoryStream();
            image.Save(m, System.Drawing.Imaging.ImageFormat.Png);
            return m.ToArray();
        }
        private void btn_add_import_Click(object sender, EventArgs e)
        {
            OpenFileDialog open = new OpenFileDialog();
            if (open.ShowDialog() == DialogResult.OK)
            {
                pb_add_image.Image = Image.FromFile(open.FileName);

            }
        }

        private void txt_add_id_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(txt_add_id.Text))
            {
                errorProvider1.SetError(txt_add_id, "Please enter ID blank!");
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
        private void txt_add_name_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(txt_add_name.Text))
            {
                errorProvider1.SetError(txt_add_name, "Please enter Name blank!");
                return;
            }
            if (!CorrectName(txt_add_name.Text))
            {
                errorProvider1.SetError(txt_add_name, "Name is not valid");
            }
            else
            {
                errorProvider1.SetError(txt_add_name, null);

            }
        }
        private bool CorrectPhone(string phonenumber)
        {
            if (phonenumber.Length != 10) { return false; }
            foreach (char c in phonenumber)
            {
                if ('0' <= c && c <= '9') continue;
                return false;
            }


            return true;
        }

        private void txt_add_phone_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(txt_add_phone.Text))
            {
                errorProvider1.SetError(txt_add_phone, "Please enter Phone number blank!");
            }
            else
            {
                if (!CorrectPhone(txt_add_phone.Text))
                {
                    errorProvider1.SetError(txt_add_phone, "Phone number is not valid");

                }
                else
                {

                    errorProvider1.SetError(txt_add_phone, null);


                }

            }
        }

        private void dateTime_add_birth_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty (dateTime_add_birth.Text))
            {
                errorProvider1.SetError(cbb_add_gender, "Please select gender!");
            }
        }
    }
}
