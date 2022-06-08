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
using System.Windows.Forms.DataVisualization.Charting;

namespace TTCSDL
{
    public partial class ThongKeBoMon : Form
    {
        public ThongKeBoMon()
        {
            InitializeComponent();
            customizeDesing();
        }

        Modify modify = new Modify();
        Connection cn = new Connection();
        SqlConnection cnn;
        SqlCommand cm;
        SqlDataAdapter da;


        public void ShowCombobox()
        {
            cnn = Connection.getConnection();
            cnn.Open();
            cm = new SqlCommand("Select * from bomon", cnn);
            var dr = cm.ExecuteReader();
            var dt = new DataTable();
            dt.Load(dr);
            dr.Dispose();
            cbbbm.DisplayMember = "tenbm";
            cbbbm.DataSource = dt;

        }

        private void customizeDesing()
        {
            dataTK.DataSource = modify.Table("ThongKe_Khoa");
        }

        private void ThongKeBoMon_Load(object sender, EventArgs e)
        {
            ShowCombobox();
            fillChart();
        }

        private void fillChart()
        {
            cnn = Connection.getConnection();
            DataSet ds = new DataSet();
            cnn.Open();
            SqlDataAdapter adapt = new SqlDataAdapter("chartbomon", cnn);
            adapt.Fill(ds);
            chart1.DataSource = ds;
            chart1.Series["Series1"].XValueMember = "tenbm";
            chart1.Series["Series1"].YValueMembers = "soluongdetai";
            chart1.Titles.Add("Thống kê số lượng theo Bộ môn");
            cnn.Close();
            chart1.Series["Series1"].ChartType = SeriesChartType.Pie;
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


        //full TKBM:
        //thống kê tổng sl:
        public string lableSL()
        {
            cnn = Connection.getConnection();
            cnn.Open();
            cm = new SqlCommand("TKBM_SL N'" + cbbbm.Text + "'", cnn);
            string dr = cm.ExecuteScalar().ToString();
            return dr;
        }
        //TKsl cấp quản lý nhà nước:
        public string lableSLNN()
        {
            cnn = Connection.getConnection();
            cnn.Open();
            cm = new SqlCommand("TKBM_SLNN N'" + cbbbm.Text + "'", cnn);
            string dr = cm.ExecuteScalar().ToString();
            return dr;
        }
        //cấp bộ
        public string lableSLB()
        {
            cnn = Connection.getConnection();
            cnn.Open();
            cm = new SqlCommand("TKBM_SLB N'" + cbbbm.Text + "'", cnn);
            string dr = cm.ExecuteScalar().ToString();
            return dr;
        }

        //Học viện:
        public string lableSLHV()
        {
            cnn = Connection.getConnection();
            cnn.Open();
            cm = new SqlCommand("TKBM_SLHV N'" + cbbbm.Text + "'", cnn);
            string dr = cm.ExecuteScalar().ToString();
            return dr;
        }

        //Cơ sở:
        public string lableSLCS()
        {
            cnn = Connection.getConnection();
            cnn.Open();
            cm = new SqlCommand("TKBM_SLCS N'" + cbbbm.Text + "'", cnn);
            string dr = cm.ExecuteScalar().ToString();
            return dr;
        }
        //đề tài loại giỏi:
        public string lableSLG()
        {
            cnn = Connection.getConnection();
            cnn.Open();
            cm = new SqlCommand("TKBM_SLG N'" + cbbbm.Text + "'", cnn);
            string dr = cm.ExecuteScalar().ToString();
            return dr;
        }
        //Khá:
        public string lableSLK()
        {
            cnn = Connection.getConnection();
            cnn.Open();
            cm = new SqlCommand("TKBM_SLK N'" + cbbbm.Text + "'", cnn);
            string dr = cm.ExecuteScalar().ToString();
            return dr;
        }


        private void cbbbm_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbbbm.SelectedIndex != -1)
            {
                dataTK.DataSource = modify.Table("TKe_BM N'" + cbbbm.Text + "'");
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

        private void chart1_Click(object sender, EventArgs e)
        {

        }
    }
}
