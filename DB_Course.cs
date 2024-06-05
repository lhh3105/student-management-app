using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLSV_L1
{
    internal class DB_Course
    {
        private string myconnectstring = "Data Source=DESKTOP-09KCOMQ\\SQLEXPRESS;Initial Catalog=tet;Integrated Security=True;Encrypt=False";
        public DataSet Mydataset()
        {
            DataSet ds = new DataSet();
            using (SqlConnection conn = new SqlConnection(myconnectstring))
            {
                conn.Open();
                string myquery = "SELECT * FROM course";
                SqlCommand cmd = new SqlCommand(myquery, conn);
                SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(cmd);
                sqlDataAdapter.Fill(ds, "course");
                conn.Close();
            }
            return ds;
        }

        public DataSet getRecord(string id)
        {
            DataSet dt = new DataSet();
            using (SqlConnection connection = new SqlConnection(myconnectstring))//tạo kết nối
            {
                connection.Open();
                string myquery = "SELECT * FROM course WHERE ID =" + id;
                SqlCommand command = new SqlCommand(myquery, connection);
                SqlDataAdapter adapter = new SqlDataAdapter(command);
                adapter.Fill(dt, "course");
                connection.Close();

            }
            return dt;
        }

        public bool existCourse(string id)
        {
            using (SqlConnection conn = new SqlConnection(myconnectstring))
            {
                conn.Open();
                string checkID = "SELECT COUNT(*) FROM course WHERE id = @id";
                SqlCommand cmd = new SqlCommand(checkID, conn);
                cmd.Parameters.AddWithValue("@id", id);
                int count = (int)cmd.ExecuteScalar();
                if (count == 1) return true;

                conn.Close();
            }
            return false;
        }
        public bool existCourseByName(string courseName)
        {
            using (SqlConnection conn = new SqlConnection(myconnectstring))
            {
                conn.Open();
                string checkID = "SELECT COUNT(*) FROM course WHERE name = @courseName";
                SqlCommand cmd = new SqlCommand(checkID, conn);
                cmd.Parameters.AddWithValue("@courseName", courseName);
                int count = (int)cmd.ExecuteScalar();
                if (count == 1) return true;

                conn.Close();
            }
            return false;
        }


        public bool InsertCourse(string id, string name, string period,string description)
        {

            if (existCourse(id)) { return false; }

            int period1 = Convert.ToInt32(period);
            using (SqlConnection conn = new SqlConnection(myconnectstring))
            {
                conn.Open();
                string insertData = "INSERT INTO course" +
                    "(id,name,period,description)" +
                    "VALUES(@id,@name,@period,@description)";
                SqlCommand cmd = new SqlCommand(@insertData, conn);
                cmd.Parameters.AddWithValue("@id", id);
                cmd.Parameters.AddWithValue("@name", name);
                cmd.Parameters.AddWithValue("@period", period1);
                cmd.Parameters.AddWithValue("@description", description);
                cmd.ExecuteNonQuery();

                conn.Close();

            }
            return true;

            
        }

        public bool DeleteCourse(string id)
        {
            DataSet ds1 = new DataSet();
            DataSet ds2 = new DataSet();
            using (SqlConnection conn = new SqlConnection(myconnectstring))
            {
                conn.Open();
                string que1 = "DELETE FROM course WHERE id =" + id;
                SqlCommand cmd1 = new SqlCommand(que1, conn);
                SqlDataAdapter adap1 = new SqlDataAdapter(cmd1);
                adap1.Fill(ds1, "student");
                conn.Close();
            }
           

            if (!existCourse(id))
            {
                return true;
            }
            return false;
        }

        public DataSet updateRecord(string id, string name, string period,string description)
        {
            DataSet dt = new DataSet();
            using (SqlConnection connection = new SqlConnection(myconnectstring))
            {
                connection.Open();
                string myquery = "UPDATE course SET name = @name, period = @period, description = @description WHERE id = @id";

                SqlCommand command = new SqlCommand(myquery, connection);
                command.Parameters.AddWithValue("@id", id);
                command.Parameters.AddWithValue("@name", name);
                int period1 = Convert.ToInt32(period);
                command.Parameters.AddWithValue("@period", period1);
                command.Parameters.AddWithValue("@description",description);
                SqlDataAdapter adapter = new SqlDataAdapter(command);
                adapter.Fill(dt, "course");
                connection.Close();

            }
            return dt;
        }

    }
}
