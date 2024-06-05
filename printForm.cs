
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.ComTypes;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using OfficeOpenXml;


namespace QLSV_L1
{
    public partial class printForm : Form
    {
        DB db = new DB();
        DB_Score db_score = new DB_Score();
        int rowindex = 0;
        public printForm()
        {
            InitializeComponent();
            cbb_print_sex.Text = "Both";
            radiobtn_no.Checked = true;
            DataTable dt = getData();
            dtgrid_print_student.DataSource = dt;
            dtgrid_print_student.Columns[0].HeaderCell.Value = "Student ID";
            dtgrid_print_student.Columns[1].HeaderCell.Value = "Name";
            dtgrid_print_student.Columns[2].HeaderCell.Value = "Birthday";
            dtgrid_print_student.Columns[3].HeaderCell.Value = "Sex";
            dtgrid_print_student.Columns[4].HeaderCell.Value = "Phone number";
        }
        public DataTable getData()
        {
            DataTable dtt = new DataTable();

            if (cbb_print_sex.Text == "Both" && radiobtn_no.Checked)
            {

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
                    for (int j = 0; j < tm.Rows.Count; j++)
                    {
                        if (tm.Rows[i]["id"].ToString() == ns.Rows[j]["id"].ToString())
                        {
                            tm.Rows[i]["Birth Day"] = ns.Rows[j]["birthday"];
                            break;
                        }
                    }



                }

                dtt = tm;
               


            }
            else if (cbb_print_sex.Text == "Male" && radiobtn_no.Checked)
            {
                DataTable tm = db.FilterbySex("Male").Tables["student"];
                

                dtt = tm;
                dtgrid_print_student.Columns[0].HeaderCell.Value = "Student ID";
                dtgrid_print_student.Columns[1].HeaderCell.Value = "Name";
                dtgrid_print_student.Columns[2].HeaderCell.Value = "Birthday";
                dtgrid_print_student.Columns[3].HeaderCell.Value = "Sex";
                dtgrid_print_student.Columns[4].HeaderCell.Value = "Phone number";
            }
            else if (cbb_print_sex.Text == "Female" && radiobtn_no.Checked)
            {
                DataTable tm = db.FilterbySex("Female").Tables["student"];

                dtt = tm;
                dtgrid_print_student.Columns[0].HeaderCell.Value = "Student ID";
                dtgrid_print_student.Columns[1].HeaderCell.Value = "Name";
                dtgrid_print_student.Columns[2].HeaderCell.Value = "Birthday";
                dtgrid_print_student.Columns[3].HeaderCell.Value = "Sex";
                dtgrid_print_student.Columns[4].HeaderCell.Value = "Phone number";
            }
            else if (cbb_print_sex.Text == "Both" && radiobtn_yes.Checked)
            {
                DateTime pre = dateTimePicker1.Value;
                DateTime after = dateTimePicker2.Value; 
                DataTable tm = db.FilterByBirthday(pre, after).Tables["ngaysinh"];
              

                dtt = tm;
                dtgrid_print_student.Columns[0].HeaderCell.Value = "Student ID";
                dtgrid_print_student.Columns[1].HeaderCell.Value = "Name";
                dtgrid_print_student.Columns[2].HeaderCell.Value = "Birthday";
                dtgrid_print_student.Columns[3].HeaderCell.Value = "Sex";
                dtgrid_print_student.Columns[4].HeaderCell.Value = "Phone number";
                
            }
            else if (cbb_print_sex.Text != "Both" && radiobtn_yes.Checked)
            {
                DateTime pre = dateTimePicker1.Value;
                DateTime after = dateTimePicker2.Value;
                
                DataTable tm = db.FilterByBirthdayAndSex(cbb_print_sex.Text,pre, after).Tables["ngaysinh"];


                dtt = tm;
                dtgrid_print_student.Columns[0].HeaderCell.Value = "Student ID";
                dtgrid_print_student.Columns[1].HeaderCell.Value = "Name";
                dtgrid_print_student.Columns[2].HeaderCell.Value = "Birthday";
                dtgrid_print_student.Columns[3].HeaderCell.Value = "Sex";
                dtgrid_print_student.Columns[4].HeaderCell.Value = "Phone number";
                
            }





