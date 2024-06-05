using DocumentFormat.OpenXml.Packaging;
using DocumentFormat.OpenXml.Wordprocessing;
using DocumentFormat.OpenXml;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace QLSV_L1
{
    public partial class ScoreByCourse : Form
    {
        DB_Score score = new DB_Score();
        static string mycourse;
        static string myteacher;
        public ScoreByCourse(string teacher, string course)
        {
            InitializeComponent();
            mycourse = course;
            myteacher = teacher;

            dtgrid_scorebycourse.DataSource = score.FilterByCoursename(course,cbb_semester.Text).Tables[0] ;

            dtgrid_scorebycourse.Columns[0].HeaderCell.Value = "Student ID";
            dtgrid_scorebycourse.Columns[1].HeaderCell.Value = "Course Name";
            dtgrid_scorebycourse.Columns[3].HeaderCell.Value = "Score";
            dtgrid_scorebycourse.Columns[4].HeaderCell.Value = "Description";
            dtgrid_scorebycourse.Columns[5].HeaderCell.Value = "Semester";

            lb_gv.Text = "Teacher: " + teacher;
            lb_course.Text = "Coure Name: "+ course;
            cbb_semester.Text = "1";

      
            
        }

        private void ScoreByCourse_Load(object sender, EventArgs e)
        {

        }

        private void dtgrid_scorebycourse_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btn_ok_Click(object sender, EventArgs e)
        {
            dtgrid_scorebycourse.DataSource = score.FilterByCoursename(mycourse, cbb_semester.Text).Tables[0];
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

        

        private void btn_save_Click(object sender, EventArgs e)
        {
            DataTable dataTable = GetDataTableFromDataGridView(dtgrid_scorebycourse);
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
                    Paragraph titleParagraph = new Paragraph(new Run(new Text("Kết quả môn "+ mycourse +" của sinh viên")));

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

                    // thêm tên giáo viên

                    Paragraph paragv = new Paragraph(new Run(new Text("Giáo viên phụ trách: " + myteacher)));
                    body.Append(paragv);

                    // thêm học kì
                    Paragraph parahk = new Paragraph(new Run(new Text("Học kì: " + cbb_semester.Text)));
                    body.Append(parahk);
                    

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
