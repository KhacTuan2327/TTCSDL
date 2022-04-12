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
    public partial class ForgotPass : Form
    {
        public ForgotPass()
        {
            InitializeComponent();
        }
        Modify modify = new Modify();
        private void layMk_Click(object sender, EventArgs e)
        {
            string eml = email.Text;
            if (eml.Trim() == "")
            {
                MessageBox.Show("Vui lòng nhập email!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                string queryEmail = "select * from DANGNHAP where EMAIL = '" + eml + "'";
                if (modify.UserLogins(queryEmail).Count != 0)
                {
                    passW.Text = "";
                }
                else
                {
                    MessageBox.Show("Email này không tồn tại!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
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
