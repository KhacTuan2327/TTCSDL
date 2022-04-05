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
        Modify modify = new Modify();
        private void dangNhap_Click(object sender, EventArgs e)
        {
            string tk = user.Text;
            string mk = pass.Text;
            if(tk.Trim() == "")
            {
                MessageBox.Show("Vui lòng nhập tài khoản!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else if(mk.Trim() == "")
            {
                MessageBox.Show("Vui lòng nhập mật khẩu!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                string query = "select * from NGUOIDUNG where TAIKHOAN = '" + tk + "' and MATKHAU = '" + mk + "'";
                if(modify.UserLogins(query).Count != 0)
                {
                    MessageBox.Show("Đăng nhập thành công!");
                }
                else
                {
                    MessageBox.Show("Tài khoản hoặc mật khẩu không chính xác!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
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
            ForgotPass showQuenMk = new ForgotPass();
            showQuenMk.ShowDialog();
            this.Close();
        }

        private void exit_Click(object sender, EventArgs e)//Thoát
        {
            Application.Exit();
        }

    }
}
