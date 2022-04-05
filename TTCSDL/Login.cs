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
    public partial class Login : Form
    {
        public static string UserName = "";
        public Login()
        {
            InitializeComponent();
        }
        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }
        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
        private void user_KeyDown(object sender, KeyEventArgs e) //nhấn enter sau khi nhập để chuyển con trỏ xuống điền mật khẩu
        {
            if (e.KeyCode == Keys.Enter)
            {
                pass.Focus();
            }
        }
        private void pass_TextChanged(object sender, EventArgs e)
        {
            
        }
        private void dangNhap_Click(object sender, EventArgs e)
        {
            SqlConnection comn = new SqlConnection(@"Data Source=DESKTOP-CM6N3SA\SQLEXPRESS;Initial Catalog=QUANLYDETAI;Integrated Security=True");
            try
            {
                comn.Open();
                string tk = user.Text;
                string mk = pass.Text;
                string sql = "select * from NGUOIDUNG where TAIKHOAN = '" + tk + "' and MATKHAU = '" + mk + "'";
                SqlCommand cmd = new SqlCommand(sql, comn);
                SqlDataReader data = cmd.ExecuteReader();
                if(data.Read() == true)
                {
                    MessageBox.Show("Đăng nhập thành công!");
                }
                else
                {
                    MessageBox.Show("Đăng nhập thất bại!");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi hệ thống !");
            }
        }
        private void checkBox1_CheckedChanged(object sender, EventArgs e) //hiển thị mật khẩu
        {
            if (checkShow.Checked)
            {
                pass.PasswordChar = (char)0;
            }
            else
            {
                pass.PasswordChar = '*';
            }
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e) //Quên mật khẩu
        {
            this.Hide();
            QuenMatKhau showQuenMk = new QuenMatKhau();
            showQuenMk.ShowDialog();
            this.Close();
        }

        private void exit_Click(object sender, EventArgs e)//Thoát
        {
            Application.Exit();
        }

    }
}
