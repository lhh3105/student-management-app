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
    public partial class LoginForm : Form
    {
        DB_Login db_login = new DB_Login();
        public LoginForm()
        {
            InitializeComponent();
            
        }

        private void txt_login_username_TextChanged(object sender, EventArgs e)
        {

        }

        private bool CorrectAdmin()
        {
            if (txt_login_username.Text!="huuhuy") return false;
            if (txt_login_password.Text!="123") return false;
            return true;
        }
        private void btn_login_Click(object sender, EventArgs e)
        {
            try
            {
                if (radiobtn_admin.Checked)
                {
                    if (CorrectAdmin())
                    {
                        DialogResult res = MessageBox.Show("Login be successful! Enter the System", "INFORMATION", MessageBoxButtons.OKCancel);
                        if (res == DialogResult.OK)
                        {
                            //this.Hide();
                            MainForm mainForm = new MainForm();
                            if (radiobtn_admin.Checked)
                            {
                                mainForm.IsAdmin = 1;
                            }
                            mainForm.checkadmin();
                            mainForm.ShowDialog();
                        }
                    }
                    else
                    {
                        MessageBox.Show("Username or password not correct!", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    return;
                }

                if (radiobtn_human_resourse.Checked)
                {
                    if (txt_login_username.Text == "" || txt_login_password.Text == "")
                    {
                        MessageBox.Show("Please fill the blank fiels!", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);

                    }
                    else
                    {
                        if (db_login.existUser(txt_login_username.Text))
                        {
                            if (db_login.exactUser(txt_login_username.Text, txt_login_password.Text))
                            {
                                bool permiss = db_login.HavePermission(txt_login_username.Text, txt_login_password.Text);
                                if (!permiss)
                                {
                                    MessageBox.Show("Error!You don't have permission to access!", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                                    return;
                                }
                                DialogResult res = MessageBox.Show("Login be successful! Enter the System", "INFORMATION", MessageBoxButtons.OKCancel);
                                if (res == DialogResult.OK)
                                {
                                    DataSet x = db_login.getRecord(txt_login_username.Text, txt_login_password.Text);
                                    DataTable user = x.Tables[0];
                                    string fullname = user.Rows[0][0].ToString();
                                    string gmail = user.Rows[0][3].ToString();

                                    MemoryStream ms = new MemoryStream((byte[])(user.Rows[0][5]));
                                    Image im = Image.FromStream(ms);
                                    

                                    Contact contact = new Contact(fullname, gmail,im);
                                    

                                    contact.ShowDialog();
                                    
                                }

                            }
                            else
                            {
                                MessageBox.Show("Username or password not correct!", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                        }
                        else
                        {
                            MessageBox.Show("Username not exist!", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                    return;
                }

                if (txt_login_username.Text == "" || txt_login_password.Text == "")
                {
                    MessageBox.Show("Please fill the blank fiels!", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }
                else
                {
                    if (db_login.existUser(txt_login_username.Text))
                    {
                        if (db_login.exactUser(txt_login_username.Text, txt_login_password.Text))
                        {
                            bool permiss = db_login.HavePermission(txt_login_username.Text, txt_login_password.Text);
                            if (!permiss)
                            {
                                MessageBox.Show("Error!You don't have permission to access!", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                                return;
                            }
                            DialogResult res = MessageBox.Show("Login be successful! Enter the System", "INFORMATION", MessageBoxButtons.OKCancel);
                            if (res == DialogResult.OK)
                            {
                                //this.Hide();
                                MainForm mainForm = new MainForm();
                                if (radiobtn_admin.Checked)
                                {
                                    mainForm.IsAdmin = 1;
                                }
                                mainForm.checkadmin();
                                mainForm.ShowDialog();
                            }

                        }
                        else
                        {
                            MessageBox.Show("Username or password not correct!", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                    else
                    {
                        MessageBox.Show("Username not exist!", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("ERROR: " + ex.Message, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void checkb_login_CheckedChanged(object sender, EventArgs e)
        {
            txt_login_password.PasswordChar = checkb_login.Checked ? '\0' : '*';
        }

        private void txt_login_username_Validating(object sender, CancelEventArgs e)
        {
            
            if (string.IsNullOrEmpty(txt_login_username.Text))
            {
              
                errorProvider1.SetError(txt_login_username, "Please enter your user name!");
            }
            else
            {
                
                {
                    if (txt_login_username.Text.Length < 4)
                    {
                       
                       
                        errorProvider1.SetError(txt_login_username, "Username must have at least 4 characters");

                    }
                    else
                    {
                        if (txt_login_username.Text == "huuhuy") return;
                        if (!db_login.existUser(txt_login_username.Text))
                        {
                           
                            
                            errorProvider1.SetError(txt_login_username, "Username is not exist!");
                        }
                        else
                        {
                       
                            errorProvider1.SetError(txt_login_username, null);
                        }

                    }
                }
        

            }
        }

        private void txt_login_password_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(txt_login_password.Text))
            {
                
                txt_login_username.Focus();
                errorProvider1.SetError(txt_login_password, "Please enter your password!");
            }
            else
            {
                if (CorrectAdmin())
                {
                    
                    errorProvider1.SetError(txt_login_password, null);
                    return;
                }
                if (txt_login_username.Text == "huuhuy") return;
                if (txt_login_password.Text.Length < 4)
                {
                   
                    txt_login_username.Focus();
                    errorProvider1.SetError(txt_login_password, "Password must have at least 4 characters!");
                }
                else
                {
                    
                    errorProvider1.SetError(txt_login_password, null);
                }
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {

        }

        private void btn_sign_up_Click(object sender, EventArgs e)
        {
            Register_user x = new Register_user();
            x.ShowDialog();
        }
    }
}
