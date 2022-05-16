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
    public partial class ThongKe : Form
    {
        public ThongKe()
        {
            InitializeComponent();
            customizeDesing();
        }

        Modify modify = new Modify();
        Khoa khoa;

        private void ThongKe_Load(object sender, EventArgs e)
        {

        }

        private void customizeDesing()
        {
            panelDonVi.Visible = false;
            panelCapQuanLy.Visible = false;
            dataTK.DataSource = modify.Table("Select * from KHOA");
        }

        private void hideSubMenu()
        {
            if (panelDonVi.Visible == true)
                panelDonVi.Visible = false;
            if (panelCapQuanLy.Visible == true)
                panelCapQuanLy.Visible = false;
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

        private void btnDonVi_Click(object sender, EventArgs e)
        {
            showSubMenu(panelDonVi);
        }

        private void btnCapQuanLy_Click_2(object sender, EventArgs e)
        {
            showSubMenu(panelCapQuanLy);
        }

        private void btnKhoa_Click(object sender, EventArgs e)
        {
            panelMenu.Visible = false;
            dataTK.DataSource = modify.Table("select khoa.makhoa as MAKHOA, tenkhoa, tenbm AS TENBOMON, tendt AS TENDETAI, canbo.macb AS MACHUNHIEM, canbo.tencb AS TENCHUNHIEM , trangthai AS TRANGTHAI from khoa, bomon, canbo, detai where bomon.makhoa = khoa.makhoa and canbo.mabm = bomon.mabm and detai.macb = canbo.macb order by makhoa asc");
        }
         
        private void dataTK_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void panel_main_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnBoMon_Click(object sender, EventArgs e)
        {
            panelMenu.Visible = false;
            dataTK.DataSource = modify.Table("select bomon.mabm, bomon.tenbm, canbo.macb, canbo.tencb, tendt, trangthai from khoa, bomon, canbo, detai where canbo.mabm = bomon.mabm and detai.macb = canbo.macb order by mabm");
        }

        private void btnNN_Click(object sender, EventArgs e)
        {
            panelMenu.Visible = false;
            dataTK.DataSource = modify.Table("SELECT CAPQUANLY.MACAP, CAPQUANLY.TENCAP, detai.MADT, detai.TENDT, CANBO.TENCB as TENCHUNHIEM from  canbo, DETAI, CAPQUANLY where CANBO.MACB = DETAI.MACB and DETAI.MACAP = CAPQUANLY.MACAP and CAPQUANLY.MACAP = N'CNN'");
        }

        private void btnBo_Click(object sender, EventArgs e)
        {
            panelMenu.Visible = false;
            dataTK.DataSource = modify.Table("SELECT CAPQUANLY.MACAP, CAPQUANLY.TENCAP, detai.MADT, detai.TENDT, CANBO.TENCB as TENCHUNHIEM from  canbo, DETAI, CAPQUANLY where CANBO.MACB = DETAI.MACB and DETAI.MACAP = CAPQUANLY.MACAP and CAPQUANLY.MACAP = N'CB'");
        }

        private void btnHV_Click(object sender, EventArgs e)
        {
            panelMenu.Visible = false;
            dataTK.DataSource = modify.Table("SELECT CAPQUANLY.MACAP, CAPQUANLY.TENCAP, detai.MADT, detai.TENDT, CANBO.TENCB as TENCHUNHIEM from  canbo, DETAI, CAPQUANLY where CANBO.MACB = DETAI.MACB and DETAI.MACAP = CAPQUANLY.MACAP and CAPQUANLY.MACAP = N'CHV'");
        }

        private void btnCS_Click(object sender, EventArgs e)
        {
            panelMenu.Visible = false;
            dataTK.DataSource = modify.Table("SELECT CAPQUANLY.MACAP, CAPQUANLY.TENCAP, detai.MADT, detai.TENDT, CANBO.TENCB as TENCHUNHIEM from  canbo, DETAI, CAPQUANLY where CANBO.MACB = DETAI.MACB and DETAI.MACAP = CAPQUANLY.MACAP and CAPQUANLY.MACAP = N'CCS'");
        }

        private void btnChuyenNganh_Click(object sender, EventArgs e)
        {
            panelMenu.Visible = false;
            dataTK.DataSource = modify.Table("select CHUYENNGANH.MANGANH, CHUYENNGANH.TENCN, DETAI.MADT, detai.tendt, CANBO.TENCB, trangthai from CHUYENNGANH, DETAI, CANBO where CANBO.MACB = DETAI.MACB and DETAI.MANGANH = CHUYENNGANH.MANGANH order by MANGANH asc");
        }
    }
}
