using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace QUANLYBANVEMAYBAY
{
    public partial class DoiMatKhau : Form
    {
        public DoiMatKhau()
        {
            InitializeComponent();
        }

        public string manv;
        public string tennv;

        Connection cn = new Connection();
        private int doiMatKhau(string matkhaumoi)
        {
            string sqlktmk = "select matkhau from NHANVIEN where manv='" + this.manv + "'";
            DataTable dt = cn.ExecuteData(sqlktmk);
            if (dt.Rows.Count > 0)
            {
                if (dt.Rows[0][0].ToString().Trim() == txtmkcu.Text.Trim())
                {
                    string sql = "update NHANVIEN set matkhau ='" + matkhaumoi + "' where manv='" + this.manv + "'";
                    return cn.ExecuteNonQuery(sql);
                }
                else
                {
                    return -1;
                }
            }
            else
            {
                return -1;
            }
        }


        private void DoiMatKhau_Load(object sender, EventArgs e)
        {
            txtuser.Text = manv;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (txtmkcu.Text.Trim() == txtmkmoi.Text.Trim())
            {
                return;
            }

            if (txtxnmkmoi.Text.Trim() != txtmkmoi.Text.Trim())
            {
                MessageBox.Show("Xác nhận mật khẩu sai");
                return;
            }

            if (doiMatKhau(txtmkmoi.Text.Trim()) != -1)
            {
                MessageBox.Show("Đổi mật khẩu thành công");
                this.Close();
            }
            else
            {
                MessageBox.Show("Đổi mật khẩu thất bại");
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
