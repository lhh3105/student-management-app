using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLSV_L1
{
    internal class DB_Score
    {
        private string myconnectstring = "Data Source=DESKTOP-09KCOMQ\\SQLEXPRESS;Initial Catalog=tet;Integrated Security=True;Encrypt=False";
        public DataSet Mydataset()
        {
            DataSet ds = new DataSet();
            using (SqlConnection conn = new SqlConnection(myconnectstring))
            {
                conn.Open();
                string myquery = "SELECT * FROM score";
                SqlCommand cmd = new SqlCommand(myquery, conn);
                SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(cmd);
                sqlDataAdapter.Fill(ds, "score");
                conn.Close();
            }
            return ds;
        }
        public DataSet Mydataset1()
        {
            DataSet ds = new DataSet();
            using (SqlConnection conn = new SqlConnection(myconnectstring))
            {
                conn.Open();
                string myquery = "SELECT student.id, student.name, score.courseName, score.score, score.description " +
                           "FROM student " +
                           " INNER JOIN score ON student.id = score.studentID";
                SqlCommand cmd = new SqlCommand(myquery, conn);
                SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(cmd);
                sqlDataAdapter.Fill(ds, "score");
                conn.Close();
            }
            return ds;
        }

        public DataSet FilterByCoursename(string coursename,string semester)
        {
            DataSet ds = new DataSet();
            using (SqlConnection conn = new SqlConnection(myconnectstring))
            {
                conn.Open();
                string myquery = "SELECT * FROM mykq WHERE coursename = @coursename and semester = @semester";
                SqlCommand cmd = new SqlCommand(myquery, conn);
                cmd.Parameters.AddWithValue("@coursename", coursename);
                cmd.Parameters.AddWithValue("@semester", semester);
                SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(cmd);
                sqlDataAdapter.Fill(ds, "mykq");
                conn.Close();
            }
            return ds;
        }
        public DataSet ScoreByStudent(string studentID, string semester)
        {
            DataSet ds = new DataSet();
            using (SqlConnection conn = new SqlConnection(myconnectstring))
            {
                conn.Open();
                string myquery = "SELECT * FROM mykq WHERE id = @studentID and semester = @semester";
                SqlCommand cmd = new SqlCommand(myquery, conn);
                cmd.Parameters.AddWithValue("@studentID",studentID);
                cmd.Parameters.AddWithValue("@semester", semester);
                SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(cmd);
                sqlDataAdapter.Fill(ds, "mykq");
                conn.Close();
            }
            return ds;
        }

        public bool existRecord(string studentid,string coursename)
        {
            using (SqlConnection conn = new SqlConnection(myconnectstring))
            {
                conn.Open();
                string checkID = "SELECT COUNT(*) FROM score WHERE studentID = @studentID AND courseName = @courseName";
                SqlCommand cmd = new SqlCommand(checkID, conn);
                cmd.Parameters.AddWithValue("@studentID", studentid);
                cmd.Parameters.AddWithValue("@courseName", coursename);
                int count = (int)cmd.ExecuteScalar();
                if (count >= 1) return true;

                conn.Close();
            }
            return false;
        }
        public List<string> getCourseByStudentID(string studentid)
        {
            List<string> list = new List<string>();
            DataSet ds = new DataSet();
            using (SqlConnection conn = new SqlConnection(myconnectstring))
            {
                conn.Open();
                string myquery = "SELECT score.courseName FROM score WHERE studentID = @studentID ";
                SqlCommand cmd = new SqlCommand(myquery, conn);
                cmd.Parameters.AddWithValue("@studentID", studentid);
                SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(cmd);
                sqlDataAdapter.Fill(ds, "score");
                conn.Close();
            }
            DataTable dt = ds.Tables[0];
            foreach (DataRow row in dt.Rows)
            {
                list.Add(row["courseName"].ToString());
            }

            return list;
        }

        public DataSet getRecord(string studentid,string coursename)
        {
            DataSet dt = new DataSet();
            using (SqlConnection connection = new SqlConnection(myconnectstring))//tạo kết nối
            {
                connection.Open();
                string myquery = "SELECT * FROM score WHERE studentID =" + studentid +" AND courseName= "+coursename;
                SqlCommand command = new SqlCommand(myquery, connection);
                SqlDataAdapter adapter = new SqlDataAdapter(command);
                adapter.Fill(dt, "score");
                connection.Close();

            }
            return dt;
        }

        public bool InsertScore(string studentid, string coursename, string score, string description)
        {
            
            if (existRecord(studentid,coursename))
            {
                bool x = updateRecord(studentid,coursename,score,description);
                return true;
            }

            int score1 = Convert.ToInt32(score);
            using (SqlConnection conn = new SqlConnection(myconnectstring))
            {
                conn.Open();
                string insertData = "INSERT INTO score" +
                    "(studentID,courseName,score, description)" +
                    "VALUES(@studentID,@courseName,@score, @description)";
                SqlCommand cmd = new SqlCommand(@insertData, conn);
                cmd.Parameters.AddWithValue("@studentID", studentid);
                cmd.Parameters.AddWithValue("@courseName", coursename);
             
                cmd.Parameters.AddWithValue("@score", score1);
                cmd.Parameters.AddWithValue("@description", description);
                cmd.ExecuteNonQuery();

                conn.Close();

            }
            return true;


        }
        public bool updateRecord(string studentid, string coursename, string score, string description)
        {
            DataSet dt = new DataSet();
            using (SqlConnection connection = new SqlConnection(myconnectstring))
            {
                connection.Open();
                string myquery = "UPDATE score SET  score=@score, description = @description WHERE studentID = @studentID AND courseName=@courseName";

                SqlCommand command = new SqlCommand(myquery, connection);
                command.Parameters.AddWithValue("@studentID",studentid);
                command.Parameters.AddWithValue("@courseName", coursename);
                int score1 = Convert.ToInt32(score);
                command.Parameters.AddWithValue("@score", score1);
                command.Parameters.AddWithValue("@description", description);
                SqlDataAdapter adapter = new SqlDataAdapter(command);
                adapter.Fill(dt, "score");
                connection.Close();

            }
            return true;
        }
        public bool DeleteScore(string studentID,string courseName)
        {
            DataSet ds1 = new DataSet();
            DataSet ds2 = new DataSet();
            using (SqlConnection conn = new SqlConnection(myconnectstring))
            {
                conn.Open();
                string que1 = "DELETE FROM score WHERE studentID =@studentID AND courseName =@courseName";
                SqlCommand cmd1 = new SqlCommand(que1, conn);
                cmd1.Parameters.AddWithValue("@studentID", studentID);
                cmd1.Parameters.AddWithValue("@courseName", courseName);
                SqlDataAdapter adap1 = new SqlDataAdapter(cmd1);
                adap1.Fill(ds1, "score");
                conn.Close();
            }


            if (!existRecord(studentID,courseName))
            {
                return true;
            }
            return false;
        }
    }
}
