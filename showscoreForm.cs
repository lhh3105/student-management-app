using DocumentFormat.OpenXml.Packaging;
using DocumentFormat.OpenXml;
using DocumentFormat.OpenXml.Wordprocessing;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLSV_L1
{
    public partial class showscoreForm : Form
    {
        DB_Score db_score = new DB_Score();
        DB db = new DB();
        public showscoreForm()
        {
            InitializeComponent();
            cbb_semester.Text = "1";
        }

        private void btn_showscore_find_Click(object sender, EventArgs e)
        {
            if (txt_showscore_studentid.Text=="")
            {
                MessageBox.Show("Error!Please enter blank field", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (!db.existStudent(txt_showscore_studentid.Text))
            {
                MessageBox.Show("Error!Student is not existed","ERROR",MessageBoxButtons.OK,MessageBoxIcon.Warning);
                return;
            }
            DataTable x = db_score.ScoreByStudent(txt_showscore_studentid.Text,cbb_semester.Text).Tables[0];
            dtgrid_showscore_list.DataSource = x;
            dtgrid_showscore_list.Columns[0].HeaderCell.Value = "Student ID";
            dtgrid_showscore_list.Columns[1].HeaderCell.Value = "Course Name";
            dtgrid_showscore_list.Columns[2].HeaderCell.Value = "STC";
            dtgrid_showscore_list.Columns[3].HeaderCell.Value = "Score";
            dtgrid_showscore_list.Columns[4].HeaderCell.Value = "Description";
            dtgrid_showscore_list.Columns[5].HeaderCell.Value = "Semester";
        }

        static DataTable GetDataTableFromDataGridView(DataGridView dataGridView)
        {
            DataTable dataTable = new DataTable();

            // Tạo các cột trong DataTable dựa trên các cột của DataGridView
            foreach (DataGridViewColumn column in dataGridView.Columns)
            {
                dataTable.Columns.Add(column.HeaderText);
            }

            // Thêm các dòng vào DataTable dựa trên dữ liệu trong DataGridView
            foreach (DataGridViewRow row in dataGridView.Rows)
            {
                DataRow dataRow = dataTable.NewRow();
                for (int i = 0; i < dataGridView.Columns.Count; i++)
                {
                    dataRow[i] = row.Cells[i].Value;
                }
                dataTable.Rows.Add(dataRow);
            }

            return dataTable;
        }
        private void btn_text_file_Click(object sender, EventArgs e)
        {
            /*// Tạo DataTable mô phỏng dữ liệu từ DataGridView
            DataTable dataTable = new DataTable();
            
            dataTable.Columns.Add("Name", typeof(string));
            dataTable.Columns.Add("Age", typeof(int));

            // Giả lập dữ liệu từ DataGridView (thay bằng dữ liệu thực từ DataGridView của bạn)
            dataTable.Rows.Add("John Doe", 30);
            dataTable.Rows.Add("Jane Smith", 25);
            */

            DataTable dataTable = GetDataTableFromDataGridView(dtgrid_showscore_list);
            // Khởi tạo SaveFileDialog để chọn vị trí lưu file Word
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = "Word Document (*.docx)|*.docx";
            saveFileDialog.Title = "Save as Word Document";
            saveFileDialog.FileName = "DataGridViewTable.docx";

            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                string fileName = saveFileDialog.FileName;

                // Tạo tài liệu Word và thêm bảng vào
                using (WordprocessingDocument wordDocument = WordprocessingDocument.Create(fileName, WordprocessingDocumentType.Document))
                {
                    // Tạo phần chính của tài liệu Word
                    MainDocumentPart mainPart = wordDocument.AddMainDocumentPart();
                    mainPart.Document = new Document();
                    Body body = mainPart.Document.AppendChild(new Body());

                    // tiêu đề
                    Paragraph titleParagraph = new Paragraph(new Run(new Text("Kết quả các môn học của sinh viên")));

                    // Căn giữa tiêu đề
                    titleParagraph.ParagraphProperties = new ParagraphProperties(new Justification { Val = JustificationValues.Center });

                    // Font chữ và kích thước
                    RunProperties runProperties = new RunProperties();
                    RunFonts runFont = new RunFonts() { Ascii = "Arial" };
                    FontSize fontSize = new FontSize() { Val = "40" }; // Kích thước font chữ là 24 points
                    Bold bold = new Bold();

                    runProperties.Append(runFont, fontSize, bold);
                    titleParagraph.Append(runProperties);

                    // Thêm tiêu đề vào tài liệu
                    body.Append(titleParagraph);

                    // thêm tên, mssv sinh viên
                    DataTable x = db.getRecord(txt_showscore_studentid.Text).Tables[0];
                    string name = x.Rows[0][1].ToString();

                    Paragraph paramssv = new Paragraph(new Run(new Text("Mã số sinh viên: " + txt_showscore_studentid.Text)));
                    Paragraph paraname = new Paragraph(new Run(new Text("Tên: " + name)));
                    body.Append(paramssv);
                    body.Append(paraname);

                    // thêm học kì
                    Paragraph parahk = new Paragraph(new Run(new Text("Học kì: " + cbb_semester.Text)));
                    body.Append(parahk);
                    //thêm tổng số chứng chỉ
                    int sumtc = 0;
                    foreach (DataRow row in dataTable.Rows)
                    {
                        // Kiểm tra xem cột "Name" có tồn tại và không rỗng trong mỗi hàng
                        if (row["STC"] != DBNull.Value && !string.IsNullOrEmpty(row["STC"].ToString()))
                        {
                            int s1 = Convert.ToInt32(row["STC"].ToString());
                            sumtc += s1;


                        }
                        else
                        {
                            Console.WriteLine("Name is null or empty for this row.");
                        }
                    }


                    Paragraph parastc = new Paragraph(new Run(new Text("Tổng số tín chỉ: " + sumtc.ToString())));
                    body.Append(parastc);


                    // thêm điểm trung bình và xếp loại
                    int sum = 0;
                    foreach (DataRow row in dataTable.Rows)
                    {
                        // Kiểm tra xem cột "Name" có tồn tại và không rỗng trong mỗi hàng
                        if (row["Score"] != DBNull.Value && !string.IsNullOrEmpty(row["Score"].ToString()))
                        {
                            int s1 = Convert.ToInt32(row["Score"].ToString());
                            sum += s1;


                        }
                        else
                        {
                            Console.WriteLine("Name is null or empty for this row.");
                        }
                    }
                    Double kq = sum*1.0/(dataTable.Rows.Count-1);


                    Paragraph parakq = new Paragraph(new Run(new Text("Điểm trung bình: " + kq.ToString())));
                    body.Append(parakq);
                    string s = "";
                    if (kq >= 8.0) s = "Giỏi";
                    else if (kq < 6.0) s = "Trung bình";
                    else s = "Khá";

                    Paragraph paraxl = new Paragraph(new Run(new Text("Xếp loại: " + s)));
                    body.Append(paraxl);

                    // Tạo bảng
                    Table table = new Table();
                    TableProperties tableProperties = new TableProperties(
                        new TableWidth { Width = "100%", Type = TableWidthUnitValues.Pct }
);
                    table.AppendChild(tableProperties);
                    body.Append(table);

                    // Thêm tiêu đề cột và tô màu cho tiêu đề
                    TableRow headerRow = new TableRow();
                    table.Append(headerRow);
                    foreach (DataColumn column in dataTable.Columns)
                    {
                        TableCell headerCell = new TableCell(new Paragraph(new Run(new Text(column.ColumnName))));

                        // Tô màu cho tiêu đề cột
                        headerCell.Append(new TableCellProperties(
                            new Shading { Fill = "A9D08E" })); // Màu xanh lá cây

                        headerRow.Append(headerCell);

                       // table.AppendChild(new TableWidth { Width = "5000", Type = TableWidthUnitValues.Dxa }); // Độ rộng cột là 2400 Đơn vị đo xa (Dxa)
                    }

                    // Thêm dữ liệu từ DataTable vào bảng
                    foreach (DataRow row in dataTable.Rows)
                    {
                        TableRow dataRow = new TableRow();
                        table.Append(dataRow);
                        foreach (var cellValue in row.ItemArray)
                        {
                            TableCell cell = new TableCell(new Paragraph(new Run(new Text(cellValue.ToString()))));
                            dataRow.Append(cell);
                        }
                    }

                    // Lưu tài liệu Word
                    wordDocument.Save();
                }

                Console.WriteLine($"DataGridView data exported to Word document '{fileName}' successfully.");
            }
        }
    }
}
