using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using System.Xml.Linq;
using System.Windows.Forms;

namespace QLSV_L1
{
    public class DB
    {
        private string myconnectstring = "Data Source=DESKTOP-09KCOMQ\\SQLEXPRESS;Initial Catalog=tet;Integrated Security=True;Encrypt=False";
        public DataSet Mydataset()
        {
            DataSet ds = new DataSet();
            using (SqlConnection conn = new SqlConnection(myconnectstring))
            {
                conn.Open();
                string myquery = "SELECT * FROM student";
                SqlCommand cmd = new SqlCommand(myquery, conn);
                SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(cmd);
                sqlDataAdapter.Fill(ds, "student");
                conn.Close();
            }
            return ds;
        }

        public DataSet data_birthday()
        {
            DataSet ds = new DataSet();
            using (SqlConnection conn = new SqlConnection(myconnectstring))
            {
                conn.Open();
                string myquery = "SELECT * FROM ngaysinh";
                SqlCommand cmd = new SqlCommand(myquery, conn);
                SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(cmd);
                sqlDataAdapter.Fill(ds, "ngaysinh");
                conn.Close();
            }
            return ds;
        }

        public DataSet FilterbySex(string sex)
        {
            DataSet ds = new DataSet();
            using (SqlConnection conn = new SqlConnection(myconnectstring))
            {
                conn.Open();
                string query = " SELECT student.id, student.name, ngaysinh.birthday,student.sex ,student.phone_number \r\nFROM ngaysinh \r\nINNER JOIN student ON student.id = ngaysinh.id\r\nWHERE student.sex = @sex";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@sex", sex);
                SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(cmd);
                sqlDataAdapter.Fill(ds, "student");
            }

            return ds;
        }
        public DataSet FilterByBirthday(DateTime pre,DateTime after)
        {
            DataSet ds = new DataSet();
            using (SqlConnection conn = new SqlConnection(myconnectstring))
            {
                conn.Open();
                string query = " SELECT student.id, student.name, ngaysinh.birthday,student.sex ,student.phone_number \r\nFROM ngaysinh \r\nINNER JOIN student ON student.id = ngaysinh.id\r\nWHERE CONVERT(datetime, ngaysinh.birthday, 103) BETWEEN @pre AND @after";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@pre",pre);
                cmd.Parameters.AddWithValue("@after",after);
                SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(cmd);
                sqlDataAdapter.Fill(ds, "ngaysinh");
            }

            return ds;
        }
        public DataSet FilterByBirthdayAndSex(string sex,DateTime pre, DateTime after)
        {
            DataSet ds = new DataSet();
            using (SqlConnection conn = new SqlConnection(myconnectstring))
            {
                conn.Open();
                string query = " SELECT student.id, student.name, ngaysinh.birthday,student.sex,student.phone_number \r\nFROM ngaysinh \r\nINNER JOIN student ON student.id = ngaysinh.id\r\nWHERE CONVERT(datetime, ngaysinh.birthday, 103) BETWEEN @pre AND @after AND student.sex = @sex";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@pre", pre);
                cmd.Parameters.AddWithValue("@after", after);
                cmd.Parameters.AddWithValue("@sex", sex);
                SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(cmd);
                sqlDataAdapter.Fill(ds, "ngaysinh");
            }

            return ds;
        }

