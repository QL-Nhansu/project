using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
namespace DAL
{
   public class DBConnect
    {
        private static SqlConnection conn;
        private static string strconn;
        public static string DirectoryConnect { set { strconn = value; } }

        //tao ket noi vs sql
        public static SqlConnection Connect()
        {
            try
            {
                string sql = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename="+ strconn + ";Integrated Security=True;Connect Timeout=30";
                SqlConnection conn = new SqlConnection(sql);
                conn.Open();

                return conn;
            }
            catch (SqlException)
            {
                return null;
            }
        }




        //Dua du lieu vao bang
        public static DataTable GetData(string proc)
        {
            try
            {
                conn = Connect();
                if (conn == null) return null;
                DataTable dt = new DataTable();
                SqlDataAdapter da = new SqlDataAdapter(proc, conn);
                da.Fill(dt);
                conn.Close();
                return dt;
            }
            catch (SqlException)
            {
                conn.Close();
                return null;
            }
        }

        //thuc hien thu tuc
        public static int ExecuteNonQuery(string proc, SqlParameter[] para)
        {
            try
            {
                conn = Connect();
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = conn;
                cmd.CommandText = proc;
                cmd.CommandType = CommandType.StoredProcedure;
                if (para != null)
                    cmd.Parameters.AddRange(para);

                int val = cmd.ExecuteNonQuery();
                conn.Close();
                return val;
            }
            catch (SqlException)
            {
                return 0;
            }
        }
    }
}
