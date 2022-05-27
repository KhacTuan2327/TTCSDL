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
//using Microsoft.Office.Interop.Excel;
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

        Connection cn = new Connection();
        SqlConnection cnn;
        SqlCommand cm;
        SqlDataAdapter da;

        /*
        public void ShowCombobox()
        {
            cnn = Connection.getConnection();
            cnn.Open();
            cm = new SqlCommand("Select * from Khoa", cnn);
            var dr = cm.ExecuteReader();
            var dt = new DataTable();
            dt.Load(dr);
            dr.Dispose();
            cbbkhoa.DisplayMember = "tenkhoa";
            cbbkhoa.DataSource = dt;
            
        }
        */

        private void ThongKe_Load(object sender, EventArgs e)
        {
            //ShowCombobox();
        }

        private Form activeForm = null;
        private void openChildForm(Form childForm)
        {
            if (activeForm != null)
                activeForm.Close();
            activeForm = childForm;
            childForm.TopLevel = false; //luôn phải có khi mở form mới. Là dạng biểu mẫu cao cấp?
            childForm.FormBorderStyle = FormBorderStyle.None; //luôn 
            childForm.Dock = DockStyle.Fill; //luôn
            panelmain.Controls.Add(childForm);
            panelmain.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
        }


        private void customizeDesing()
        {
            panelDonVi.Visible = false;
            panelCapQuanLy.Visible = false;
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
            openChildForm(new ThongKeKhoa());

        }

        private void dataTK_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void panel_main_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnBoMon_Click(object sender, EventArgs e)
        {
            openChildForm(new ThongKeBoMon());

        }

        private void btnNN_Click(object sender, EventArgs e)
        {
            openChildForm(new ThongKeCNN());
            //dataTK.DataSource = modify.Table("SELECT CAPQUANLY.MACAP, CAPQUANLY.TENCAP, detai.MADT, detai.TENDT, CANBO.TENCB as TENCHUNHIEM from  canbo, DETAI, CAPQUANLY where CANBO.MACB = DETAI.MACB and DETAI.MACAP = CAPQUANLY.MACAP and CAPQUANLY.MACAP = N'CNN'");
        }

        private void btnBo_Click(object sender, EventArgs e)
        {
            openChildForm(new ThongKeCB());
            //dataTK.DataSource = modify.Table("SELECT CAPQUANLY.MACAP, CAPQUANLY.TENCAP, detai.MADT, detai.TENDT, CANBO.TENCB as TENCHUNHIEM from  canbo, DETAI, CAPQUANLY where CANBO.MACB = DETAI.MACB and DETAI.MACAP = CAPQUANLY.MACAP and CAPQUANLY.MACAP = N'CB'");
        }

        private void btnHV_Click(object sender, EventArgs e)
        {
            openChildForm(new ThongKeCHV());
            // dataTK.DataSource = modify.Table("SELECT CAPQUANLY.MACAP, CAPQUANLY.TENCAP, detai.MADT, detai.TENDT, CANBO.TENCB as TENCHUNHIEM from  canbo, DETAI, CAPQUANLY where CANBO.MACB = DETAI.MACB and DETAI.MACAP = CAPQUANLY.MACAP and CAPQUANLY.MACAP = N'CHV'");
        }

        private void btnCS_Click(object sender, EventArgs e)
        {
            openChildForm(new ThongKeCCS());
            //dataTK.DataSource = modify.Table("SELECT CAPQUANLY.MACAP, CAPQUANLY.TENCAP, detai.MADT, detai.TENDT, CANBO.TENCB as TENCHUNHIEM from  canbo, DETAI, CAPQUANLY where CANBO.MACB = DETAI.MACB and DETAI.MACAP = CAPQUANLY.MACAP and CAPQUANLY.MACAP = N'CCS'");
        }

        private void btnChuyenNganh_Click(object sender, EventArgs e)
        {
            openChildForm(new ThongKeChuyenNganh());
            // dataTK.DataSource = modify.Table("select CHUYENNGANH.MANGANH, CHUYENNGANH.TENCN, DETAI.MADT, detai.tendt, CANBO.TENCB, trangthai from CHUYENNGANH, DETAI, CANBO where CANBO.MACB = DETAI.MACB and DETAI.MANGANH = CHUYENNGANH.MANGANH order by MANGANH asc");
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
                //export2Excel(dataTK, saveFileDialog1.FileName);
            }
        }

        private void cbbkhoa_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void search_TextChanged(object sender, EventArgs e)
        {

        }

        private void panelmain_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
