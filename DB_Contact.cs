using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace QLSV_L1
{
    public class DB_Contact
    {
        private string myconnectstring = "Data Source=DESKTOP-09KCOMQ\\SQLEXPRESS;Initial Catalog=tet;Integrated Security=True;Encrypt=False";
        public DataSet Mydataset()
        {
            DataSet ds = new DataSet();
            using (SqlConnection conn = new SqlConnection(myconnectstring))
            {
                conn.Open();
                string myquery = "SELECT * FROM contact";
                SqlCommand cmd = new SqlCommand(myquery, conn);
                SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(cmd);
                sqlDataAdapter.Fill(ds, "contact");
                conn.Close();
            }
            return ds;
        }
        public DataSet FilterByGroup(string group)
        {
            DataSet ds = new DataSet();
            using (SqlConnection conn = new SqlConnection(myconnectstring))
            {
                conn.Open();
                string myquery = "SELECT * FROM contact WHERE groupname = @group";
                SqlCommand cmd = new SqlCommand(myquery, conn);
                cmd.Parameters.AddWithValue("@group", group);
                SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(cmd);
                sqlDataAdapter.Fill(ds, "contact");
                conn.Close();
            }
            return ds;
        }
        public bool existContact(string id)
        {
            using (SqlConnection conn = new SqlConnection(myconnectstring))
            {
                conn.Open();
                string checkID = "SELECT COUNT(*) FROM contact WHERE id = @id";
                SqlCommand cmd = new SqlCommand(checkID, conn);
                cmd.Parameters.AddWithValue("@id", id);
                int count = (int)cmd.ExecuteScalar();
                if (count == 1) return true;

                conn.Close();
            }
            return false;
        }
        public bool InsertContact(string id, string name, string group, string phone, string email, byte[] image)
        {
            if (existContact(id)) { return false; }
            using (SqlConnection conn = new SqlConnection(myconnectstring))
            {
                conn.Open();
                string insertData = "INSERT INTO contact" +
                    "(id,name,groupname,phone,email,image)" +
                    "VALUES(@id,@name,@groupname,@phone,@email,@image)";
                SqlCommand cmd = new SqlCommand(@insertData, conn);
                cmd.Parameters.AddWithValue("@id", id);
                cmd.Parameters.AddWithValue("@name", name);
                cmd.Parameters.AddWithValue("@groupname", group);
                cmd.Parameters.AddWithValue("@phone", phone);
                cmd.Parameters.AddWithValue("@email", email);
                cmd.Parameters.AddWithValue("@image", image);
                cmd.ExecuteNonQuery();

                conn.Close();
            }
            return true;
        }

        public bool DeleteContact(string id)
        {
            DataSet ds1 = new DataSet();
            DataSet ds2 = new DataSet();
            using (SqlConnection conn = new SqlConnection(myconnectstring))
            {
                conn.Open();
                string que1 = "DELETE FROM contact WHERE id =" + id;
                SqlCommand cmd1 = new SqlCommand(que1, conn);
                SqlDataAdapter adap1 = new SqlDataAdapter(cmd1);
                adap1.Fill(ds1, "contact");
                conn.Close();
            }
            
            if (!existContact(id))
            {
                return true;
            }
            return false;
        }


        public DataSet updateRecord(string id, string name, string group, string phone, string email, byte[] image)
        {
            DataSet dt = new DataSet();
            using (SqlConnection connection = new SqlConnection(myconnectstring))
            {
                connection.Open();
                string myquery = "UPDATE contact SET name = @name, groupname = @group,phone = @phone, email=@email,image = @image WHERE id = @id";

                SqlCommand command = new SqlCommand(myquery, connection);
                command.Parameters.AddWithValue("@id", id);
                command.Parameters.AddWithValue("@name", name);
                
                command.Parameters.AddWithValue("@group", group);
                command.Parameters.AddWithValue("@phone", phone);
                command.Parameters.AddWithValue("@email", email); ;
                command.Parameters.AddWithValue("@image", image);
                SqlDataAdapter adapter = new SqlDataAdapter(command);
                adapter.Fill(dt, "contact");
                connection.Close();

            }
            return dt;
        }
        public DataSet getRecord(string id)
        {
            DataSet dt = new DataSet();
            using (SqlConnection connection = new SqlConnection(myconnectstring))//tạo kết nối
            {
                connection.Open();
                string myquery = "SELECT * FROM contact WHERE id =" + id;
                SqlCommand command = new SqlCommand(myquery, connection);
                SqlDataAdapter adapter = new SqlDataAdapter(command);
                adapter.Fill(dt, "contact");
                connection.Close();

            }
            return dt;
        }

        public List<string> getCourseByTeacher(string name)
        {
            List<string> list = new List<string>();
            DataSet ds = new DataSet();
            using (SqlConnection conn = new SqlConnection(myconnectstring))
            {
                conn.Open();
                string myquery = "SELECT teaCourse.course FROM teaCourse WHERE name = @name ";
                SqlCommand cmd = new SqlCommand(myquery, conn);
                cmd.Parameters.AddWithValue("@name", name);
                SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(cmd);
                sqlDataAdapter.Fill(ds, "teaCourse");
                conn.Close();
            }
            DataTable dt = ds.Tables[0];
            foreach (DataRow row in dt.Rows)
            {
                list.Add(row["course"].ToString());
            }

            return list;
        }
    }
}