        public DataSet getRecord(string id)
        {
            DataSet dt = new DataSet();
            using (SqlConnection connection = new SqlConnection(myconnectstring))//tạo kết nối
            {
                connection.Open();
                string myquery = "SELECT * FROM student WHERE ID =" + id;
                SqlCommand command = new SqlCommand(myquery, connection);
                SqlDataAdapter adapter = new SqlDataAdapter(command);
                adapter.Fill(dt, "student");
                connection.Close();

            }
            return dt;
        }
        public DataSet getBirthday(string id)
        {
            DataSet dt = new DataSet();
            using (SqlConnection connection = new SqlConnection(myconnectstring))
            {
                connection.Open();
                string myquery = "SELECT * FROM ngaysinh WHERE ID =" + id;
                SqlCommand command = new SqlCommand(myquery,connection);
                SqlDataAdapter adapter = new SqlDataAdapter(command);
                adapter.Fill(dt, "ngaysinh");
                connection.Close();
            }
            return dt;
        }
        public bool existStudent(string id)
        {
            using (SqlConnection conn = new SqlConnection(myconnectstring))
            {
                conn.Open();
                string checkID = "SELECT COUNT(*) FROM student WHERE id = @id";
                SqlCommand cmd = new SqlCommand(checkID, conn);
                cmd.Parameters.AddWithValue("@id", id);
                int count = (int)cmd.ExecuteScalar();
                if (count == 1) return true;

                conn.Close();
            }
            return false;
        }
        public bool InsertStudent(string id, string name, string gender, string age, string phone_number, byte[] image)
        {
           
            int myage = Convert.ToInt32(age);
            using (SqlConnection conn = new SqlConnection(myconnectstring))
            {
                conn.Open();
                string checkID = "SELECT COUNT(*) FROM student WHERE id = @id";
                SqlCommand cmd = new SqlCommand(checkID, conn);
                cmd.Parameters.AddWithValue("@id", id);
                int count = (int)cmd.ExecuteScalar();
                if (count >= 1) return false;

                conn.Close();
            }
            using (SqlConnection conn = new SqlConnection(myconnectstring))
            {
                conn.Open();
                string insertData = "INSERT INTO student" +
                    "(id,name,sex,age,phone_number,image)" +
                    "VALUES(@id,@name,@sex,@age,@phone_number,@image)";
                SqlCommand cmd = new SqlCommand(@insertData, conn);
                cmd.Parameters.AddWithValue("@id", id);
                cmd.Parameters.AddWithValue("@name", name);
                cmd.Parameters.AddWithValue("@sex", gender);
                cmd.Parameters.AddWithValue("@age", myage);
                cmd.Parameters.AddWithValue("@phone_number", phone_number);
                cmd.Parameters.AddWithValue("@image", image);
                cmd.ExecuteNonQuery();

                conn.Close();

            }
            return true;
        }
        public bool InsertBirth(string id, string birthday)
        {
            using (SqlConnection conn = new SqlConnection(myconnectstring))
            {
                conn.Open();
                string checkID = "SELECT COUNT(*) FROM ngaysinh WHERE id = @id";
                SqlCommand cmd = new SqlCommand(checkID, conn);
                cmd.Parameters.AddWithValue("@id", id);
                int count = (int)cmd.ExecuteScalar();
                if (count >= 1) return false;

                conn.Close();
            }
            using (SqlConnection conn = new SqlConnection(myconnectstring))
            {
                conn.Open();
                string insertData = "INSERT INTO ngaysinh" +
                    "(id,birthday)" +
                    "VALUES(@id,@birthday)";
                SqlCommand cmd = new SqlCommand(@insertData, conn);
                cmd.Parameters.AddWithValue("@id", id);
                cmd.Parameters.AddWithValue("@birthday", birthday);
              
                cmd.ExecuteNonQuery();

                conn.Close();

            }
            return true;
        }

        public bool DeleteStudent(string id)
        {
            DataSet ds1 = new DataSet();
            DataSet ds2 = new DataSet();
            using (SqlConnection conn = new SqlConnection(myconnectstring))
            {
                conn.Open();
                string que1 = "DELETE FROM student WHERE id =" + id;
                SqlCommand cmd1 = new SqlCommand(que1, conn);
                SqlDataAdapter adap1 = new SqlDataAdapter(cmd1);
                adap1.Fill(ds1,"student");
                conn.Close();
            }
            using (SqlConnection conn = new SqlConnection(myconnectstring))
            {
                conn.Open();
                string que2 = "DELETE FROM ngaysinh WHERE id =" + id;
                SqlCommand cmd2 = new SqlCommand(que2, conn);
                SqlDataAdapter adap2 = new SqlDataAdapter(cmd2);
                adap2.Fill(ds2, "student");
                conn.Close();
            }

            if (!existStudent(id))
            {
                return true;
            }
            return false;
        }
 

        public DataSet updateRecord(string id, string name,string gender, string age, string phone_number, byte[] image)
        {
            DataSet dt = new DataSet();
            using (SqlConnection connection = new SqlConnection(myconnectstring))
            {
                connection.Open();
                string myquery = "UPDATE student SET name = @name, sex = @sex,age = @age, phone_number=@phone_number,image = @image WHERE id = @id";

                SqlCommand command = new SqlCommand(myquery, connection);
                command.Parameters.AddWithValue("@id", id);
                command.Parameters.AddWithValue("@name", name);
                int myage = Convert.ToInt32(age);   
                command.Parameters.AddWithValue("@age",myage);
                command.Parameters.AddWithValue("@sex", gender);
                command.Parameters.AddWithValue("@phone_number", phone_number); ;
                command.Parameters.AddWithValue("@image", image);
                SqlDataAdapter adapter = new SqlDataAdapter(command);
                adapter.Fill(dt, "student");
                connection.Close();

            }
            return dt;
        }
        public DataSet updateBirthday(string id,string birthday)
        {
            DataSet dt = new DataSet();
            using (SqlConnection conn = new SqlConnection(myconnectstring))
            {
                conn.Open();
                string myquery = "UPDATE ngaysinh SET id = @id, birthday=@birthday WHERE id = @id";

                SqlCommand command = new SqlCommand(myquery, conn);
                command.Parameters.AddWithValue("@id", id);
                command.Parameters.AddWithValue("@birthday",birthday );
               
                SqlDataAdapter adapter = new SqlDataAdapter(command);
                adapter.Fill(dt, "ngaysinh");
                conn.Close();

            }
            return dt;
        }
        public int CountTotal()
        {
            //string que = "SELECT COUNT(*) AS total_records FROM student";
            using (SqlConnection conn = new SqlConnection(myconnectstring))
            {
                conn.Open();
                string que = "SELECT COUNT(*) AS total_records FROM student";
                SqlCommand cmd = new SqlCommand(que, conn);
                int count = (int)cmd.ExecuteScalar();
                return count;
                conn.Close();
            }
        }
    }
}
