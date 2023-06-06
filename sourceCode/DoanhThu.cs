using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace QUANLYBANVEMAYBAY
{
    public partial class DoanhThu : Form
    {
        Connection lopchung = new Connection();
     
        public DoanhThu()
        {
            InitializeComponent();   
       
        }

        private void btnTimTheoKhoangtg_Click(object sender, EventArgs e)
        {
            lopchung.connection().Open();
            string sql = "SELECT * FROM DOANHTHUTHANG WHERE 1=1";
            if ((dt_timetruoc.Text != "") && (dt_timesau.Text != ""))
            {
                sql = sql + " AND THANG >= '" + dt_timetruoc.Text  + "'";
            }
            DataSet ds = new DataSet();
            SqlDataAdapter da = new SqlDataAdapter(sql, lopchung.connection());
            da.Fill(ds);
            lopchung.connection().Close();
            dgv_thongke.DataSource = ds.Tables[0];
            dgv_thongke.Refresh();
        }

        private void btn_load_Click(object sender, EventArgs e)
        {
            string sql = "select * from DOANHTHUTHANG";
            dgv_thongke.DataSource = lopchung.ExecuteData(sql);
        }
        private void btn_tinhtong_Click(object sender, EventArgs e)
        {

            int sc = dgv_thongke.Rows.Count;
            Double thanhtien = 0;
            for (int i = 0; i < sc - 1; i++)
                thanhtien += float.Parse(dgv_thongke.Rows[i].Cells["TONGDOANHTHU"].Value.ToString());
            txt_tong.Text = thanhtien.ToString();
        }

        private void frm_thongke_Load(object sender, EventArgs e)
        {

        }
    }
}
