using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;
using System.Security.Cryptography;
using System.Text;


namespace QUANLYBANVEMAYBAY
{
    public class Connection
    {

        SqlConnection connect = new SqlConnection(@"Data Source=.\SQLEXPRESS;Initial Catalog=QUANLYBANVEMAYBAY;Integrated Security=True");
        string connectString = @"Data Source=.\SQLEXPRESS;Initial Catalog=QUANLYBANVEMAYBAY;Integrated Security=True";
        public Connection()
        {

            if (connect.State == ConnectionState.Closed)
            {
                connect.Open();
            }
        }

        public Connection(string s)
        {
            connect = new SqlConnection(s);
        }

        public SqlConnection connection()
        {
            SqlConnection conn = new SqlConnection(connectString);
            return conn;
        }
        public void KetNoi()
        {
            if (connect.State == ConnectionState.Closed)
                connect.Open();
        }    
        public void DongKetNoi()
        {
            if (connect.State == ConnectionState.Open)
                connect.Close();
        }  
        public int ExecuteNonQuery(string strQuery)
        {
            int CS = -1;
            try
            {
                int result = 0;
                if (this.connect.State == ConnectionState.Closed)
                {
                    this.connect.Open();
                }
                result = new SqlCommand { Connection = this.connect, CommandType = CommandType.Text, CommandText = strQuery }.ExecuteNonQuery();
                this.connect.Close();
                CS = result;
            }
            catch
            {
                
                return -1;
            }
            return CS;
        }
      
        public DataTable ExecuteData(string strQuery)
        {
            try
            {
                KetNoi();
                SqlDataAdapter adapter = new SqlDataAdapter(strQuery, connect);
                DataSet dataSet = new DataSet();
                adapter.Fill(dataSet);
                DongKetNoi();
                return dataSet.Tables[0];
            }
            catch { return null; }
        }
        public object ExecuteScalar(string sql)
        {
            object CS = null;
            try
            {
                object result = 0;
                KetNoi();
                result = new SqlCommand { Connection = this.connect, CommandType = CommandType.Text, CommandText = sql }.ExecuteScalar();
                DongKetNoi();
                CS = result;
            }
            catch
            {
                return null;

            }
            return CS;
        }
        public int ThemSuaXoa(string sql)
        {
            SqlCommand comm = new SqlCommand(sql, connect);
            KetNoi();
            int ketqua = comm.ExecuteNonQuery();
            DongKetNoi();
            return ketqua;
        }
        public static string Encrypt_md5(string p)
        {

            MD5CryptoServiceProvider mdcsp = new MD5CryptoServiceProvider();
            byte[] b = System.Text.Encoding.UTF8.GetBytes(p);
            b = mdcsp.ComputeHash(b);
            StringBuilder s = new StringBuilder();
            foreach (byte by in b)
            {
                s.Append(by.ToString("x2").ToLower());
            }
            return s.ToString();
        }
        public DataTable LoadDuLieu(string sql)
        {
            SqlDataAdapter da = new SqlDataAdapter(sql, connect);
            DataTable dt = new DataTable();
            da.Fill(dt);
            return dt;
        }
    }
}
