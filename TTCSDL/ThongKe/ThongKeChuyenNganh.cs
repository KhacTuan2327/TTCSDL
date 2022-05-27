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
    public partial class ThongKeChuyenNganh : Form
    {
        public ThongKeChuyenNganh()
        {
            InitializeComponent();
        }

        Modify modify = new Modify();
        Khoa khoa;


        Connection cn = new Connection();
        SqlConnection cnn;
        SqlCommand cm;
        SqlDataAdapter da;



        public void ShowCombobox()
        {
            cnn = Connection.getConnection();
            cnn.Open();
            cm = new SqlCommand("Select * from chuyennganh", cnn);
            var dr = cm.ExecuteReader();
            var dt = new DataTable();
            dt.Load(dr);
            dr.Dispose();
            cbbnganh.DisplayMember = "tencn";
            cbbnganh.DataSource = dt;

        }

        private void ThongKeChuyenNganh_Load(object sender, EventArgs e)
        {
            ShowCombobox();
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


        public string lableSL()
        {
            cnn = Connection.getConnection();
            cnn.Open();
            cm = new SqlCommand("TK_SLNg N'" + cbbnganh.Text + "'", cnn);
            string dr = cm.ExecuteScalar().ToString();
            return dr;
        }

        private void cbbkhoa_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbbnganh.SelectedIndex != -1)
            {
                dataTK.DataSource = modify.Table("TKe_Nganh N'" + cbbnganh.Text + "'");
                lbSL.Text = lableSL();
            }
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
