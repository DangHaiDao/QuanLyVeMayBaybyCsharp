using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace QUANLYBANVEMAYBAY
{
    public partial class DatCho : Form
    {
        public DatCho()
        {
            InitializeComponent();
        }
        Connection cn = new Connection();
        private void DatCho_Load(object sender, EventArgs e)
        {         
            cb1.DataSource = cn.ExecuteData("select * from CCHUYENBAY ");
            cb1.ValueMember = "MACHUYENBAY";
            cb1.DisplayMember = "MACHUYENBAY";

            cb2.DataSource = cn.ExecuteData("select * from KKHACHHANG ");
            cb2.ValueMember = "MAKH";
            cb2.DisplayMember = "MAKH";

            cb4.DataSource = cn.ExecuteData("select * from TUYENBAY ");
            cb4.ValueMember = "MATUYENBAY";
            cb4.DisplayMember = "MATUYENBAY";

            cb3.DataSource = cn.ExecuteData("select * from HANGVE ");
            cb3.ValueMember = "mahangve";
            cb3.DisplayMember = "tenhangve";

     
            dataGridView1.DataSource = cn.ExecuteData("select * from DATCHO");
        }     
        public DataTable SelectAll()
        {
            return cn.ExecuteData("select * from CCHUYENBAY");
        }

        public int INSERT(string MAPHIEU, string MAKH, string MACHUYENBAY,string MATUYENBAY, string MAHANGVE, int SOGHEDAT, DateTime NGAYDAT, int GIATIEN)
        {
            string sql = "INSERT INTO DATCHO(MAPHIEU,MAKH,MACHUYENBAY,MATUYENBAY,MAHANGVE,SOGHEDAT,NGAYDAT,GIATIEN) VALUES (N'" + MAPHIEU + "',N'" + MAKH + "',N'" + MACHUYENBAY + "',N'" + MATUYENBAY + "',N'" + MAHANGVE + "',N'" + SOGHEDAT + "',N'" + NGAYDAT.ToString("MM/dd/ yyyy") + "',N'" + GIATIEN + "')";
            return cn.ExecuteNonQuery(sql);
        }
        public int UPDATE(string MAPHIEU, string MAKH, string MACHUYENBAY, string MATUYENBAY, string MAHANGVE, int SOGHEDAT, DateTime NGAYDAT, int GIATIEN)
        {
            string sql = "UPDATE DATCHO SET  MAKH=N'" + MAKH + "', MACHUYENBAY=N'" + MACHUYENBAY + "', MATUYENBAY=N'" + MATUYENBAY + "', MAHANGVE=N'" + MAHANGVE + "', SOGHEDAT=N'" + SOGHEDAT + "', NGAYDAT=N'" + NGAYDAT.ToString("MM/dd/ yyyy") + "', GIATIEN=N'" + GIATIEN + "' WHERE MAPHIEU=N'" + MAPHIEU + "'";
            return cn.ExecuteNonQuery(sql);
        }
        public int Delete(string MAPHIEU)
        {
            string sql = "DELETE FROM DATCHO WHERE [MAPHIEU]=N'" + MAPHIEU + "'";
            return cn.ExecuteNonQuery(sql);
        }

        private void bnt_luu_Click(object sender, EventArgs e)
        {
            if (INSERT(txt1.Text, cb1.Text, cb2.Text,cb4.Text, cb3.Text, int.Parse(txt4.Text), dateTimePicker1.Value, int.Parse(txt5.Text)) != -1)
            {
                MessageBox.Show("Đã thêm phiếu đặt chỗ thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                DatCho_Load(new object(), new EventArgs());
            }
            else
            {
                MessageBox.Show("Thêm phiếu đặt chỗ thất bại!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }          
        private void bnt_capnhat_Click(object sender, EventArgs e)
        {
            if (UPDATE(txt1.Text, cb1.Text, cb2.Text, cb4.Text, cb3.Text, int.Parse(txt4.Text), dateTimePicker1.Value, int.Parse(txt5.Text)) != -1)
            {
                MessageBox.Show("Đã cập nhật phiếu thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
               DatCho_Load(new object(), new EventArgs());
            }
            else
            {
                MessageBox.Show("Cập nhật phiếu thất bại!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void bnt_thoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void bnt_xoa_Click(object sender, EventArgs e)
        {
            if (txt1.Text != "")
            {
                if (MessageBox.Show("Bạn muốn xóa phiếu: " + txt1.Text, "Cảnh báo", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    if (Delete(txt1.Text) != -1)
                    {
                        MessageBox.Show("Đã xóa phiếu thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        DatCho_Load(new object(), new EventArgs());
                    }
                    else
                    {
                        MessageBox.Show("Xóa phiếu thất bại!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            SanBay sb = new SanBay();
            sb.ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            ChuyenBay tb = new ChuyenBay();
            tb.ShowDialog();
        }

        private void txt4_TextChanged(object sender, EventArgs e)
        {
            double sl, gn, tt;
            if (txt3.Text == "")
                gn = 0;
            else
                gn = Convert.ToDouble(txt3.Text);
            if (txt4.Text == "")
                sl = 0;
            else
                sl = Convert.ToDouble(txt4.Text);
            tt = gn * sl;
            txt5.Text = tt.ToString();
        }
        private void dataGridView1_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            try
            {
                txt1.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
                cb1.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
                cb2.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
                cb4.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();
                cb3.Text = dataGridView1.CurrentRow.Cells[4].Value.ToString();
                dateTimePicker1.Text = dataGridView1.CurrentRow.Cells[6].Value.ToString();
                txt4.Text = dataGridView1.CurrentRow.Cells[5].Value.ToString();
                txt5.Text = dataGridView1.CurrentRow.Cells[7].Value.ToString();
              
            }
            catch { }
        }
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {         
              
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void txt1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
