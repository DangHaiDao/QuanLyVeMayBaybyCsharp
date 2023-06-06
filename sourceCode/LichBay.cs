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
    public partial class LichBay : Form
    {
        public LichBay()
        {
            InitializeComponent();
        }

        Connection connect = new Connection();

        private void frm_ThemChuyenBay_Load(object sender, EventArgs e)
        {

            dataGridView1.DataSource = SelectAll();
            comboBox1.DataSource = connect.ExecuteData("select * from SANBAY ");
            comboBox1.DisplayMember = "TENSANBAY";
            comboBox1.ValueMember = "MASANBAY";
            comboBox1.SelectedIndex = 0;

            comboBox2.DataSource = connect.ExecuteData("select MASANBAY, TENSANBAY.SANBAY from CHUYENBAY, SANBAY where SANBAY.MASANBAY = CHUYENBAY.MASANBAYDEN and MASANBAYDI='" + comboBox1.SelectedValue + "' ");
            comboBox2.DisplayMember = "TENSANBAY";
            comboBox2.ValueMember = "MASANBAY";
        }
        public DataTable SelectAll()
        {
            return connect.ExecuteData("select * from CHUYENBAY");
        }
        public int INSERT(string MACHUYENBAY, string MASANBAYDI, string MASANBAYDEN, DateTime NGAYGIO, int THOIGIANBAY, int SOLUONGGHEHANG1, int SOLUONGGHEHANG2)
        {
            string sql = "INSERT INTO CHUYENBAY(MACHUYENBAY,MASANBAYDI,MASANBAYDEN,NGAYGIO,THOIGIANBAY,SOLUONGGHEHANG1,SOLUONGGHEHANG2,GIAVE) VALUES (N'" + MACHUYENBAY + "',N'" + MASANBAYDI + "',N'" + MASANBAYDEN + "',N'" + NGAYGIO.ToString("MM/dd/yyyy") + "'," + THOIGIANBAY + "," + SOLUONGGHEHANG1 + "," + SOLUONGGHEHANG2 + ")";
            return connect.ExecuteNonQuery(sql);
        }
        public int UPDATE(string MACHUYENBAY, string MASANBAYDI, string MASANBAYDEN, DateTime NGAYGIO, int THOIGIANBAY, int SOLUONGGHEHANG1, int SOLUONGGHEHANG2)
        {
            string sql = "UPDATE CHUYENBAY SET [MACHUYENBAY]='" + MACHUYENBAY + "',[MASANBAYDI]='" + MASANBAYDI + "',[MASANBAYDEN]='" + MASANBAYDEN + "',[NGAYGIO]='" + NGAYGIO.ToString("MM/dd/yyyy") + "',[THOIGIANBAY]=" + THOIGIANBAY + ",[SOLUONGGHEHANG1]=" + SOLUONGGHEHANG1 + ",[SOLUONGGHEHANG2]=" + SOLUONGGHEHANG2 + " WHERE [MACHUYENBAY]=N'" + MACHUYENBAY + "'";
            return connect.ExecuteNonQuery(sql);
        }
        public int Delete(string MACHUYENBAY)
        {
            string sql = "DELETE FROM CHUYENBAY WHERE [MACHUYENBAY]=N'" + MACHUYENBAY + "'";
            return connect.ExecuteNonQuery(sql);
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            comboBox2.Text = "";
            comboBox2.DataSource = connect.ExecuteData("select MASANBAY, TENSANBAY from CHUYENBAY, SANBAY where SANBAY.MASANBAY = CHUYENBAY.MASANBAYDEN and MASANBAYDI='" + comboBox1.SelectedValue + "' ");
            comboBox2.DisplayMember = "TENSANBAY";
            comboBox2.ValueMember = "MASANBAY";
          

        }

        private void button1_Click(object sender, EventArgs e)
        {
            SanBay sb = new SanBay();
            sb.ShowDialog();
            comboBox1.DataSource = connect.ExecuteData("select * from SANBAY ");
            comboBox1.DisplayMember = "TENSANBAY";
            comboBox1.ValueMember = "MASANBAY";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            ChuyenBay tb = new ChuyenBay();
            tb.ShowDialog();
        }

        private void bt_them_Click(object sender, EventArgs e)
        {
            try
            {
                if (INSERT(textBox1.Text, comboBox1.Text, comboBox2.Text, dateTimePicker1.Value, int.Parse(textBox6.Text), int.Parse(textBox2.Text), int.Parse(textBox3.Text)) != -1)
                {
                    dataGridView1.DataSource = SelectAll();
                    MessageBox.Show("Thêm dữ liệu thành công", "Thông báo");
                }
                else
                {
                    MessageBox.Show("Thêm dữ liệu thất bại", "Thông báo");
                }
            }
            catch (Exception m) { MessageBox.Show(m.Message, "Thông báo"); }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridView1_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            try
            {
                textBox1.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
                comboBox1.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
               comboBox2.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
                dateTimePicker1.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();
                textBox6.Text = dataGridView1.CurrentRow.Cells[4].Value.ToString();
                textBox2.Text = dataGridView1.CurrentRow.Cells[5].Value.ToString();
                textBox3.Text = dataGridView1.CurrentRow.Cells[6].Value.ToString();
            }
            catch { }
        }

        private void bt_capnhat_Click(object sender, EventArgs e)
        {
            if (UPDATE(textBox1.Text, comboBox1.Text, comboBox2.Text, dateTimePicker1.Value, int.Parse(textBox6.Text), int.Parse(textBox2.Text), int.Parse(textBox3.Text)) != -1)
            {
                MessageBox.Show("Đã cập nhật thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                frm_ThemChuyenBay_Load(new object(), new EventArgs());
            }
            else
            {
                MessageBox.Show("Cập nhật thất bại!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void bt_xoa_Click(object sender, EventArgs e)
        {
            if (textBox1.Text != "")
            {
                if (MessageBox.Show("Bạn muốn xóa chuyến bay: " + textBox1.Text, "Cảnh báo", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    if (Delete(textBox1.Text) != -1)
                    {
                        MessageBox.Show("Đã xóa chuyến bay thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        frm_ThemChuyenBay_Load(new object(), new EventArgs());
                    }
                    else
                    {
                        MessageBox.Show("Xóa chuyến bay thất bại!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
            }
        }

        private void bt_re_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
            textBox6.Clear();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            SanBay sb = new SanBay();
            sb.ShowDialog();
            comboBox1.DataSource = connect.ExecuteData("select * from SANBAY ");
            comboBox1.DisplayMember = "TENSANBAY";
            comboBox1.ValueMember = "MASANBAY";
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            ChuyenBay tb = new ChuyenBay();
            tb.ShowDialog();
            comboBox2.DataSource = connect.ExecuteData("select MASANBAY, TENSANBAY from CHUYENBAY, SANBAY where SANBAY.MASANBAY = CHUYENBAY.MASANBAYDEN and MASANBAYDI='" + comboBox1.SelectedValue + "' ");
            comboBox2.DisplayMember = "TENSANBAY";
            comboBox2.ValueMember = "MASANBAY";
        }
        private void comboBox3_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
