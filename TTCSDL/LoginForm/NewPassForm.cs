﻿using System;
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
    public partial class NewPassForm : Form
    {
        private string mess;
        public NewPassForm()
        {
            InitializeComponent();
            message.Visible = false;
        }
        public NewPassForm(string mess)
        {
            this.mess = mess;
        }
        //Hiển thị mật khẩu
        private void checkShow_CheckedChanged(object sender, EventArgs e)
        {
            if (checkShow.Checked)
            {
                newPass.UseSystemPasswordChar = false;
                verifyPass.UseSystemPasswordChar = false;
            }
            else
            {
                newPass.UseSystemPasswordChar = true;
                verifyPass.UseSystemPasswordChar = true;
            }
        }
        //Hiển thị thông báo khi nhập xác minh mật khẩu
        private void verifyPass_TextChanged(object sender, EventArgs e)
        {
            verifyPass.UseSystemPasswordChar = true;
            if (newPass.Text == verifyPass.Text)
            {
                message.Visible = true;
                message.Text = "Mật khẩu chính xác!";
                message.ForeColor = Color.Green;
            }
            else if (newPass.Text != verifyPass.Text)
            {
                message.Visible = true;
                message.Text = "Mật khẩu không chính xác!";
                message.ForeColor = Color.Red;
            }
        }
        Modify modify = new Modify();
        private void guna2Button1_Click(object sender, EventArgs e)
        {
            ForgotPass fpf = new ForgotPass();
            if(newPass.Text == verifyPass.Text)
            {
                if(MessageBox.Show("Bạn có muốn đổi mật khẩu?", "Thông Báo", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes)
                {
                    try
                    {
                        string queryUpdate = "UPDATE DANGNHAP SET MATKHAU = '" + newPass.Text + "'WHERE EMAIL ='" + mess + "'";
                        modify.Command(queryUpdate);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Lỗi sửa: " + ex.Message);
                    }
                    this.Hide();
                    LoginForm loginForm = new LoginForm();
                    loginForm.ShowDialog();
                    this.Close();
                    fpf.Hide();
                    fpf.Close();
                }
                else
                {
                    return;
                }
            }
            else
            {
                return ;
            }
        }

        private void newPass_TextChanged(object sender, EventArgs e)
        {
            newPass.UseSystemPasswordChar = true;
        }
    }
}
