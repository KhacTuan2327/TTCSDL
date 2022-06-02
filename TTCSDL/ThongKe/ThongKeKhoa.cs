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
    public partial class ThongKeKhoa : Form
    {
        public ThongKeKhoa()
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

        private void customizeDesing()
        {
            dataTK.DataSource = modify.Table("ThongKe_Khoa");
        }

        private void ThongKeKhoa_Load_1(object sender, EventArgs e)
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

        private void btnExportFile_Click(object sender, EventArgs e)
        {
            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                //gọi hàm ToExcel() với tham số là dtgDSHS và filename từ SaveFileDialog
                export2Excel(dataTK, saveFileDialog1.FileName);
            }
        }

        private void dataTK_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        // thống kê full:
        //thống kê tổng sl:
        public string lableSL()
        {
            cnn = Connection.getConnection();
            cnn.Open();
            cm = new SqlCommand("TK_SL N'" + cbbkhoa.Text + "'", cnn);
            string dr = cm.ExecuteScalar().ToString();
            return dr;
        }
        //TKsl cấp quản lý nhà nước:
        public string lableSLNN()
        {
            cnn = Connection.getConnection();
            cnn.Open();
            cm = new SqlCommand("TK_SLNN N'" + cbbkhoa.Text + "'", cnn);
            string dr = cm.ExecuteScalar().ToString();
            return dr;
        }
        //cấp bộ
        public string lableSLB()
        {
            cnn = Connection.getConnection();
            cnn.Open();
            cm = new SqlCommand("TK_SLB N'" + cbbkhoa.Text + "'", cnn);
            string dr = cm.ExecuteScalar().ToString();
            return dr;
        }

        //Học viện:
        public string lableSLHV()
        {
            cnn = Connection.getConnection();
            cnn.Open();
            cm = new SqlCommand("TK_SLHV N'" + cbbkhoa.Text + "'", cnn);
            string dr = cm.ExecuteScalar().ToString();
            return dr;
        }

        //Cơ sở:
        public string lableSLCS()
        {
            cnn = Connection.getConnection();
            cnn.Open();
            cm = new SqlCommand("TK_SLCS N'" + cbbkhoa.Text + "'", cnn);
            string dr = cm.ExecuteScalar().ToString();
            return dr;
        }
        //đề tài loại giỏi:
        public string lableSLG()
        {
            cnn = Connection.getConnection();
            cnn.Open();
            cm = new SqlCommand("TK_SLG N'" + cbbkhoa.Text + "'", cnn);
            string dr = cm.ExecuteScalar().ToString();
            return dr;
        }
        //Khá:
        public string lableSLK()
        {
            cnn = Connection.getConnection();
            cnn.Open();
            cm = new SqlCommand("TK_SLK N'" + cbbkhoa.Text + "'", cnn);
            string dr = cm.ExecuteScalar().ToString();
            return dr;
        }

        private void cbbkhoa_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbbkhoa.SelectedIndex != -1)
            {
                dataTK.DataSource = modify.Table("TKe_Khoa N'" + cbbkhoa.Text + "'");
                lbSL.Text = lableSL();
                lbSLNN.Text = lableSLNN();
                lbSLB.Text = lableSLB();
                lbSLHV.Text = lableSLHV();
                lbSLCS.Text = lableSLCS();
                lbSLG.Text = lableSLG();
                lbSLK.Text = lableSLK();

            }
        }

        private void search_TextChanged(object sender, EventArgs e)
        {
            string query = "SEARCH_DT'" + search.Text + "'";
            dataTK.DataSource = modify.Table(query);
        }
    }
}
