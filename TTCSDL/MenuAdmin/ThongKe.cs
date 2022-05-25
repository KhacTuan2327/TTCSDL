using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Office.Interop.Excel;
using app = Microsoft.Office.Interop.Excel.Application;

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
            
            dataTK.DataSource = modify.Table("select bomon.mabm, bomon.tenbm, canbo.macb, canbo.tencb, tendt, trangthai from khoa, bomon, canbo, detai where canbo.mabm = bomon.mabm and detai.macb = canbo.macb order by mabm");
        }

        private void btnNN_Click(object sender, EventArgs e)
        {
            
            dataTK.DataSource = modify.Table("SELECT CAPQUANLY.MACAP, CAPQUANLY.TENCAP, detai.MADT, detai.TENDT, CANBO.TENCB as TENCHUNHIEM from  canbo, DETAI, CAPQUANLY where CANBO.MACB = DETAI.MACB and DETAI.MACAP = CAPQUANLY.MACAP and CAPQUANLY.MACAP = N'CNN'");
        }

        private void btnBo_Click(object sender, EventArgs e)
        {
            dataTK.DataSource = modify.Table("SELECT CAPQUANLY.MACAP, CAPQUANLY.TENCAP, detai.MADT, detai.TENDT, CANBO.TENCB as TENCHUNHIEM from  canbo, DETAI, CAPQUANLY where CANBO.MACB = DETAI.MACB and DETAI.MACAP = CAPQUANLY.MACAP and CAPQUANLY.MACAP = N'CB'");
        }

        private void btnHV_Click(object sender, EventArgs e)
        {
            dataTK.DataSource = modify.Table("SELECT CAPQUANLY.MACAP, CAPQUANLY.TENCAP, detai.MADT, detai.TENDT, CANBO.TENCB as TENCHUNHIEM from  canbo, DETAI, CAPQUANLY where CANBO.MACB = DETAI.MACB and DETAI.MACAP = CAPQUANLY.MACAP and CAPQUANLY.MACAP = N'CHV'");
        }

        private void btnCS_Click(object sender, EventArgs e)
        {
            dataTK.DataSource = modify.Table("SELECT CAPQUANLY.MACAP, CAPQUANLY.TENCAP, detai.MADT, detai.TENDT, CANBO.TENCB as TENCHUNHIEM from  canbo, DETAI, CAPQUANLY where CANBO.MACB = DETAI.MACB and DETAI.MACAP = CAPQUANLY.MACAP and CAPQUANLY.MACAP = N'CCS'");
        }

        private void btnChuyenNganh_Click(object sender, EventArgs e)
        {
            dataTK.DataSource = modify.Table("select CHUYENNGANH.MANGANH, CHUYENNGANH.TENCN, DETAI.MADT, detai.tendt, CANBO.TENCB, trangthai from CHUYENNGANH, DETAI, CANBO where CANBO.MACB = DETAI.MACB and DETAI.MANGANH = CHUYENNGANH.MANGANH order by MANGANH asc");
        }

        private void export2Excel(DataGridView g, string tenTap)
        {
            app obj = new app();
            obj.Application.Workbooks.Add(Type.Missing);
            obj.Columns.ColumnWidth = 25;
            for (int i = 1; i < g.Columns.Count + 1; i++) { obj.Cells[1, i] = g.Columns[i - 1].HeaderText; }
            for (int i = 0; i < g.Rows.Count; i++)
            {
                for (int j = 0; j < g.Columns.Count; j++)
                {
                    if (g.Rows[i].Cells[j].Value != null) { obj.Cells[i + 2, j + 1] = g.Rows[i].Cells[j].Value.ToString(); }
                }
            }
            obj.ActiveWorkbook.SaveCopyAs(tenTap + ".xlsx");
            obj.ActiveWorkbook.Saved = true;
        }

        private void btnExportFile_Click(object sender, EventArgs e)
        {
            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                //gọi hàm ToExcel() với tham số là dtgDSHS và filename từ SaveFileDialog
                export2Excel(dataTK, saveFileDialog1.FileName);
            }
        }
    }
}
