using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QUANLYBANVEMAYBAY
{
    public partial class QuyDinh : Form
    {
        public QuyDinh()
        {
            InitializeComponent();
        }
        Connection ketnoi = new Connection();
        private void bnt_2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frm_Thongso1_Load(object sender, EventArgs e)
        {
            string sql = "select * from TTHAMSO";
            dataGridView1.DataSource = ketnoi.ExecuteData(sql);

        }
        public int INSERT(string ThoiGianBayToiThieu, string SoSanBayTrungGianToiDa, string ThoiGianDungToiThieu, string ThoiGianDungToiDa, string TGChamNhatDatVe, string TGChamNhatHuyDatVe)
        {

            string sql = "INSERT INTO TTHAMSO(ThoiGianBayToiThieu,SoSanBayTrungGianToiDa,ThoiGianDungToiThieu,ThoiGianDungToiDa,TGChamNhatDatVe,TGChamNhatHuyDatVe) VALUES (N'" + ThoiGianBayToiThieu + "',N'" + SoSanBayTrungGianToiDa + "',N'" + ThoiGianDungToiThieu + "',N'" + ThoiGianDungToiDa + "',N'" + TGChamNhatDatVe + "',N'" + TGChamNhatHuyDatVe + "')";

            return ketnoi.ExecuteNonQuery(sql);

        }
        public int Delete(string ThoiGianBayToiThieu)
        {
            string sql = "DELETE FROM TTHAMSO WHERE [ThoiGianBayToiThieu]=N'" + ThoiGianBayToiThieu + "'";
            return ketnoi.ExecuteNonQuery(sql);
        }
        private void bnt_1_Click(object sender, EventArgs e)
        {
            if (INSERT(txt_1.Text, txt_2.Text, txt_3.Text, txt_4.Text, textBox1.Text, textBox2.Text) != -1)
            {
                MessageBox.Show("Đã thêm nhân viên thành công!", "Thông báo");
                frm_Thongso1_Load(new object(), new EventArgs());
            }
            else
            {
                MessageBox.Show("Thêm nhân viên thất bại!", "Thông báo");
            }
        }
        private void dataGridView1_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            txt_1.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            txt_2.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            txt_3.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
            txt_4.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();
            textBox1.Text = dataGridView1.CurrentRow.Cells[4].Value.ToString();
            textBox2.Text = dataGridView1.CurrentRow.Cells[5].Value.ToString();
        }
            private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
              
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (txt_1.Text != "")
            {
                if (MessageBox.Show("Bạn muốn xóa quy định: " + txt_1.Text, "Cảnh báo", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    if (Delete(txt_1.Text) != -1)
                    {
                        MessageBox.Show("Đã xóa quy định thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        frm_Thongso1_Load(new object(), new EventArgs());
                    }
                    else
                    {
                        MessageBox.Show("Xóa quy định thất bại!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
            }
        }

        private void txt_3_TextChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
    }
}
