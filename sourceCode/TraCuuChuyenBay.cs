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
    public partial class TraCuuChuyenBay : Form
    {
        public TraCuuChuyenBay()
        {
            InitializeComponent();
        }
        Connection cn = new Connection();
        private void TraCuuChuyenBay_Load(object sender, EventArgs e)
        {
            string sql = "select * from CCHUYENBAY";
            dataGridView1.DataSource = cn.ExecuteData(sql);
        }    
        private void bnt_thoat_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
