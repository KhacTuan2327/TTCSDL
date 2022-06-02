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
    public partial class ThongKeCB : Form
    {
        Modify modify = new Modify();
        Khoa khoa;

        Connection cn = new Connection();
        SqlConnection cnn;
        SqlCommand cm;
        SqlDataAdapter da;
        public ThongKeCB()
        {
            InitializeComponent();
            dataTK.DataSource = modify.Table("SELECT CAPQUANLY.MACAP as 'Mã cấp quản lý', CAPQUANLY.TENCAP as 'Tên cấp quản lý', detai.MADT as 'Mã đề tài', detai.TENDT as 'Tên đề tài', CANBO.TENCB as 'Tên chủ nhiệm', DETAI.NGAYDANGKI as 'Ngày đăng ký', DETAI.KINHPHI as 'Kinh phí' from  canbo, DETAI, CAPQUANLY where CANBO.MACB = DETAI.MACB and DETAI.MACAP = CAPQUANLY.MACAP and CAPQUANLY.MACAP = N'CB'");
            lbSL.Text = lableSL();
        }

        public string lableSL()
        {
            cnn = Connection.getConnection();
            cnn.Open();

            cm = new SqlCommand("select count(detai.madt) from  canbo, DETAI, CAPQUANLY where CANBO.MACB = DETAI.MACB and DETAI.MACAP = CAPQUANLY.MACAP and CAPQUANLY.MACAP = N'CB'", cnn);
            string dr = cm.ExecuteScalar().ToString();
            return dr;
        }

        private void dataTK_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

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

        private void ThongKeCB_Load(object sender, EventArgs e)
        {
            string query = "SEARCH_DT'" + search.Text + "'";
            dataTK.DataSource = modify.Table(query);
        }
    }
}
