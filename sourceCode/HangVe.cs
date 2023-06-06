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
    public partial class HangVe : Form
    {
        public HangVe()
        {
            InitializeComponent();
        }

        Connection cn = new Connection();
        private void frm_ThemHangVe_Load(object sender, EventArgs e)
        {
            comboBox1.DataSource = cn.ExecuteData("select * from HANGVE");
            comboBox1.DisplayMember = "MAHANGVE";
            comboBox1.ValueMember = "MAHANGVE";
            
        }
        public int INSERT(string MAHANGVE, string TENHANGVE, int PHANTRAMDONGIA)
        {
            string sql = "INSERT INTO HANGVE(MAHANGVE,TENHANGVE,PHANTRAMDONGIA) VALUES (N'" + MAHANGVE + "',N'" + TENHANGVE + "','" +PHANTRAMDONGIA + "')";
            return cn.ExecuteNonQuery(sql);
        }
        public int UPDATE(string MAHANGVE, string TENHANGVE, int PHANTRAMDONGIA)
        {
            string sql = "UPDATE HANGVE SET [MAHANGVE]=" + MAHANGVE + ",[TENHANGVE]=" + TENHANGVE +",[PHANTRAMDONGIA]=" + PHANTRAMDONGIA + " WHERE [MAHANGVE]=N'" + MAHANGVE + "'";
            return cn.ExecuteNonQuery(sql);
        }
        public int Delete(string MAHANGVE)
        {
            string sql = "DELETE FROM HANGVE WHERE [MAHANGVE]=N'" + MAHANGVE + "'";
            return cn.ExecuteNonQuery(sql);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                if (textBox1.Text != "" && textBox2.Text != "" &&textBox3.Text!="")
                    UPDATE(textBox1.Text, textBox2.Text,Int32.Parse(textBox3.Text));
                comboBox1.DataSource = cn.ExecuteData("select * from HANGVE");
                comboBox1.DisplayMember = "MAHANGVE";
                comboBox1.ValueMember = "MAHANGVE";
                
            }
            catch { }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                if (textBox1.Text != "" && textBox2.Text != ""&&textBox3.Text!="")
                    INSERT(textBox1.Text, textBox2.Text,Int32.Parse( textBox3.Text));
                comboBox1.DataSource = cn.ExecuteData("select * from HANGVE");
                comboBox1.DisplayMember = "MAHANGVE";
                comboBox1.ValueMember = "MAHANGVE";
                
            }
            catch { }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            textBox3.Text = comboBox1.SelectedItem.ToString();//ma hang ve
            textBox2.Text = comboBox1.Text;//ten hang ve
            textBox1.Text = comboBox1.Text;//phan tram don gia

        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
    }
}
