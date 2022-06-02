using System;
using System.Collections.Generic;
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


namespace TTCSDL
{
    public partial class DangKyTK : Form
    {
        Random rnd = new Random();
        public int code;
        string quyen = "user";
        public DangKyTK()
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
            message.Subject = "XÁC THỰC TÀI KHOẢN!";
            message.Body = "Hãy điền đoạn mã này vào hộp ký tự xác thực đăng kí tài khoản\n" + code + "\nCảm ơn rất nhiều!";

            smtp.Port = 587;
            smtp.Host = "smtp.gmail.com";
            smtp.EnableSsl = true;
            smtp.UseDefaultCredentials = false;
            smtp.Credentials = new NetworkCredential("khactuan2327@gmail.com", p);
            smtp.DeliveryMethod = SmtpDeliveryMethod.Network;
            smtp.Send(message);
            MessageBox.Show("Mã xác thực đã được gửi tới email của bạn!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void DangKyTK_Load(object sender, EventArgs e)
        {
            pnlXacThuc.Visible = false;
            message.Visible = false;
        }

        private void message_TextChanged(object sender, EventArgs e)
        {
            
        }
        //Nút đăng ký
        private void guna2Button2_Click(object sender, EventArgs e)
        {
            if (txtxt.Text == code.ToString())
            {
                string query = "INSERT INTO DANGNHAP VALUES( '" + user.Text + "','" + pass.Text + "','" + email.Text + "','" + txtmk.Text + "','" + quyen + "')";
                modify.Command(query);
                if (MessageBox.Show("Bạn đã đăng ký tài khoản thành công!", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information) == DialogResult.OK)
                {
                    this.Hide();
                    LoginForm loginForm = new LoginForm();
                    loginForm.ShowDialog();
                    this.Close();
                }
            }
            else
            {
                MessageBox.Show("Mã xác thực không chính xác, vui lòng kiểm tra lại!", "Cảnh Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            
        }

        private bool CheckTextBoxes()
        {
            if (user.Text == "") { MessageBox.Show("Vui lòng nhập tên người dùng bạn đăng kí!"); return false; }
            if (email.Text == "") { MessageBox.Show("Vui lòng nhập email bạn sử dụng!"); return false; }
            if (pass.Text == "") { MessageBox.Show("Vui lòng nhập mật khẩu!"); return false; }
            if (txtmk.Text == "") { MessageBox.Show("Vui lòng nhập mã khoa!"); return false; }
            return true;
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            CheckTextBoxes();
            string eml = email.Text;
            try
            {
                if (eml.Trim() == "")
                {
                    MessageBox.Show("Vui lòng nhập email!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    mail();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Tài khoản đã tồn tài, vui lòng kiểm tra lại!");
            }
            pnlXacThuc.Visible = true;
        }

        private void newPass_TextChanged(object sender, EventArgs e)
        {
            if (newPass.Text == pass.Text)
            {
                message.Visible = true;
                message.Text = "Mật khẩu chính xác!";
                message.ForeColor = Color.Green;
            }
            else if (newPass.Text != pass.Text)
            {
                message.Visible = true;
                message.Text = "Mật khẩu không chính xác!";
                message.ForeColor = Color.Red;
            }
        }
    }
}
