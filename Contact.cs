using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace QLSV_L1
{
    public partial class Contact : Form
    {
        DB_Contact contact = new DB_Contact();
        DB_group group  = new DB_group();
        public Contact(string name,string gmail, Image b)
        {
            InitializeComponent();
            this.lbl_name.Text = name;
            this.lbl_gmail.Text = gmail;
            this.pbb_user_image.Image = b;

            List<string> list = new List<string>();
           
            DataTable dt = group.Mydataset().Tables[0];
            foreach (DataRow dr in dt.Rows)
            {
                list.Add(dr["name"].ToString());
                
            }
            cbb_group_select.DataSource = list;
            cbb_group_remove.DataSource = list;


        }

        private void Display()
        {
            

            List<string> list = new List<string>();

            DataTable dt = group.Mydataset().Tables[0];
            foreach (DataRow dr in dt.Rows)
            {
                list.Add(dr["name"].ToString());

            }
            cbb_group_select.DataSource = list;
            cbb_group_remove.DataSource = list;
        }

        private void Contact_Load(object sender, EventArgs e)
        {

        }

        private void btn_contact_add_Click(object sender, EventArgs e)
        {
            AddContact addContact = new AddContact();
            addContact.ShowDialog();
        }

        private void btn_contact_edit_Click(object sender, EventArgs e)
        {
            EditContact editContact = new EditContact();
            editContact.ShowDialog();   
        }

        private void btn_contact_remove_Click(object sender, EventArgs e)
        {
            if (txt_contact_id.Text == "")
            {
                MessageBox.Show("Please add id", "ERROR MESSAGE", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                string id = txt_contact_id.Text;
                if (!contact.existContact(id))
                {
                    MessageBox.Show("ID NOT EXIST!", "ERROR MESSAGE", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    try
                    {
                        bool b = contact.DeleteContact(txt_contact_id.Text);
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

        private void btn_group_add_Click(object sender, EventArgs e)
        {
            if (txt_group_name.Text == "")
            {
                MessageBox.Show("Please add Group name", "ERROR MESSAGE", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                string id = txt_group_name.Text;
                if (contact.existContact(id))
                {
                    MessageBox.Show("Group name is existed!", "ERROR MESSAGE", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    try
                    {
                        bool b = group.InsertGroup(txt_group_name.Text);
                        if (b)
                        {
                            MessageBox.Show("ADD BE SUCCESSFULL");
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

        private void button1_Click(object sender, EventArgs e)
        {
            if (txt_contact_newname.Text == "")
            {
                MessageBox.Show("Please add new name", "ERROR MESSAGE", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                
               
                    try
                    {
                        DataSet b = group.updateRecord(cbb_group_select.Text,txt_contact_newname.Text);
                       
                        MessageBox.Show("SUCCESSFULL");
                      
                        
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("ERROR: " + ex.Message);
                    }
               

            }
        }

        private void btn_group_remove_Click(object sender, EventArgs e)
        {
            try
            {
                bool b = group.DeleteGroup(cbb_group_remove.Text);
                if (!b)
                {
                    MessageBox.Show("Not Successfull ");
                    return;
                }
                MessageBox.Show("Successfull ");



            }
            catch (Exception ex)
            {
                MessageBox.Show("ERROR: " + ex.Message);
            }
        }

        private void btn_refresh_Click(object sender, EventArgs e)
        {
            Display();
        }

        private void btn_contact_showlist_Click(object sender, EventArgs e)
        {
            ListContact x = new ListContact();
            x.ShowDialog();
        }
    }
}
