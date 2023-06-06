using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace QUANLYBANVEMAYBAY
{
    public partial class SanBay : Form
    {
        public SanBay()
        {
            InitializeComponent();
        }

        Connection cn = new Connection();

        private void bt_them_Click(object sender, EventArgs e)
        {
            if (txt_1.Text != "" && txt_2.Text != "")

                INSERT(txt_1.Text, txt_2.Text);
            dataGridView1.DataSource = SelectAll();
            txt_1.Clear();
            txt_2.Clear();
        }
        public void INSERT(string MASANBAY, string TENSANBAY)
        {
            string sql = "INSERT INTO SANBAY(MASANBAY,TENSANBAY) VALUES (N'" + MASANBAY + "',N'" + TENSANBAY + "')";
            cn.ExecuteNonQuery(sql);
        }
        public void UPDATE(string MASANBAY, string TENSANBAY)
        {
            this.cn.KetNoi();
            string sql = "UPDATE SANBAY SET [MASANBAY]=N'" + MASANBAY + "',[TENSANBAY]=N'" + TENSANBAY + "' WHERE [MASANBAY]=N'" + MASANBAY + "'";
            cn.ExecuteNonQuery(sql);
        }
        public void Delete(string MASANBAY)
        {
            this.cn.KetNoi();
            string sql = "DELETE FROM SANBAY WHERE [MASANBAY]=N'" + MASANBAY + "'";
            cn.ExecuteNonQuery(sql);
        }

        public DataTable SelectAll()
        {
            return cn.ExecuteData("select * from SANBAY");
        }

        private void frm_ThemSanBay_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = SelectAll();
        }

        private void bt_capnhat_Click(object sender, EventArgs e)
        {
            if (txt_1.Text != "" && txt_2.Text != "")

                UPDATE(txt_1.Text, txt_2.Text);
            dataGridView1.DataSource = SelectAll();
        }

        private void dataGridView1_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            txt_1.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            txt_2.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
        }

        private void bt_xoa_Click(object sender, EventArgs e)
        {
            try
            {
                if (txt_1.Text != "")
                    Delete(txt_1.Text);
                dataGridView1.DataSource = SelectAll();
            }
            catch (Exception a)
            {
                MessageBox.Show(a.Message, "Thông báo");
            }
        }
    }
}
