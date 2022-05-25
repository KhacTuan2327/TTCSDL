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

namespace TTCSDL
{
    public partial class TTThanhVien_PD : Form
    {
        string madt;
        public TTThanhVien_PD()
        {
            InitializeComponent();
        }
        public TTThanhVien_PD(string madt)
        {
            InitializeComponent();
            this.madt = madt;
        }
        Modify modify = new Modify();

        private void TTThanhVien_PD_Load(object sender, EventArgs e)
        {
            modify = new Modify();
            // Hiện bảng
            try
            {
                dataDeTai.DataSource = modify.Table("tt_nhansu_pd'"+madt+"'");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dataDeTai_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            string gt;
            if (dataDeTai.Rows.Count > 1)
            {
                txtmacb.Text = dataDeTai.SelectedRows[0].Cells[0].Value.ToString();
                txttencb.Text = dataDeTai.SelectedRows[0].Cells[1].Value.ToString();
                gt = dataDeTai.SelectedRows[0].Cells[2].Value.ToString();
                if(gt == "Nam")
                {
                    rdoNam.Checked = true;
                    rdoNu.Checked = false;
                }
                else
                {
                    rdoNu.Checked = true;
                    rdoNam.Checked = false;
                }
                NgaySinh.Text = dataDeTai.SelectedRows[0].Cells[3].Value.ToString();
                txtcapbac.Text = dataDeTai.SelectedRows[0].Cells[4].Value.ToString();
                txtchucvu.Text = dataDeTai.SelectedRows[0].Cells[5].Value.ToString();
                txtsdt.Text = dataDeTai.SelectedRows[0].Cells[6].Value.ToString();
                txttgtg.Text = dataDeTai.SelectedRows[0].Cells[7].Value.ToString();
                txtvaitro.Text = dataDeTai.SelectedRows[0].Cells[8].Value.ToString();
                txtbomon.Text = dataDeTai.SelectedRows[0].Cells[9].Value.ToString();
            }
        }
    }
}
