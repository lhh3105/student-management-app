using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLSV_L1
{
    public partial class Search_student : UserControl
    {
        DB db = new DB();
        public Search_student()
        {
            InitializeComponent();
            txt_search_age.Enabled = false;
        }

        public DataTable getData()
        {
            DataTable dtt = new DataTable();
            DataTable tm = db.Mydataset().Tables["student"];
            DataTable ns = db.data_birthday().Tables["ngaysinh"];
            DataTable dt_student = new DataTable();
            tm.Columns.Remove(tm.Columns[5]);
            tm.Columns.Remove(tm.Columns[3]);
            DataColumn Col = tm.Columns.Add("Birth Day");
            Col.SetOrdinal(2);
            for (int i = 0; i < tm.Rows.Count; i++)
            {
                tm.Rows[i]["Birth Day"] = ns.Rows[i]["birthday"];

            }

            dtt = tm;
            return dtt;
        }
        
         public int getAge()
        {
            
            DateTime birthday_text = datetime_birthday_search.Value.Date;
            DateTime today = DateTime.Today;
            int x = today.Year-birthday_text.Year;

            return x;
        }
        private void btn_search_find_Click(object sender, EventArgs e)
        {
            if (txt_search_id.Text == "")
            {
                MessageBox.Show("Please add id","ERROR",MessageBoxButtons.OK,MessageBoxIcon.Warning);
            }
            else
            {
                string id = txt_search_id.Text;
                if (!db.existStudent(id))
                {
                    MessageBox.Show("ID NOT EXIST", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    txt_search_name.Text = string.Empty;
                    txt_search_age.Text = string.Empty;
                    txt_search_phone_number.Text = string.Empty;
                    pbs1.Image = null;


                    DataTable x = db.getRecord(id).Tables["student"];
                    DataTable y = db.getBirthday(txt_search_id.Text).Tables["ngaysinh"];
                    txt_search_name.Text = x.Rows[0][1].ToString();
                    datetime_birthday_search.Value = DateTime.ParseExact(y.Rows[0][1].ToString(), "dd/MM/yyyy", CultureInfo.InvariantCulture);
                    cbb_search_gender.Text = x.Rows[0][2].ToString();
                    txt_search_age.Text = getAge().ToString();
                    txt_search_phone_number.Text = x.Rows[0][4].ToString();
                    MemoryStream ms = new MemoryStream((byte[])(x.Rows[0][5]));
                    Image im = Image.FromStream(ms);
                    pbs1.Image = im;

                    txt_search_name.Enabled = false;
                    txt_search_age.Enabled = false;
                    cbb_search_gender.Enabled = false;
                    txt_search_phone_number.Enabled = false;
                    btn_search_import.Enabled = false;
                    datetime_birthday_search.Enabled = false;



                }
            }
        }

        private void btn_search_delete_Click(object sender, EventArgs e)
        {
            if (txt_search_id.Text == "")
            {
                MessageBox.Show("Please add id", "ERROR MESSAGE", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                string id = txt_search_id.Text;
                if (!db.existStudent(id))
                {
                    MessageBox.Show("ID NOT EXIST!","ERROR MESSAGE",MessageBoxButtons.OK,MessageBoxIcon.Warning);
                }
                else
                {
                    try
                    {
                        bool b = db.DeleteStudent(txt_search_id.Text);
                        if (b)
                        {
                            MessageBox.Show("DELETE BE SUCCESSFULL");
                        }
                        else
                        {
                            MessageBox.Show("ERROR!");
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("ERROR: " + ex.Message);
                    }
                }

            }
        }

        private void btn_search_import_Click(object sender, EventArgs e)
        {
            OpenFileDialog open = new OpenFileDialog();
            if (open.ShowDialog() == DialogResult.OK)
            {
                pbs1.Image = Image.FromFile(open.FileName);

            }
        }
        byte[] ImageToByteArray(Image image)
        {
            MemoryStream m = new MemoryStream();
            image.Save(m, System.Drawing.Imaging.ImageFormat.Png);
            return m.ToArray();
        }

        private void btn_search_edit_Click(object sender, EventArgs e)
        {
            txt_search_id.Enabled = false;
            if (txt_search_id.Text == "")
            {
                MessageBox.Show("Please add id!");
                txt_search_id.Enabled = true;
            }
            else
            {
                if (!db.existStudent(txt_search_id.Text))
                {
                    MessageBox.Show("ID NOT EXIST");
                    txt_search_id.Enabled = true;
                }
                else
                {
                    txt_search_id.Enabled = false;
                    txt_search_name.Enabled = true;
                    cbb_search_gender.Enabled = true;
                    txt_search_age.Enabled = true;
                    txt_search_phone_number.Enabled = true;
                    btn_search_import.Enabled = true;
                    datetime_birthday_search.Enabled = true;

                }
            }

        }
        public bool CorrectBirthday()
        {
            DateTime birthday = datetime_birthday_search.Value;
            DateTime today = DateTime.Today;
            int kc = today.Year - birthday.Year;
            if (16 <= kc && kc <= 99) return true;
            return false;
        }
        private void btn_search_ok_Click(object sender, EventArgs e)
        {
            if (!db.existStudent(txt_search_id.Text))
            {
                MessageBox.Show("ID NOT EXIST");
                txt_search_id.Enabled = true ;
            }
            else
            {
                if (txt_search_id.Text == ""
               || txt_search_name.Text == ""
               || cbb_search_gender.Text == ""
               || txt_search_age.Text == ""
               || txt_search_phone_number.Text == ""
               || pbs1 == null)
                {
                    MessageBox.Show("Please fill all blank fields", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    if (!CorrectBirthday())
                    {
                        MessageBox.Show("Birthday is not correct!","Error",MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }
                    DialogResult result = MessageBox.Show("Are you sure?", "Information", MessageBoxButtons.OKCancel);
                    if (result == DialogResult.Cancel)
                    {

                    }
                    else
                    {
                        byte[] b = ImageToByteArray(pbs1.Image);
                        DataSet dss = db.updateRecord(txt_search_id.Text, txt_search_name.Text, cbb_search_gender.Text, txt_search_age.Text, txt_search_phone_number.Text, b);
                        DataSet birth = db.updateBirthday(txt_search_id.Text, datetime_birthday_search.Text);
                        MessageBox.Show("Update sucessfull","Information",MessageBoxButtons.OK,MessageBoxIcon.Information);
                    }

                    txt_search_name.Enabled = false;
                    cbb_search_gender.Enabled = false;
                    txt_search_age.Enabled = false;
                    txt_search_phone_number.Enabled = false;
                    btn_search_import.Enabled = false;
                    txt_search_id.Enabled = true;
                }

                
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
        private void txt_search_name_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(txt_search_name.Text))
            {
                btn_search_ok.Enabled = false;
                btn_search_edit.Enabled = false;
                btn_search_delete.Enabled = false;
                btn_search_find.Enabled = false;
                btn_search_import.Enabled = false;
                e.Cancel = true;
                txt_search_name.Focus();
                errorProvider1.SetError(txt_search_name, "Please enter Name blank!");
            }
            else
            {
                if (!CorrectName(txt_search_name.Text))
                {
                    btn_search_ok.Enabled = false;
                    btn_search_edit.Enabled = false;
                    btn_search_delete.Enabled = false;
                    btn_search_find.Enabled = false;
                    btn_search_import.Enabled = false;
                    e.Cancel = true;
                    txt_search_name.Focus();
                    errorProvider1.SetError(txt_search_name, "Name is not valid");

                }
                else
                {
                    btn_search_ok.Enabled = true;
                    btn_search_edit.Enabled = true;
                    btn_search_delete.Enabled = true;
                    btn_search_find.Enabled = true;
                    btn_search_import.Enabled = true;
                    e.Cancel = false;
                    errorProvider1.SetError(txt_search_name, null);


                }

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
        private bool CorrectAge(string age)
        {
            if (age.Length != 2) { return false; }
            foreach (char c in age)
            {
                if ('0' <= c && c <= '9') continue;
                return false;
            }
            if (age[0] == '0') return false;

            return true;
        }
        private void txt_search_age_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(txt_search_age.Text))
            {
                btn_search_ok.Enabled = false;
                btn_search_edit.Enabled = false;
                btn_search_delete.Enabled = false;
                btn_search_find.Enabled = false;
                btn_search_import.Enabled = false;
                e.Cancel = true;
                txt_search_age.Focus();
                errorProvider1.SetError(txt_search_age, "Please enter age blank!");
            }
            else
            {
                if (!CorrectAge(txt_search_age.Text))
                {
                    btn_search_ok.Enabled = false;
                    btn_search_edit.Enabled = false;
                    btn_search_delete.Enabled = false;
                    btn_search_find.Enabled = false;
                    btn_search_import.Enabled = false;
                    e.Cancel = true;
                    txt_search_age.Focus();
                    errorProvider1.SetError(txt_search_age, "Age is not valid");

                }
                else
                {
                    btn_search_ok.Enabled = true;
                    btn_search_edit.Enabled = true;
                    btn_search_delete.Enabled = true;
                    btn_search_find.Enabled = true;
                    btn_search_import.Enabled = true;
                    e.Cancel = false;
                    errorProvider1.SetError(txt_search_age, null);


                }

            }
        }

        private void txt_search_phone_number_Validating(object sender, CancelEventArgs e)
        {

            if (string.IsNullOrEmpty(txt_search_phone_number.Text))
            {
                btn_search_ok.Enabled = false;
                btn_search_edit.Enabled = false;
                btn_search_delete.Enabled = false;
                btn_search_find.Enabled = false;
                btn_search_import.Enabled = false;
                e.Cancel = true;
                txt_search_phone_number.Focus();
                errorProvider1.SetError(txt_search_phone_number, "Please enter phone number blank!");
            }
            else
            {
                if (!CorrectPhone(txt_search_phone_number.Text))
                {
                    btn_search_ok.Enabled = false;
                    btn_search_edit.Enabled = false;
                    btn_search_delete.Enabled = false;
                    btn_search_find.Enabled = false;
                    btn_search_import.Enabled = false;
                    e.Cancel = true;
                    txt_search_phone_number.Focus();
                    errorProvider1.SetError(txt_search_phone_number, "Phone number is not valid");

                }
                else
                {
                    btn_search_ok.Enabled = true;
                    btn_search_edit.Enabled = true;
                    btn_search_delete.Enabled = true;
                    btn_search_find.Enabled = true;
                    btn_search_import.Enabled = true;
                    e.Cancel = false;
                    errorProvider1.SetError(txt_search_phone_number, null);


                }

            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}