            return dtt;

        }
        private void btn_print_filter_Click(object sender, EventArgs e)
        {
            DataTable dt = getData();
            dtgrid_print_student.DataSource = dt;
            dtgrid_print_student.Columns[0].HeaderCell.Value = "Student ID";
            dtgrid_print_student.Columns[1].HeaderCell.Value = "Name";
            dtgrid_print_student.Columns[2].HeaderCell.Value = "Birthday";
            dtgrid_print_student.Columns[3].HeaderCell.Value = "Sex";
            dtgrid_print_student.Columns[4].HeaderCell.Value = "Phone number";
        }

        private void SaveToTextFile(string filePath)
        {
            try
            {
                using (StreamWriter writer = new StreamWriter(filePath))
                {
                    writer.WriteLine("Danh sách sinh viên");
                    writer.WriteLine("\n");
                    // Lặp qua từng dòng trong DataGridView
                    foreach (DataGridViewRow row in dtgrid_print_student.Rows)
                    {
                        // Bỏ qua dòng trống
                        if (!row.IsNewRow)
                        {
                            StringBuilder line = new StringBuilder();

                            // Lặp qua từng ô trong dòng
                            foreach (DataGridViewCell cell in row.Cells)
                            {
                                // Thêm giá trị của ô vào chuỗi
                                line.Append(cell.Value?.ToString() ?? "");
                                line.Append("\t"); // Thêm dấu tab làm phân tách giữa các cột
                            }

                            // Ghi dòng vào tệp văn bản
                            writer.WriteLine(line);
                        }
                    }
                }

                MessageBox.Show("Data has been saved to the text file.");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void btn_print_save_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = "Text files (*.txt)|*.txt";
            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                string filePath = saveFileDialog.FileName;
                SaveToTextFile(filePath);
            }

           
        }

        private void btn_import_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Excel Files|*.xls;*.xlsx;*.xlsm";
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                string filePath = openFileDialog.FileName;

                using (ExcelPackage package = new ExcelPackage(new System.IO.FileInfo(filePath)))
                {
                    ExcelWorksheet worksheet = package.Workbook.Worksheets[1];
                    DataTable dt = new DataTable();

                    // Đọc dữ liệu từ tệp Excel vào DataTable
                    foreach (var firstRowCell in worksheet.Cells[1, 1, 1, worksheet.Dimension.End.Column])
                    {
                        dt.Columns.Add(firstRowCell.Text);
                    }

                    for (int rowNumber = 2; rowNumber <= worksheet.Dimension.End.Row; rowNumber++)
                    {
                        var row = worksheet.Cells[rowNumber, 1, rowNumber, worksheet.Dimension.End.Column];
                        var newRow = dt.Rows.Add();
                        foreach (var cell in row)
                        {
                            newRow[cell.Start.Column - 1] = cell.Text;
                        }
                    }

                    for (int row = 0; row < dt.Rows.Count; row++)
                    {
                        string s = dt.Rows[row]["Mã SV"].ToString() + "@student.hcmute.edu.vn";
                        dt.Rows[row]["Email"] = s;
                    }
                    // Hiển thị dữ liệu trên DataGridView
                    dt.Columns.Remove(dt.Columns[dt.Columns.Count - 1]);
                    dt.Columns.Remove(dt.Columns[dt.Columns.Count - 1]);
                    dtgrid_print_student.DataSource = dt;
                }
            }
        }

        private void btn_delete_Click(object sender, EventArgs e)
        {
            DataTable dt = getData();
            dtgrid_print_student.DataSource = dt;
            dtgrid_print_student.Columns[0].HeaderCell.Value = "Student ID";
            dtgrid_print_student.Columns[1].HeaderCell.Value = "Name";
            dtgrid_print_student.Columns[2].HeaderCell.Value = "Birthday";
            dtgrid_print_student.Columns[3].HeaderCell.Value = "Sex";
            dtgrid_print_student.Columns[4].HeaderCell.Value = "Phone number";
        }
    
    }




}
