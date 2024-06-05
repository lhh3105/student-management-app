using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net;
using System.Net.Mail;

namespace QLSV_L1
{
    public partial class SignUp_Form : Form
    {
        DB_Login db_login = new DB_Login();
        private string code = "";
        int time = 60;
        public SignUp_Form()
        {
            InitializeComponent();
            txt_email.Text = "huuhuy1122334455@gmail.com";

            txt_full_name.Enabled = false;
            txt_username.Enabled = false;
            txt_pass.Enabled = false;
            txt_repass.Enabled = false;

            btn_cancel_signup.Enabled = false;
            btn_createAccount.Enabled = false;
        }

        private void btn_sendCode_Click(object sender, EventArgs e)
        {
            if (txt_email.Text == "")
            {
                MessageBox.Show("Please add your Email");
                return;

            }
            if (db_login.existEmail(txt_email.Text))
            {
                MessageBox.Show("Error! Email already used, please enter another email");
                return;
            }
            string from, to, pass, messageBody;
            Random random = new Random();
            string randomCode = (random.Next(999999)).ToString();
            code = randomCode;
            MailMessage message = new MailMessage();
            to = txt_email.Text;
            from = "21110471@student.hcmute.edu.vn";
            pass = "huy31052003";
            messageBody = "Code: " + randomCode;
            message.To.Add(to);
            message.From = new MailAddress(from);
            message.Body = messageBody;
            message.Subject = "Account creation code";
            SmtpClient smtp = new SmtpClient("smtp.gmail.com");
            smtp.EnableSsl = true;
            smtp.Port = 587;
            smtp.DeliveryMethod = SmtpDeliveryMethod.Network;
            
            smtp.Credentials = new NetworkCredential(from, pass);
            try
            {
                smtp.Send(message);
                MessageBox.Show("Code send sucessfully", "Code", MessageBoxButtons.OK, MessageBoxIcon.Information);
                


            }
            catch (Exception ex)
            {
                MessageBox.Show("ERROR: " + ex.Message, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }

        private void btn_getcode_Click(object sender, EventArgs e)
        {
            if (txt_code.Text=="")
            {
                MessageBox.Show("Please enter the code");
                return;
            }
           
            if (txt_code.Text!=code)
            {
                MessageBox.Show("ERROR!Code is not correct!","ERROR",MessageBoxButtons.OK,MessageBoxIcon.Warning);
                return;
            }
            MessageBox.Show("Code is correct!Verifying is successful");
            txt_username.Enabled = true;
            txt_pass.Enabled = true;
            txt_repass.Enabled = true;
            txt_full_name.Enabled = true;
            btn_cancel_signup.Enabled = true;
            btn_createAccount.Enabled = true;



        }

        private void btn_createAccount_Click(object sender, EventArgs e)
        {
            
            
        }

        private void lbl_signup_destroy_MouseClick(object sender, MouseEventArgs e)
        {
            this.Hide();
        }

        private void lbl_signup_destroy_Click(object sender, EventArgs e)
        {

        }
    }
}
