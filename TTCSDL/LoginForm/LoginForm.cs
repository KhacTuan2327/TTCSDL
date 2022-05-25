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
            DataTable dt = new DataTable();
            dt = modify.Table(query);
            if (modify.UserLogins(query).Count != 0)
            {
                this.Hide();
                Main showMainMenu = new Main(dt.Rows[0][0].ToString(),dt.Rows[0][1].ToString(), dt.Rows[0][2].ToString(), dt.Rows[0][3].ToString(), dt.Rows[0][4].ToString());
                showMainMenu.ShowDialog();
                this.Close();
            }
            else
            {
                MessageBox.Show("Tài khoản hoặc mật khẩu không chính xác!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void linkLabel1_LinkClicked_1(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
            ForgotPass showQuenMk = new ForgotPass();
            showQuenMk.ShowDialog();
            this.Close();
        }

        private void checkShow_CheckedChanged(object sender, EventArgs e)
        {
            if (checkShow.Checked == true)
            {
                pass.UseSystemPasswordChar = false;
            }
            else if(checkShow.Checked == false)
            {
                pass.UseSystemPasswordChar = true;
            }
        }

        private void pass_TextChanged(object sender, EventArgs e)
        {
            pass.UseSystemPasswordChar = true;
        }
    }
}
