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
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
            customizeDesing();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {

        }
        private void customizeDesing()
        {
            panelKhoa.Visible = false;
            panelDeTai.Visible = false;
        }
        private void hideSubMenu()
        {
            if (panelKhoa.Visible == true)
                panelKhoa.Visible = false;
            if (panelDeTai.Visible == true)
                panelDeTai.Visible = false;
        }
        private void showSubMenu(Panel subMenu)
        {
            if (subMenu.Visible == false)
            {
                hideSubMenu();
                subMenu.Visible = true;
            }
            else
                subMenu.Visible = false;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //code...
            hideSubMenu();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            hideSubMenu();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            hideSubMenu();
        }

        private void btnNhanSu_Click(object sender, EventArgs e)
        {

        }

        private void button6_Click(object sender, EventArgs e)
        {
            hideSubMenu();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            hideSubMenu();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            hideSubMenu();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            hideSubMenu();
        }

        private void Main_Load(object sender, EventArgs e)
        {

        }

        private void btnHoiDong_Click(object sender, EventArgs e)
        {

        }
        private void btnDeTai_Click_1(object sender, EventArgs e)
        {
            showSubMenu(panelDeTai);
        }

        private void thoátChươngTrìnhToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void đăngXuấtToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            LoginForm showLogin = new LoginForm();
            showLogin.ShowDialog();
            this.Close();
        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {

        }

        private Form activeForm = null;
        private void openChildForm(Form childForm)
        {
            if(activeForm != null)
                activeForm.Close();
            activeForm = childForm;
            childForm.TopLevel = false; //luôn phải có khi mở form mới. Là dạng biểu mẫu cao cấp?
            childForm.FormBorderStyle = FormBorderStyle.None; //luôn 
            childForm.Dock = DockStyle.Fill; //luôn
            panel_main.Controls.Add(childForm);
            panel_main.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
        }
        
     
  
        private void btnkhoa_Click(object sender, EventArgs e)
        {
            showSubMenu(panelKhoa);
        }

        private void btndetai_Click_3(object sender, EventArgs e)
        {
            showSubMenu(panelDeTai);
        }

        private void panelkhoa1_Click(object sender, EventArgs e)
        {
            openChildForm(new QuanLyKhoa());
        }

        private void panelkhoa2_Click_1(object sender, EventArgs e)
        {
            openChildForm(new QuanLyBoMon());
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void guna2ControlBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
