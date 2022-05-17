using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;

namespace TTCSDL
{
    public partial class Main : Form
    {
        [DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]

        private static extern IntPtr CreateRoundRectRgn
        (
            int nLeftRect,
            int nTopRect,
            int nRightRect,
            int nBottomRect,
            int nWidthEllipse,
            int nHeightEllipse
        );
        public Main()
        {
            InitializeComponent();
            Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 25, 25));
            pnlNav.Height = btnHome.Height;
            pnlNav.Top = btnHome.Top;
            pnlNav.Left = btnHome.Left;
            btnHome.BackColor = Color.CadetBlue;
            lblLoad.Text = "Trang chủ";
            this.pnlLoad.Controls.Clear();
            HomeForm homeForm = new HomeForm() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            homeForm.FormBorderStyle = FormBorderStyle.None;
            this.pnlLoad.Controls.Add(homeForm);
            homeForm.Show();
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            pnlNav.Height = btnLogout.Height;
            pnlNav.Top = btnLogout.Top;
            btnLogout.BackColor = Color.CadetBlue;
            DialogResult dialogResult = MessageBox.Show("Bạn có muốn đăng xuất hay không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if(dialogResult == DialogResult.No)
            {
                btnHome_Click(sender, e);
                btnLogout.BackColor = Color.Teal;
            }
            else if(dialogResult == DialogResult.Yes)
            {
                this.Hide();
                LoginForm loginForm = new LoginForm();
                loginForm.ShowDialog();
                this.Close();
            }
        }

        private void showLoad(Form form, string txt)
        {
            lblLoad.Text = txt;
            this.pnlLoad.Controls.Clear();
            form.Dock = DockStyle.Fill;
            form.TopLevel = false;
            form.TopMost = true;
            form.FormBorderStyle = FormBorderStyle.None;
            this.pnlLoad.Controls.Add(form);
            form.Show();
        }

        private void btnHome_Click(object sender, EventArgs e)
        {
            pnlNav.Height = btnHome.Height;
            pnlNav.Top = btnHome.Top;
            pnlNav.Left = btnHome.Left;
            btnHome.BackColor = Color.CadetBlue;
            //
            showLoad(new HomeForm(), "Trang chủ");
        }

        private void btnThongTin_Click(object sender, EventArgs e)
        {
            pnlNav.Height = btnThongTin.Height;
            pnlNav.Top = btnThongTin.Top;
            btnThongTin.BackColor = Color.CadetBlue;
            //
            showLoad(new ThongTin(), "Thông tin");
        }

        private void btnDeTai_Click(object sender, EventArgs e)
        {
            pnlNav.Height = btnDeTai.Height;
            pnlNav.Top = btnDeTai.Top;
            btnDeTai.BackColor = Color.CadetBlue;
            //
            DataTable dt = new DataTable();
            showLoad(new DeTai(), "Đề tài");
        }

        private void btnNSu_Click(object sender, EventArgs e)
        {
            pnlNav.Height = btnNSu.Height;
            pnlNav.Top = btnNSu.Top;
            btnNSu.BackColor = Color.CadetBlue;
            //
            showLoad(new NhanSu(), "Nhân sự");
        }

        private void btnTke_Click(object sender, EventArgs e)
        {
            pnlNav.Height = btnTke.Height;
            pnlNav.Top = btnTke.Top;
            btnTke.BackColor = Color.CadetBlue;
            //
            showLoad(new ThongKe(), "Thống kê");
        }

        private void btnPheDuyet_Click(object sender, EventArgs e)
        {
            pnlNav.Height = btnPheDuyet.Height;
            pnlNav.Top = btnPheDuyet.Top;
            btnPheDuyet.BackColor = Color.CadetBlue;
            //
            showLoad(new PheDuyet(), "Phê duyệt");
        }


        private void btnHome_Leave(object sender, EventArgs e)
        {
            btnHome.BackColor = Color.Teal;
        }

        private void btnThongTin_Leave(object sender, EventArgs e)
        {
            btnThongTin.BackColor = Color.Teal;
        }

        private void btnDeTai_Leave(object sender, EventArgs e)
        {
            btnDeTai.BackColor = Color.Teal;
        }

        private void btnNSu_Leave(object sender, EventArgs e)
        {
            btnNSu.BackColor = Color.Teal;
        }

        private void btnTke_Leave(object sender, EventArgs e)
        {
            btnTke.BackColor = Color.Teal;
        }

        private void btnPheDuyet_Leave(object sender, EventArgs e)
        {
            btnPheDuyet.BackColor = Color.Teal;
        }

        private void btnLogout_Leave(object sender, EventArgs e)
        {
            btnLogout.BackColor = Color.Teal;
        }

        private void pnlLoad_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Main_Load(object sender, EventArgs e)
        {
            string quyen;
            Modify modify = new Modify();
        }
    }
}
