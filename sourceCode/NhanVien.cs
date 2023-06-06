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
    public partial class NhanVien : Form
    {
        public NhanVien()
        {
            InitializeComponent();
        }

        Connection ketnoi = new Connection();
        public int INSERT(string MANV, string TENNHANVIEN, string DIENTHOAI, string DIACHI, string MATKHAU)
        {
            string sql = "INSERT INTO NHANVIEN(MANV,TENNHANVIEN,DIENTHOAI,DIACHI,MATKHAU) VALUES (N'" + MANV + "',N'" + TENNHANVIEN + "',N'" + DIENTHOAI + "',N'" + DIACHI + "',N'" + MATKHAU + "')";

            return ketnoi.ExecuteNonQuery(sql);
        }
        public int UPDATE(string MANV, string TENNHANVIEN, string DIENTHOAI, string DIACHI)
        {
            string sql = "UPDATE NHANVIEN SET TENNHANVIEN=N'" + TENNHANVIEN + "', DIENTHOAI=N'" + DIENTHOAI + "', DIACHI=N'" + DIACHI + "' WHERE MANV=N'" + MANV + "'";
            return ketnoi.ExecuteNonQuery(sql);
        }
        public int Delete(string MANV)
        {
            string sql = "DELETE FROM NHANVIEN WHERE MANV=N'" + MANV + "'";
            return ketnoi.ExecuteNonQuery(sql);
        }
        private void NhanVien_Load(object sender, EventArgs e)
        {
            string sql = "select * from NHANVIEN";
            dataGridView1.DataSource = ketnoi.ExecuteData(sql);
        }
        private void dataGridView1_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            try  
            {
                txt_manv.Text = dataGridView1.CurrentRow.Cells["MANV"].Value.ToString(); 
                txt_tennv.Text = dataGridView1.CurrentRow.Cells["TENNHANVIEN"].Value.ToString();
                txt_dienthoai.Text = dataGridView1.CurrentRow.Cells["DIENTHOAI"].Value.ToString();
                txt_diachi.Text = dataGridView1.CurrentRow.Cells["DIACHI"].Value.ToString();
            }
            catch (Exception j) { MessageBox.Show(j.Message); }
        }

        private void bt_luu_Click(object sender, EventArgs e)
        {
            if (INSERT(txt_manv.Text, txt_tennv.Text, txt_dienthoai.Text, txt_diachi.Text, "123") != -1)
            {
                MessageBox.Show("Đã thêm nhân viên thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                NhanVien_Load(new object(), new EventArgs());
            }
            else
            {
                MessageBox.Show("Thêm nhân viên thất bại!" , "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void bt_capnhat_Click(object sender, EventArgs e)
        {
            if (UPDATE(txt_manv.Text, txt_tennv.Text, txt_dienthoai.Text, txt_diachi.Text) != -1)
            {
                MessageBox.Show("Đã cập nhật nhân viên thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                NhanVien_Load(new object(), new EventArgs());
            }
            else
            {
                MessageBox.Show("Cập nhật nhân viên thất bại!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void bt_themmoi_Click(object sender, EventArgs e)
        {
            txt_tennv.Clear();
            txt_diachi.Clear();
            txt_manv.Clear();
            txt_dienthoai.Clear();        }

        private void btxoa_Click(object sender, EventArgs e)
        {
            if (txt_manv.Text != "")
            {
                if (MessageBox.Show("Bạn muốn xóa nhân viên: " + txt_tennv.Text, "Cảnh báo", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    if (Delete(txt_manv.Text) != -1)
                    {
                        MessageBox.Show("Đã xóa nhân viên thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        NhanVien_Load(new object(), new EventArgs());
                    }
                    else
                    {
                        MessageBox.Show("Xóa nhân viên thất bại!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
            }
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void btxoa_Click_1(object sender, EventArgs e)
        {

        }

        private void bt_capnhat_Click_1(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter_1(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridView1_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
