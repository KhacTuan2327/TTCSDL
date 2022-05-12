using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TTCSDL
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        private void LoginForm_Load(object sender, EventArgs e)
        {

        }
        Modify modify = new Modify();
        private void btnlogin_Click_1(object sender, EventArgs e)
        {
            string tk = user.Text;
            string mk = pass.Text;
            string query = "select * from DANGNHAP where TAIKHOAN = '" + tk + "' and MATKHAU = '" + mk + "'";
            if (modify.UserLogins(query).Count != 0)
            {
                this.Hide();
                Main showMainMenu = new Main();
                showMainMenu.ShowDialog();
                this.Close();
            }
            else
            {
                MessageBox.Show("Tài khoản hoặc mật khẩu không chính xác!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void checkShow_CheckedChanged_1(object sender, EventArgs e)
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

        private void linkLabel1_LinkClicked_1(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
            ForgotPass showQuenMk = new ForgotPass();
            showQuenMk.ShowDialog();
            this.Close();
        }
    }
}
