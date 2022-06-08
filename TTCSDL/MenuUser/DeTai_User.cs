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
    public partial class DeTai_User : Form
    {
        string makhoa = "", quyen = "";
        Modify modify = new Modify();
        public DeTai_User()
        {
            InitializeComponent();
        }

        private void DeTai_User_Load(object sender, EventArgs e)
        {
            modify = new Modify();

            try
            {
                dataDeTai.DataSource = modify.Table("DT_USER'" + makhoa + "'");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
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

        private void dataDeTai_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dataDeTai.Rows.Count > 1)
            {
                txtmadt.Text = dataDeTai.SelectedRows[0].Cells[0].Value.ToString();
                txttendt.Text = dataDeTai.SelectedRows[0].Cells[1].Value.ToString();
                txtcndt.Text = dataDeTai.SelectedRows[0].Cells[2].Value.ToString();
                txtcapql.Text = dataDeTai.SelectedRows[0].Cells[4].Value.ToString();
                txtcn.Text = dataDeTai.SelectedRows[0].Cells[5].Value.ToString();
                txttb.Text = dataDeTai.SelectedRows[0].Cells[3].Value.ToString();
                ngaydk.Text = dataDeTai.SelectedRows[0].Cells[6].Value.ToString();
                txtnamth.Text = dataDeTai.SelectedRows[0].Cells[7].Value.ToString();
                txtkp.Text = dataDeTai.SelectedRows[0].Cells[8].Value.ToString();
                txttt.Text = dataDeTai.SelectedRows[0].Cells[9].Value.ToString();
                txtkq.Text = dataDeTai.SelectedRows[0].Cells[10].Value.ToString();
            }
        }

        private void btnExportFile_Click(object sender, EventArgs e)
        {
            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                //gọi hàm ToExcel() với tham số là dtgDSHS và filename từ SaveFileDialog
                export2Excel(dataDeTai, saveFileDialog1.FileName);
            }
        }


        private void search_TextChanged(object sender, EventArgs e)
        {
            string name = search.Text.Trim();
            if (name == "")
            {
                DeTai_User_Load(sender, e);
            }
            else
            {
                string query = "select * from detai where tendt like '%" + name + "%'";
                dataDeTai.DataSource = modify.Table(query);
            }
        }

        private void dataDeTai_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            TTThanhVien_PD tTThanhVien_PD = new TTThanhVien_PD(txtmadt.Text);
            tTThanhVien_PD.ShowDialog();
        }

        public DeTai_User(string makhoa, string quyen)
        {
            InitializeComponent();
            this.makhoa = makhoa;
            this.quyen = quyen;
        }
    }
}
