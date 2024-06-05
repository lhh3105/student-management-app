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
    public partial class EditContact : Form
    {
        DB_Contact contact = new DB_Contact();
        DB_group db_group = new DB_group();
        public EditContact()
        {
            InitializeComponent();
            List<string> list = new List<string>();
            DataTable dt = db_group.Mydataset().Tables[0];
            foreach (DataRow dr in dt.Rows)
            {
                list.Add(dr["name"].ToString());
            }
            cbb_editcontact_group.DataSource = list;
        }


        byte[] ImageToByteArray(Image image)
        {
            MemoryStream m = new MemoryStream();
            image.Save(m, System.Drawing.Imaging.ImageFormat.Png);
            return m.ToArray();
        }
        private void btt_editcontact_edit_Click(object sender, EventArgs e)
        {

            try
            {
                
                byte[] b = ImageToByteArray(picture_editcontact.Image);

                DataSet ds = contact.updateRecord(txt_editcontact_id.Text, txt_editcontact_name.Text, cbb_editcontact_group.Text, txt_editcontact_phone.Text, txt_editcontact_email.Text, b);
                MessageBox.Show("Successfull!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);


            }
            catch (Exception ex)
            {
                MessageBox.Show("ERROR: " + ex.Message);
            }
            
        }

        private void btt_editcontact_import_Click(object sender, EventArgs e)
        {
            OpenFileDialog open = new OpenFileDialog();
            if (open.ShowDialog() == DialogResult.OK)
            {
                picture_editcontact.Image = Image.FromFile(open.FileName);

            }
        }

        private void btn_editcontact_find_Click(object sender, EventArgs e)
        {
            if(txt_editcontact_id.Text == "")
            {
                MessageBox.Show("Please add id", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                string id = txt_editcontact_id.Text;
                if (!contact.existContact(id))
                {
                    MessageBox.Show("ID NOT EXIST", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    txt_editcontact_name.Text = string.Empty;
                    txt_editcontact_phone.Text = string.Empty;
                    txt_editcontact_email.Text = string.Empty;
                    picture_editcontact.Image = null;


                    DataTable x = contact.getRecord(id).Tables[0];
                    
                    txt_editcontact_name.Text = x.Rows[0][1].ToString();
                    
                    cbb_editcontact_group.Text = x.Rows[0][2].ToString();
                    txt_editcontact_phone.Text = x.Rows[0][3].ToString();
                    txt_editcontact_email.Text = x.Rows[0][4].ToString();
                    MemoryStream ms = new MemoryStream((byte[])(x.Rows[0][5]));
                    Image im = Image.FromStream(ms);
                    picture_editcontact.Image = im;

                    



                }
            }
        }
    }
}
