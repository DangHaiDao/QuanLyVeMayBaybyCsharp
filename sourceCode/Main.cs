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
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
        }

        string manv = "";

        public string Manv
        {
            get { return manv; }
            set { manv = value; }
        }

        string tennv = "";

        public string Tennv
        {
            get { return tennv; }
            set { tennv = value; }
        }

        private void frm_Main_Load(object sender, EventArgs e)
        {
            toolStripLabel3.Text = tennv;

        }

        private void MenuThoat_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void MenuNhanVien_Click(object sender, EventArgs e)
        {
            
            NhanVien vn = new NhanVien();
            vn.TopLevel = false;
            panel1.Controls.Add(vn);
            vn.Show();
        }

        private void MenuTraCuu_Click(object sender, EventArgs e)
        {
           TraCuuChuyenBay vn = new TraCuuChuyenBay();
            vn.TopLevel = false;
            panel1.Controls.Add(vn);
            vn.Show();
        }

       

        private void MenuDatCho_Click(object sender, EventArgs e)
        {
            DatCho vn = new DatCho();
            vn.TopLevel = false;
            panel1.Controls.Add(vn);
            vn.Show();
        }

        private void MenuDangXuat_Click(object sender, EventArgs e)
        {
            this.Close();

        }

        private void MenuQuanLyHangKhach_Click(object sender, EventArgs e)
        {
            HanhKhach vn = new HanhKhach();
            vn.TopLevel = false;
            panel1.Controls.Add(vn);
            vn.Show();
        }

        private void MenuTuyenBay_Click(object sender, EventArgs e)
        {
            ChuyenBay vn = new ChuyenBay();
            vn.TopLevel = false;
            panel1.Controls.Add(vn);
            vn.Show();
        }

        private void MenuQuyDinh_Click(object sender, EventArgs e)
        {
            QuyDinh vn = new QuyDinh();
            vn.TopLevel = false;
            panel1.Controls.Add(vn);
            vn.Show();
        }

        private void MenuLichBay_Click(object sender, EventArgs e)
        {
            LichBay vn = new LichBay();
            vn.TopLevel = false;
            panel1.Controls.Add(vn);
            vn.Show();
        }

        private void MenuHangVe_Click(object sender, EventArgs e)
        {
            HangVe vn = new HangVe();
            vn.TopLevel = false;
            panel1.Controls.Add(vn);
            vn.Show();
        }

        private void MenuSanBay_Click(object sender, EventArgs e)
        {
            SanBay vn = new SanBay();
            vn.TopLevel = false;
            panel1.Controls.Add(vn);
            vn.Show();
        }

        private void MenuDoiMatKhau_Click(object sender, EventArgs e)
        {
            DoiMatKhau doimatkhau = new DoiMatKhau();
            doimatkhau.manv = this.manv;
            doimatkhau.tennv = this.tennv;
            doimatkhau.TopLevel = false;
            panel1.Controls.Add(doimatkhau);
            doimatkhau.Show();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            txtdongho.Text = DateTime.Now.ToShortTimeString();
        }

    
        private void quảnLýLịchBayToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LichBay vn = new LichBay();
            vn.TopLevel = false;
            panel1.Controls.Add(vn);
            vn.Show();
        }

    

        private void hạngVéToolStripMenuItem_Click(object sender, EventArgs e)
        {
            HangVe vn = new HangVe();
            vn.TopLevel = false;
            panel1.Controls.Add(vn);
            vn.Show();
        }

      

        private void quảnLýQuyĐịnhToolStripMenuItem_Click(object sender, EventArgs e)
        {
            QuyDinh vn = new QuyDinh();
            vn.TopLevel = false;
            panel1.Controls.Add(vn);
            vn.Show();
        }

        private void báoCáoThôngKêLinhKiênToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DoanhThu vn = new DoanhThu();
            vn.TopLevel = false;
            panel1.Controls.Add(vn);
            vn.Show();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void toolStripLabel2_Click(object sender, EventArgs e)
        {

        }
    }
}
