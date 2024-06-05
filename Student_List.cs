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
    
    public partial class Student_List : UserControl
    {
        DB db = new DB();
        DB_Score db_score = new DB_Score(); 
        int rowindex = 0;
        public Student_List()
        {
            InitializeComponent();
            loadData();
            DisplayStudent(rowindex);
            DisplayCourse(rowindex);
        }
        public DataTable getData()
        {
            DataTable dtt = new DataTable();
            DataTable tm = db.Mydataset().Tables["student"];
            DataTable ns = db.data_birthday().Tables["ngaysinh"];
            DataTable score = db_score.Mydataset().Tables["score"];
            DataTable dt_student = new DataTable();
            tm.Columns.Remove(tm.Columns[5]);
            tm.Columns.Remove(tm.Columns[3]);
            DataColumn Col = tm.Columns.Add("Birth Day");
            Col.SetOrdinal(2);
            for (int i = 0; i < tm.Rows.Count; i++)
            {
                for (int j=0;j<tm.Rows.Count; j++)
                {
                    if (tm.Rows[i]["id"].ToString() == ns.Rows[j]["id"].ToString())
                    {
                        tm.Rows[i]["Birth Day"] = ns.Rows[j]["birthday"];
                        break;
                    }
                }

               

            }

            dtt = tm;
            return dtt;
        }

        public void loadData()
        {
            DataTable dt = getData();
            dtgrid_student.DataSource = dt;
            
            

            btn_dt_add.Enabled = false;
            btn_dt_add.Hide();
            txt_dt_age.Enabled = false;
            txt_dt_age.Clear();


            txt_dt_id.Enabled = true;
            txt_dt_name.Enabled = false;
            datetime_birthday.Enabled = false;
            cbb_dt_gender.Enabled = false;
            txt_dt_phone.Enabled = false;
            btn_dt_import_image.Enabled = false;


            txt_dt_age.Text = getAge().ToString();
            updatePointer();

        }
        public int getAge()
        {
            
            DateTime birthday_text = datetime_birthday.Value.Date;
            DateTime today = DateTime.Today;
            int x = today.Year-birthday_text.Year;

            return x;
        }
        public bool check()
        {
            if (cbb_dt_gender.Text != "Male" && cbb_dt_gender.Text != "Female" && cbb_dt_gender.Text != "Others")
            { MessageBox.Show("Please select gender"); return false; }
            int myage = int.Parse(txt_dt_age.Text);
            if (myage > 22 || myage < 18)
            { MessageBox.Show("AGE is not suitable"); return false; }

            return true;
        }

        private void btn_dt_add_Click(object sender, EventArgs e)
        {
            byte[] b = ImageToByteArray(pb_dt_image.Image);
            if (txt_dt_id.Text == ""
                || txt_dt_name.Text == ""
                || cbb_dt_gender.Text == ""
                || txt_dt_age.Text == ""
                || txt_dt_phone.Text == ""
                || pb_dt_image == null)
            {
                MessageBox.Show("Please fill all blank fields", "Error Message",MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                string age = "";
                try
                {
                    bool x = db.InsertStudent(txt_dt_id.Text,
                        txt_dt_name.Text,
                        cbb_dt_gender.Text,
                        age,
                        txt_dt_phone.Text,
                        b); ;
                    if (x)
                    {
                        MessageBox.Show("Add be successfull!");
                        updatePointer();
                    }
                    else MessageBox.Show("ID student is existed!", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Warning);


                }
                catch (Exception ex)
                {
                    MessageBox.Show("ERROR: " + ex.Message);
                }
                loadData();
            }

        }
        byte[] ImageToByteArray(Image image)
        {
            MemoryStream m = new MemoryStream();
            image.Save(m, System.Drawing.Imaging.ImageFormat.Png);
            return m.ToArray();
        }
        private void DisplayStudent(int rowindex)
        {

            txt_dt_id.Enabled = true;
            txt_dt_name.Enabled = false;
            datetime_birthday.Enabled = false;
            cbb_dt_gender.Enabled = false;
            txt_dt_phone.Enabled = false;
            btn_dt_import_image.Enabled = false;

            DataTable dt = getData();
            DataTable dt1 = db.Mydataset().Tables["student"];
            txt_dt_id.Text = dt.Rows[rowindex][0].ToString();
            txt_dt_name.Text = dt.Rows[rowindex][1].ToString();
      
            //txt_dt_age.Text = dt.Rows[rowindex][3].ToString();

            datetime_birthday.Value = DateTime.ParseExact(dt.Rows[rowindex][2].ToString(), "dd/MM/yyyy", CultureInfo.InvariantCulture);

            cbb_dt_gender.Text = dt.Rows[rowindex][3].ToString();
            txt_dt_age.Text = getAge().ToString();
            txt_dt_phone.Text = dt.Rows[rowindex][4].ToString();
            MemoryStream ms = new MemoryStream((byte[])(dt1.Rows[rowindex][5]));
            Image im = Image.FromStream(ms);
            pb_dt_image.Image = im;



        }
        private void DisplayCourse(int rowindex)
        {
            string s = dtgrid_student.Rows[rowindex].Cells[0].Value.ToString();
            List<string> x = db_score.getCourseByStudentID(s);
            listbox_course.DataSource = x;
        }
        public void updatePointer()
        {

            DataTable dt = db.Mydataset().Tables["student"];
            if (dt.Rows.Count - 1 == rowindex) btn_search_right.Enabled = false;
            else btn_search_right.Enabled = true;
            if (0 == rowindex) btn_search_left.Enabled = false;
            else btn_search_left.Enabled = true;
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

        private void txt_dt_age_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(txt_dt_age.Text))
            {
                btn_dt_add.Enabled = false;
                btn_dt_import_image.Enabled = false;
                btn_studentlist_edit.Enabled = false;
                btn_studentlist_save.Enabled = false;
                e.Cancel = true;
                txt_dt_age.Focus();
                errorProvider1.SetError(txt_dt_age, "Please enter age blank!");
            }
            else
            {
               
               
                    btn_dt_add.Enabled = false;
                    btn_dt_import_image.Enabled = true;
                    btn_studentlist_edit.Enabled = true;
                    btn_studentlist_save.Enabled = true;
                    e.Cancel = false;
                    errorProvider1.SetError(txt_dt_age, null);
                    

                

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
        private void txt_dt_phone_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(txt_dt_phone.Text))
            {
                btn_dt_add.Enabled = false;
                btn_dt_import_image.Enabled = false;
                btn_studentlist_edit.Enabled = false;
                btn_studentlist_save.Enabled = false;
                e.Cancel = true;
                txt_dt_phone.Focus();
                errorProvider1.SetError(txt_dt_phone, "Please enter Phone number blank!");
            }
            else
            {
                if (!CorrectPhone(txt_dt_phone.Text))
                {
                    btn_dt_add.Enabled = false;
                    btn_dt_import_image.Enabled = false;
                    btn_studentlist_edit.Enabled = false;
                    btn_studentlist_save.Enabled = false;
                    e.Cancel = true;
                    txt_dt_phone.Focus();
                    errorProvider1.SetError(txt_dt_phone, "Phone number is not valid");

                }
                else
                {
                    btn_dt_add.Enabled = true;
                    btn_dt_import_image.Enabled = true;
                    btn_studentlist_edit.Enabled = true;
                    btn_studentlist_save.Enabled = true;
                    e.Cancel = false;
                    errorProvider1.SetError(txt_dt_phone, null);


                }

            }
        }

        private void btn_studentlist_edit_Click(object sender, EventArgs e)
        {
            txt_dt_id.Enabled = false;
            if (txt_dt_id.Text == "")
            {
                MessageBox.Show("Please add id!");
                txt_dt_id.Enabled = true;
            }
            else
            {
                if (!db.existStudent(txt_dt_id.Text))
                {
                    MessageBox.Show("ID NOT EXIST");
                    txt_dt_id.Enabled = true;
                }
                else
                {
                    txt_dt_id.Enabled = false;
                    txt_dt_name.Enabled = true;
                    cbb_dt_gender.Enabled = true;;
                    txt_dt_phone.Enabled = true;
                    btn_dt_import_image.Enabled = true;
                    datetime_birthday.Enabled = true;

                }
            }
        }
        public bool CorrectBirthday()
        {
            DateTime birthday = datetime_birthday.Value;
            DateTime today = DateTime.Today;
            int kc = today.Year - birthday.Year;
            if (16 <= kc && kc <= 99) return true;
            return false;
        }
        private void btn_studentlist_save_Click(object sender, EventArgs e)
        {
            if (txt_dt_id.Text == ""
             || txt_dt_name.Text == ""
             || cbb_dt_gender.Text == ""
             || txt_dt_age.Text == ""
             || txt_dt_phone.Text == ""
             || pb_dt_image == null)
            {
                MessageBox.Show("Please fill all blank fields", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (!CorrectBirthday())
            {
                MessageBox.Show("Birthday is not correct!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            DialogResult result = MessageBox.Show("Are you sure?", "Information", MessageBoxButtons.OKCancel,MessageBoxIcon.Information);
            if (result == DialogResult.Cancel)
            {

            }
            else
            {
               
                byte[] b = ImageToByteArray(pb_dt_image.Image);
                DataSet dss = db.updateRecord(txt_dt_id.Text, txt_dt_name.Text, cbb_dt_gender.Text, txt_dt_age.Text, txt_dt_phone.Text, b);
                DataSet birth = db.updateBirthday(txt_dt_id.Text,datetime_birthday.Text);
                MessageBox.Show("Update sucessfull");
            }
            txt_dt_id.Enabled = true;
            txt_dt_name.Enabled = false;
            datetime_birthday.Enabled=false;
            cbb_dt_gender.Enabled=false;
            txt_dt_phone.Enabled=false;
            btn_dt_import_image.Enabled=false;
        }

        private void btn_dt_import_image_Click(object sender, EventArgs e)
        {
            OpenFileDialog open = new OpenFileDialog();
            if (open.ShowDialog() == DialogResult.OK)
            {
                pb_dt_image.Image = Image.FromFile(open.FileName);

            }
        }
        private bool CorrectName(string name)
        {
            if (name.Length<=1 ) { return false; }
            foreach (char c in name)
            {
                if ('0' <= c && c <= '9') return false;
                
            }


            return true;
        }
        private void txt_dt_name_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(txt_dt_name.Text))
            {
                btn_dt_add.Enabled = false;
                btn_dt_import_image.Enabled = false;
                btn_studentlist_edit.Enabled = false;
                btn_studentlist_save.Enabled = false;
                e.Cancel = true;
                txt_dt_name.Focus();
                errorProvider1.SetError(txt_dt_name, "Please enter Name blank!");
            }
            else
            {
                if (!CorrectName(txt_dt_name.Text))
                {
                    btn_dt_add.Enabled = false;
                    btn_dt_import_image.Enabled = false;
                    btn_studentlist_edit.Enabled = false;
                    btn_studentlist_save.Enabled = false;
                    e.Cancel = true;
                    txt_dt_name.Focus();
                    errorProvider1.SetError(txt_dt_name, "Name is not valid");

                }
                else
                {
                    btn_dt_add.Enabled = false;
                    btn_dt_import_image.Enabled = true;
                    btn_studentlist_edit.Enabled = true;
                    btn_studentlist_save.Enabled = true;
                    e.Cancel = false;
                    errorProvider1.SetError(txt_dt_name, null);


                }

            }
        }

        private void btn_dt_refresh_Click(object sender, EventArgs e)
        {
            loadData();
            DisplayStudent(rowindex);
            DisplayCourse(rowindex);
        }

        private void btn_search_right_Click(object sender, EventArgs e)
        {
            rowindex++;

            DataTable dt = db.Mydataset().Tables["student"];
            if (rowindex == dt.Rows.Count - 1)
            {
                MessageBox.Show("This is the last student!");
                DisplayStudent(rowindex);
                updatePointer();

                return;

            }
            DisplayStudent(rowindex);
            DisplayCourse(rowindex);
            updatePointer();
        }

        private void btn_search_left_Click(object sender, EventArgs e)
        {
            rowindex--;

            DataTable dt = db.Mydataset().Tables["student"];
            if (rowindex == 0)
            {
                MessageBox.Show("This is the first student!");
                DisplayStudent(rowindex);
                updatePointer();
                btn_search_left.Enabled = false;
                return;

            }
            DisplayStudent(rowindex);
            DisplayCourse(rowindex);
            updatePointer();
        }

        private void dtgrid_student_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int row = dtgrid_student.CurrentCell.RowIndex;
            DisplayStudent(row);
            DisplayCourse(row);
        }

        private void txt_dt_age_TextChanged(object sender, EventArgs e)
        {

        }

        private void dtgrid_student_DoubleClick(object sender, EventArgs e)
        {
            int row = dtgrid_student.CurrentCell.RowIndex;
            DataGridViewRow selectedRow = dtgrid_student.Rows[row];
            string studentID = selectedRow.Cells[0].Value.ToString();
            RegisterForm registerForm = new RegisterForm(studentID);
            registerForm.ShowDialog(); // Show as modal to prevent interaction with main form until registration form is closed
        }
    }


    
}
