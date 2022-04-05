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

namespace TTCSDL
{
    public partial class QuenMatKhau : Form
    {
        public QuenMatKhau()
        {
            InitializeComponent();
        }
        private void layMk_Click(object sender, EventArgs e)
        {
            SqlConnection comn = new SqlConnection(@"Data Source=DESKTOP-CM6N3SA\SQLEXPRESS;Initial Catalog=QUANLYDETAI;Integrated Security=True");
            try
            {
                comn.Open();
                string userMail = email.Text;
                string mk = passW.Text;
                string sql = "select EMAIL from NGUOIDUNG where EMAIL = '" + userMail + "'";
                SqlCommand cmd = new SqlCommand(sql, comn);
                SqlDataReader data = cmd.ExecuteReader();
                if (data.Read() == true)
                {
                    passW.Text = "123456";
                }
                else
                {
                    MessageBox.Show("Email không tồn tại!");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi hệ thống !");
            }
        }

        private void passW_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void copy_Click(object sender, EventArgs e)
        {
            Clipboard.SetText(passW.Text);//copy mật khẩu
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Login showLogin = new Login();
            showLogin.ShowDialog();
            this.Close();
        }
    }
}
