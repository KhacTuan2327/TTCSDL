using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net;
using System.Net.Mail;
using System.Web;
using System.Configuration;

namespace TTCSDL.LoginForm
{
    public partial class ForgotForm : Form
    {
        string messMail;
        Random rnd = new Random();
        public int code;
        public ForgotForm()
        {
            InitializeComponent();
        }
        Modify modify = new Modify();
        private void mail()
        {
            code = rnd.Next(123123, 999999);
            const string p = "2307200127102001";

            MailMessage message = new MailMessage();
            SmtpClient smtp = new SmtpClient();

            message.From = new MailAddress("khactuan2327@gmail.com");

            //Enter your email blow and also change in database too

            message.To.Add(new MailAddress(email.Text));
            message.Subject = "QUÊN MẬT KHẨU!";
            message.Body = "Hãy điền đoạn mã này vào hộp ký tự xác minh\n" + code + "\nCảm ơn rất nhiều!";

            smtp.Port = 587;
            smtp.Host = "smtp.gmail.com";
            smtp.EnableSsl = true;
            smtp.UseDefaultCredentials = false;
            smtp.Credentials = new NetworkCredential("khactuan2327@gmail.com", p);
            smtp.DeliveryMethod = SmtpDeliveryMethod.Network;
            smtp.Send(message);
            MessageBox.Show("Mã xác nhận đã được gửi tới email!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void sendToEmail_Click(object sender, EventArgs e)
        {
            string eml = email.Text;
            NewPassForm passForm = new NewPassForm(eml);
            if (eml.Trim() == "")
            {
                MessageBox.Show("Vui lòng nhập email!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                string query = "select * from DANGNHAP where EMAIL = '" + eml + "'";
                if (modify.UserLogins(query).Count != 0)
                {
                    mail();
                }
                else
                {
                    MessageBox.Show("Email này không tồn tại!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }

        private void verifyCode_Click(object sender, EventArgs e)
        {
            if (codeVerify.Text == code.ToString())
            {
                NewPassForm newPassForm = new NewPassForm();
                newPassForm.ShowDialog();
            }
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            LoginForm loginForm = new LoginForm();
            loginForm.ShowDialog();
            this.Close();
        }
    }
}
