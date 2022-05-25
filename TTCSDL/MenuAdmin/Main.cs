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
        string tk = "", mk= "", eml= "", makhoa="", quyen="";
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

        public Main(string tk, string mk, string eml, string makhoa, string quyen)
        {
            InitializeComponent();
            this.tk = tk;
            this.mk = mk;
            this.eml = eml;
            this.makhoa = makhoa;
            this.quyen = quyen;
        }
        private void setBackColorMenuItem(Panel pnl, Button btn)
        {
            pnl.BackColor = Color.White;
            pnl.Height = btn.Height;
            pnl.Top = btn.Top;
            btn.BackColor = Color.CadetBlue;
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
            setBackColorMenuItem(pnlNav, btnHome);
            pnlNav.Left = btnHome.Left;
            //
            showLoad(new HomeForm(), "Trang chủ");
        }

        private void btnThongTin_Click(object sender, EventArgs e)
        {
            setBackColorMenuItem(pnlNav, btnThongTin);
            //
            showLoad(new ThongTin(), "Thông tin");
        }

        private void btnDeTai_Click(object sender, EventArgs e)
        {
            setBackColorMenuItem(pnlNav,btnDeTai);
            //
            DataTable dt = new DataTable();
            showLoad(new DeTai(makhoa, quyen), "Đề tài");
        }

        private void btnNSu_Click(object sender, EventArgs e)
        {
            setBackColorMenuItem(pnlNav, btnNSu);
            //
            showLoad(new NhanSu(), "Nhân sự");
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
        private void btnTKe_Click(object sender, EventArgs e)
        {
            setBackColorMenuItem(pnlNav, btnTKe);
            //
            showLoad(new ThongKe(), "Thống kê");
        }

        private void btnPDuyet_Leave(object sender, EventArgs e)
        {
            btnPDuyet.BackColor = Color.Teal;
        }

        private void btnTKe_Leave(object sender, EventArgs e)
        {
            btnTKe.BackColor = Color.Teal;
        }

        private void btnPDuyet_Click(object sender, EventArgs e)
        {
            setBackColorMenuItem(pnlNav, btnPDuyet);
            //
            if (quyen == "user")
            {
                MessageBox.Show("Bạn không có quyền phê duyệt đề tài", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Question);
                btnPDuyet.Visible = false;
                btnHome_Click(sender, e);
                btnLogout.BackColor = Color.Teal;
            }
            else if (quyen == "admin")
            {
                showLoad(new PheDuyet(), "Phê duyệt");
            }
//            showLoad(new PheDuyet(), "Phê duyệt");
        }
    }
}
