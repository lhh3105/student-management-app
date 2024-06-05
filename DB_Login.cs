using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLSV_L1
{
    public class DB_Login
    {
        private string myconnectstring = "Data Source=DESKTOP-09KCOMQ\\SQLEXPRESS;Initial Catalog=tet;Integrated Security=True;Encrypt=False";



        public DataSet Mydataset()
        {
            DataSet ds = new DataSet();
            using (SqlConnection conn = new SqlConnection(myconnectstring))
            {
                conn.Open();
                string myquery = "SELECT * FROM admin1";
                SqlCommand cmd = new SqlCommand(myquery, conn);
                SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(cmd);
                sqlDataAdapter.Fill(ds, "admin1");
                conn.Close();
            }
            return ds;
        }


        public bool existUser(string username)
        {
            using (SqlConnection conn = new SqlConnection(myconnectstring))
            {
                conn.Open();
                string checkUser = "SELECT COUNT(*) FROM admin1 WHERE username = @username";
                SqlCommand cmd = new SqlCommand(checkUser, conn);
                cmd.Parameters.AddWithValue("@username", username);
                int count = (int)cmd.ExecuteScalar();
                if (count == 1) return true;

                conn.Close();
            }
            return false;
        }
        public bool exactUser(string username, string password)
        {
            DataSet ds = new DataSet();
            using (SqlConnection con = new SqlConnection(myconnectstring))
            {
                con.Open();
                string que = "SELECT * FROM admin1 WHERE  username = @username";

                SqlCommand cmd = new SqlCommand(que, con);
                cmd.Parameters.AddWithValue("@username", username);
                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                adapter.Fill(ds, "admin1");

                con.Close();
            }
            DataTable dt = ds.Tables[0];
            if (username == dt.Rows[0]["username"].ToString() && password == dt.Rows[0]["pass"].ToString()) { return true; }
            return false;
        }
        public DataSet getRecord(string username,string password)
        {
            DataSet ds = new DataSet();
            using (SqlConnection con = new SqlConnection(myconnectstring))
            {
                con.Open();
                string que = "SELECT * FROM admin1 WHERE  username = @username";

                SqlCommand cmd = new SqlCommand(que, con);
                cmd.Parameters.AddWithValue("@username", username);
                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                adapter.Fill(ds, "admin1");

                con.Close();
            }
            return ds;
        }

        public bool HavePermission(string username, string password)
        {
            DataSet ds = new DataSet();
            using (SqlConnection con = new SqlConnection(myconnectstring))
            {
                con.Open();
                string que = "SELECT * FROM admin1 WHERE  username = @username AND pass = @password";

                SqlCommand cmd = new SqlCommand(que, con);
                cmd.Parameters.AddWithValue("@username", username);
                cmd.Parameters.AddWithValue("@password", password);
                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                adapter.Fill(ds, "admin1");

                con.Close();
            }
            DataTable dt = ds.Tables[0];
            if ("Enable" == dt.Rows[0]["status"].ToString() ) { return true; }
            return false;
        }
        public bool existEmail(string email)
        {
            using (SqlConnection conn = new SqlConnection(myconnectstring))
            {
                conn.Open();
                string checkUser = "SELECT COUNT(*) FROM admin1 WHERE email = @email";
                SqlCommand cmd = new SqlCommand(checkUser, conn);
                cmd.Parameters.AddWithValue("@email", email);
                int count = (int)cmd.ExecuteScalar();
                if (count == 1) return true;

                conn.Close();
            }
            return false;
        }

        public bool InsertAccount(string fullname,string username,string pass,string email,string status, byte[] image)
        {
            if (existEmail(email)) { return false; }
            if (existUser(username)) { return false; }

            using (SqlConnection conn = new SqlConnection(myconnectstring))
            {
                conn.Open();
                string insertData = "INSERT INTO admin1" +
                    "(fullname,username,pass,email,status,image)" +
                    "VALUES(@fullname,@username,@pass,@email,@status,@image)";
                SqlCommand cmd = new SqlCommand(@insertData, conn);
                cmd.Parameters.AddWithValue("@username",username);
                cmd.Parameters.AddWithValue("@pass",pass);
                cmd.Parameters.AddWithValue("@fullname", fullname);

                cmd.Parameters.AddWithValue("@email", email);
                cmd.Parameters.AddWithValue("@status", status);
                cmd.Parameters.AddWithValue("@image", image);
                cmd.ExecuteNonQuery();

                conn.Close();

            }
            return true;

        }

        public DataSet updateRecord(string fullname,string username, string password, string email,string status)
        {
            DataSet dt = new DataSet();
            using (SqlConnection connection = new SqlConnection(myconnectstring))
            {
                connection.Open();
                string myquery = "UPDATE admin1 SET fullname = @fullname, username = @username, pass=@password, status = @status WHERE email = @email";

                SqlCommand command = new SqlCommand(myquery, connection);
                command.Parameters.AddWithValue("@fullname", fullname);
                command.Parameters.AddWithValue("@username",username);
                command.Parameters.AddWithValue("@password", password);
                command.Parameters.AddWithValue("@email", email);
                
                command.Parameters.AddWithValue("@status",status );
               
                SqlDataAdapter adapter = new SqlDataAdapter(command);
                adapter.Fill(dt, "admin1");
                connection.Close();

            }
            return dt;
        }


    }
}
