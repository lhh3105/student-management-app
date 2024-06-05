using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLSV_L1
{
    public class DB_group
    {
        private string myconnectstring = "Data Source=DESKTOP-09KCOMQ\\SQLEXPRESS;Initial Catalog=tet;Integrated Security=True";
        public DataSet Mydataset()
        {
            DataSet ds = new DataSet();
            using (SqlConnection conn = new SqlConnection(myconnectstring))
            {
                conn.Open();
                string myquery = "SELECT * FROM group1";
                SqlCommand cmd = new SqlCommand(myquery, conn);
                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                adapter.Fill(ds, "group1");
                conn.Close();
            }
            return ds;
        }

        public bool existGroup(string name)
        {
            using (SqlConnection conn = new SqlConnection(myconnectstring))
            {
                conn.Open();
                string checkID = "SELECT COUNT(*) FROM group1 WHERE name = @name";
                SqlCommand cmd = new SqlCommand(checkID, conn);
                cmd.Parameters.AddWithValue("@name", name);
                int count = (int)cmd.ExecuteScalar();
                if (count == 1) return true;

                conn.Close();
            }
            return false;
        }

        public bool DeleteContact(string name)
        {
            DataSet ds1 = new DataSet();
            DataSet ds2 = new DataSet();
            using (SqlConnection conn = new SqlConnection(myconnectstring))
            {
                conn.Open();
                string que1 = "DELETE FROM group1 WHERE name =" + name;
                SqlCommand cmd1 = new SqlCommand(que1, conn);
                SqlDataAdapter adap1 = new SqlDataAdapter(cmd1);
                adap1.Fill(ds1, "group1");
                conn.Close();
            }

            if (!existGroup(name))
            {
                return true;
            }
            return false;
        }

        public bool InsertGroup(string name)
        {
            if (existGroup(name)) { return false; }
            using (SqlConnection conn = new SqlConnection(myconnectstring))
            {
                conn.Open();
                string insertData = "INSERT INTO group1" +
                    "(id,name)" +
                    "VALUES(@id,@name)";
                SqlCommand cmd = new SqlCommand(@insertData, conn);
                cmd.Parameters.AddWithValue("@id",'1');
                cmd.Parameters.AddWithValue("@name", name);
               
                cmd.ExecuteNonQuery();

                conn.Close();
            }
            return true;
        }

        public bool DeleteGroup(string name)
        {
            DataSet ds1 = new DataSet();
            DataSet ds2 = new DataSet();
            using (SqlConnection conn = new SqlConnection(myconnectstring))
            {
                conn.Open();
                string que1 = "DELETE FROM group1 WHERE name = @name " ;
                SqlCommand cmd1 = new SqlCommand(que1, conn);
                cmd1.Parameters.AddWithValue("@name", name);
                SqlDataAdapter adap1 = new SqlDataAdapter(cmd1);
                adap1.Fill(ds1, "group1");
                conn.Close();
            }

            if (!existGroup(name))
            {
                return true;
            }
            return false;
        }

        public DataSet updateRecord(string selectname, string newname)
        {
            DataSet dt = new DataSet();
            using (SqlConnection connection = new SqlConnection(myconnectstring))
            {
                connection.Open();
                string myquery = "UPDATE group1 SET name = @newname WHERE name = @selectname";

                SqlCommand command = new SqlCommand(myquery, connection);
                command.Parameters.AddWithValue("@newname", newname);
                command.Parameters.AddWithValue("@selectname", selectname);

                
                SqlDataAdapter adapter = new SqlDataAdapter(command);
                adapter.Fill(dt, "group1");
                connection.Close();

            }
            return dt;
        }

    }
}
